using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace ledcontrol
{
    /// <summary>
    /// 由于 python 控制 led 屏问题，只能改变思路，C# 编写一个 Led 控制程序再由 python 用命令行形式调用
    /// 因为目前需要实现的功能不多（LF 系统仅仅使用到了文本显示功能），故将各个类都整合在一个文件中
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            SerialPort comPort = null;
            if (args.Length < 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("请输入正确的参数启动 LED 屏控制程序。");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("参数如下：ledcontrol.exe COM3(屏幕所连接串口名称) 名称=数量（有几个需要显示的就添加几组)");
                Console.ForegroundColor = ConsoleColor.White;
                System.Environment.Exit(0);
            }
            else 
            {
                try
                {
                    comPort = new SerialPort();
                    comPort.PortName = args[0];

                }
                catch (Exception ex) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("创建串口对象失败，错误信息如下：" + ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Environment.Exit(0);
                }
            }

            Dictionary<string, string> contentsDic = new Dictionary<string, string>();
            switch (args.Length) 
            {
                case 6:
                    for (int i = 1; i < args.Length; i++)
                    {
                        string[] tempStrArr = args[i].Split('=');
                        KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(tempStrArr[0], tempStrArr[1]);
                        contentsDic.Add(kvp.Key, kvp.Value); 
                    }
                    break;
            }

            foreach (KeyValuePair<string, string> kvpItem in contentsDic) 
            {
                Console.WriteLine(kvpItem.Key);
                Console.WriteLine(kvpItem.Value);
            }
        }

    }

    class CommWithLedController
    {
        private DispText sDispText;
        private SyncCommu sSyncCommu;
        private byte cRxNumber;
        public static COMMU_ATT sCommuAtt;
        private string resultText;
        private int sndDataCount;
        private byte[] pRxBuf = new byte[256];
        private string sndStatus;

        private CommWithLedController(int screenId)
        {
            this.sSyncCommu.Head = (byte)253;
            CommWithLedController.sCommuAtt.ScreenId = Convert.ToByte(screenId);
            CommWithLedController.sCommuAtt.BaudRate = 9600; //串口波特率 9600 / 38400 /115200
            CommWithLedController.sCommuAtt.ComNo = (byte)0;
            this.cRxNumber = (byte)0;
        }

        //发送文本数据包到 LED 屏幕
        public string SendDataPack(string text, int xPos, int yPos, int space, int fontSize, SerialPort comPort)
        {
            int Length = 0;
            byte[] numArray2 = new byte[768];
            byte[] numArray3 = new byte[1024];
            byte[] bytes2 = Encoding.Default.GetBytes(text);
            GenerateText(text, xPos, yPos, space, fontSize);
            StructToBytes((object)this.sDispText, Marshal.SizeOf((object)this.sDispText)).CopyTo((Array)numArray2, 1);
            int num1 = 1 + Marshal.SizeOf((object)this.sDispText);
            bytes2.CopyTo((Array)numArray2, 1 + Marshal.SizeOf((object)this.sDispText));
            Length = num1 + bytes2.Length;

            //for (int index = 0; index < Length; ++index)
            //{
            //    if (numArray2[index] > (byte)15)
            //    {
            //        this.resultText = this.resultText + "0x" + Convert.ToString(numArray2[index], 16) + (object)',';
            //    }
            //    else
            //    {
            //        this.resultText = this.resultText + "0x0" + Convert.ToString(numArray2[index], 16) + (object)',';
            //    }
            //}

            int commuPack = ProtocolDevIo.CreateCommuPack(numArray3, numArray2, CommWithLedController.sCommuAtt.ScreenId, CommWithLedController.sCommuAtt.ComNo, Convert.ToByte(Length));
            //this.resultText = "";
            for (int index = 0; index < commuPack; ++index)
            {
                if (numArray3[index] > (byte)15)
                {
                    this.resultText = this.resultText + "0x" + Convert.ToString(numArray3[index], 16) + (object)',';
                }
                else
                {
                    this.resultText = this.resultText + "0x0" + Convert.ToString(numArray3[index], 16) + (object)',';
                }
            }

            using (comPort) 
            {
                if (!comPort.IsOpen) 
                {
                    comPort.Open();
                }
                comPort.Write(numArray3, 0, commuPack);
                this.sndDataCount = commuPack;
                Thread.Sleep(1000);
                if (this.cRxNumber > (byte)7)
                {
                    if (ProtocolDevIo.CheckCommuPack(this.pRxBuf, (int)this.cRxNumber))
                    {
                        if (this.pRxBuf[4] == (byte)0)
                        {
                            this.sndStatus = "数据发送成功:" + text;
                        }
                        else
                        {
                            this.sndStatus = "应用数据异常";
                        }
                    }
                    else
                    {
                        this.sndStatus = "控制板未返回信号";
                    }
                }
                else 
                {
                    this.sndStatus = "控制板未返回信号";
                }
            }
            return this.sndStatus;
        }

        //用于生成文本指令
        private void GenerateText(string text, int xPos, int yPos, int space, int fontSize)
        {
            byte[] numArray = new byte[512];
            byte[] bytes = Encoding.Default.GetBytes(text);
            this.sDispText.XPos = Convert.ToUInt16(xPos);//x 坐标
            this.sDispText.YPos = Convert.ToUInt16(yPos);//y 坐标
            this.sDispText.Space = Convert.ToByte(space);//间距
            this.sDispText.Leng = Convert.ToByte(bytes.Length);
            this.sDispText.Font = Convert.ToByte(1);//字体选择宋体(0.自定义，1.宋体，2.楷体，3.黑体）
            this.sDispText.Size = Convert.ToByte(fontSize);
            this.sDispText.Color = Convert.ToByte(1);//字体颜色固定红色
        }

        // 结构体转 byte 数组
        public static byte[] StructToBytes(object structObj, int size)
        {
            byte[] destination = new byte[size];
            IntPtr num = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(structObj, num, false);
            Marshal.Copy(num, destination, 0, size);
            Marshal.FreeHGlobal(num);
            return destination;
        }
    }

    /// <summary>
    /// struct 定时开关
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct PowerSwitch
    {
        public byte OptType;
        public ushort OnTime;
        public ushort OffTime;
    }

    /// <summary>
    /// struct 文本显示
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct DispText
    {
        public ushort XPos;
        public ushort YPos;
        public byte Space;
        public byte Leng;
        public byte Font;
        public byte Size;
        public byte Color;
    }

    /// <summary>
    /// struct 校正时间
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct SyncTime
    {
        public byte Second;
        public byte Minute;
        public byte Hour;
        public byte Day;
        public byte Week;
        public byte Month;
        public byte Year;
    }

    /// <summary>
    /// struct SyncCommu 用途暂时未知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct SyncCommu
    {
        public byte Head;
        public ushort Leng;
        public byte Cmd;
        public byte Par;
    }

    /// <summary>
    /// struct COMMU_ATT 用途暂时未知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct COMMU_ATT
    {
        public int Type;
        public byte ScreenId;
        public byte ComNo;
        public int BaudRate;
        public int IP0;
        public int IP1;
        public int IP2;
        public int IP3;
        public int Port;
    }

    /// <summary>
    /// struct 文本框
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct TextWinAtt
    {
        public byte Type;
        public byte No;
        public ushort XPos;
        public ushort YPos;
        public ushort XDot;
        public ushort YDot;
        public ushort Rev1;
        public byte PlayStunt;
        public byte PlaySpeed;
        public byte PlayStay;
        public byte PlayIsClear;
        public byte PageStyle;
        public byte VStyle;
        public byte HStyle;
        public byte Rev2;
        public ushort CodeLeng;
        public byte TextFont;
        public byte TextSize;
        public byte TextColor;
    }

    //智新 LED 屏通讯协议（使用 dotPeek 反编译生成）
    internal class ProtocolDevIo
    {
        //生成通讯包
        public static int CreateCommuPack(
          byte[] Dst,
          byte[] Src,
          byte ObjId,
          byte PackNo,
          byte Length)
        {
            byte[] buf = new byte[264];
            buf[0] = PackNo;
            buf[1] = ObjId;
            buf[2] = Convert.ToByte((int)Length + 7);
            for (int index = 0; index < (int)Length; ++index)
                buf[3 + index] = Src[index];
            int num = (int)Crc16.Crc16Calculate((ushort)0, buf, (ushort)Convert.ToByte((int)Length + 3));
            buf.CopyTo((Array)Dst, 1);
            Dst[0] = Convert.ToByte('S');
            Dst[4 + (int)Length] = Convert.ToByte(num % 256);
            Dst[4 + (int)Length + 1] = Convert.ToByte(num / 256);
            Dst[4 + (int)Length + 2] = Convert.ToByte('@');
            return 4 + (int)Length + 3;
        }

        //根据返回的信息判断消息发送是否成功
        public static bool CheckCommuPack(byte[] RxPack, int Length)
        {
            byte[] buf = new byte[1040];
            if (RxPack[0] != (byte)83 || RxPack[Length - 1] != (byte)64 || (RxPack[2] != (byte)0 || (int)RxPack[3] != Length))
                return false;
            Buffer.BlockCopy((Array)RxPack, 1, (Array)buf, 0, Length - 1);
            int num = (int)Crc16.Crc16Calculate((ushort)0, buf, (ushort)Convert.ToByte(Length - 4));
            return (int)Convert.ToByte(num % 256) == (int)buf[Length - 4] && (int)Convert.ToByte(num / 256) == (int)buf[Length - 3];
        }
    }

    // Crc16 校验
    internal class Crc16
    {
        public static ushort Crc16Calculate(ushort crc_ini, byte[] buf, ushort len)
        {
            ushort[] numArray = new ushort[16]
      {
        (ushort) 0,
        (ushort) 4129,
        (ushort) 8258,
        (ushort) 12387,
        (ushort) 16516,
        (ushort) 20645,
        (ushort) 24774,
        (ushort) 28903,
        (ushort) 33032,
        (ushort) 37161,
        (ushort) 41290,
        (ushort) 45419,
        (ushort) 49548,
        (ushort) 53677,
        (ushort) 57806,
        (ushort) 61935
      };
            ushort num1 = crc_ini;
            if (len == (ushort)0)
                return 0;
            for (ushort index = 0; (int)index < (int)len; ++index)
            {
                byte num2 = Convert.ToByte((int)num1 / 256 / 16);
                ushort num3 = (ushort)((uint)(ushort)((uint)num1 << 4) ^ (uint)numArray[(int)num2 ^ (int)buf[(int)index] / 16]);
                byte num4 = Convert.ToByte((int)num3 / 256 / 16);
                num1 = (ushort)((uint)(ushort)((uint)num3 << 4) ^ (uint)numArray[(int)num4 ^ (int)buf[(int)index] & 15]);
            }
            return num1;
        }

        public static ushort CrcOne(byte buf, ushort crx)
        {
            ushort[] numArray = new ushort[16]
      {
        (ushort) 0,
        (ushort) 4129,
        (ushort) 8258,
        (ushort) 12387,
        (ushort) 16516,
        (ushort) 20645,
        (ushort) 24774,
        (ushort) 28903,
        (ushort) 33032,
        (ushort) 37161,
        (ushort) 41290,
        (ushort) 45419,
        (ushort) 49548,
        (ushort) 53677,
        (ushort) 57806,
        (ushort) 61935
      };
            byte num1 = Convert.ToByte((int)crx / 256 / 16);
            crx <<= 4;
            ushort num2 = numArray[(int)num1 ^ (int)buf / 16];
            crx ^= num2;
            byte num3 = Convert.ToByte((int)crx / 256 / 16);
            crx <<= 4;
            ushort num4 = numArray[(int)num3 ^ (int)buf & 15];
            crx ^= num4;
            return crx;
        }
    }
}
