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
            Dictionary<string, SerialPort> screenPortDic = new Dictionary<string, SerialPort>();
            screenPortDic.Add("入楦", new SerialPort("COM2", 9600));
            screenPortDic.Add("贴底", new SerialPort("COM2", 9600));
            screenPortDic.Add("包装", new SerialPort("COM2", 9600));
            if (args.Length < 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("请输入正确的参数启动 LED 屏控制程序。");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("参数如下：-i 初始化屏幕");
                Console.WriteLine("        ：-r 更新数据，参数为九组数量，顺序为：投料 包装 清洁度 针车不良 高胶 脱胶 目标产量 节拍 产量 总回收");
                Console.ForegroundColor = ConsoleColor.White;
                System.Environment.Exit(0);
            }
            else
            {
                switch (args[0])
                {
                    case "-i":
                        InitialLEDScreen(screenPortDic);
                        break;
                    case "-r":
                        if (args.Length < 10) 
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("请输入正确的参数启动 LED 屏控制程序。");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("参数如下：-i 初始化屏幕");
                            Console.WriteLine("        ：-r 更新数据，参数为九组数量，顺序为：投料 包装 清洁度 针车不良 高胶 脱胶 目标产量 节拍 产量 总回收");
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Environment.Exit(0);
                        }
                        string[] test = new string[] { args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9] };
                        RefreshLEDQty(test, screenPortDic);
                        break;
                    default:
                        break;
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

        private static void RefreshLEDQty(string[] qty,Dictionary<string, SerialPort> comPorts) 
        {
            foreach (var key in comPorts.Keys)
            {
                switch (key.ToString())
                {
                    case "入楦":
                        RefreshRuXuanLEDScreenQty(qty, comPorts[key.ToString()]);
                        break;
                    case "贴底":
                        RefreshTieDiLEDScreenQty(qty, comPorts[key.ToString()]);
                        break;
                    default:
                        RefreshBaoZhuangLEDScreenQty(qty, comPorts[key.ToString()]);
                        break;
                }
            }
        }

        private static void RefreshRuXuanLEDScreenQty(string[] qtys, SerialPort comPort) 
        {
            CommWithLedController comm = new CommWithLedController(comPort, 255);
            CountStringNoAndFillSpace(qtys);
            comm.SendDataPack(qtys[2], 40, 0, 0, 16);
            comm.SendDataPack(qtys[3], 40, 18, 0, 16);
            comm.SendDataPack(qtys[0], 33, 54, 0, 16);
            comm.SendDataPack(qtys[1], 105, 54, 0, 16);
            comPort.Close();
        }

        private static void RefreshBaoZhuangLEDScreenQty(string[] qtys, SerialPort comPort)
        {
            CommWithLedController comm = new CommWithLedController(comPort, 255);
            CountStringNoAndFillSpace(qtys);
            comm.SendDataPack(qtys[7], 30, 0, 0, 16);
            comm.SendDataPack(qtys[8], 110, 0, 0, 16);
            comm.SendDataPack(qtys[0], 70, 18, 0, 16);
            comm.SendDataPack(qtys[1], 70, 36, 0, 16);
            comm.SendDataPack(qtys[6], 70, 54, 0, 16);
            comPort.Close();
        }


        private static void RefreshTieDiLEDScreenQty(string[] qtys, SerialPort comPort)
        {
            CommWithLedController comm = new CommWithLedController(comPort, 255);
            CountStringNoAndFillSpace(qtys);
            comm.SendDataPack(qtys[4], 40, 0, 0, 16);
            comm.SendDataPack(qtys[5], 40, 18, 0, 16);
            comm.SendDataPack(qtys[0], 33, 54, 0, 16);
            comm.SendDataPack(qtys[1], 105, 54, 0, 16);
            comPort.Close();
        }

        private static string[] CountStringNoAndFillSpace(string[] qtys)
        {
            for (int i = 0; i < qtys.Length; i++)
            {
                if (qtys[i].Length < 4)
                {
                    int times = 4 - qtys[i].Length;
                    for(int j = 0; j< times; j++)
                    {
                        qtys[i] = qtys[i] + " ";
                    }
                }
            }
            return qtys;
        }

        private static void InitialLEDScreen(Dictionary<string, SerialPort> comPorts) 
        {
            foreach (var key in comPorts.Keys) 
            {
                switch(key.ToString())
                {
                    case "入楦":
                        InitialRuXuanLEDScreen(comPorts[key.ToString()]);
                        break;
                    case "贴底":
                        InitialTieDiLEDScreen(comPorts[key.ToString()]);
                        break;
                    default:
                        InitialBaoZhuangLEDScreen(comPorts[key.ToString()]);
                        break;
                }
            }
        }

        private static void InitialRuXuanLEDScreen(SerialPort comPort)
        {
            CommWithLedController comm = new CommWithLedController(comPort, 255);
            comm.SetScreenDisplayMode();
            Console.WriteLine(comm.commuStatus);
            comm.SendDataPack("清洁度 0", 0, 0, 0, 16);
            comm.SendDataPack("针车不良 0", 0, 18, 0, 16);
            comm.SendDataPack("投料0    包装0", 0, 54, 0, 16);
            comPort.Close();
        }

        private static void InitialTieDiLEDScreen(SerialPort comPort) 
        {
            CommWithLedController comm = new CommWithLedController(comPort, 255);
            comm.SetScreenDisplayMode();
            Console.WriteLine(comm.commuStatus);
            comm.SendDataPack("高胶 0", 0, 0, 0, 16);
            comm.SendDataPack("脱胶 0", 0, 18, 0, 16);
            comm.SendDataPack("投料0    包装0", 0, 54, 0, 16);
            comPort.Close();
        }

        private static void InitialBaoZhuangLEDScreen(SerialPort comPort) 
        {
            CommWithLedController comm = new CommWithLedController(comPort, 255);
            comm.SetScreenDisplayMode();
            Console.WriteLine(comm.commuStatus);
            comm.SendDataPack("目标0     节拍0", 0, 0, 0, 16);
            comm.SendDataPack("加工投料 0", 0, 18, 0, 16);
            comm.SendDataPack("包装数量 0", 0, 36, 0, 16);
            comm.SendDataPack("回收数量 0", 0, 54, 0, 16);
            comPort.Close();
        }
    }

    class CommWithLedController
    {
        private DispText sDispText;
        private SyncCommu sSyncCommu;
        private byte cRxNumber;
        public static COMMU_ATT sCommuAtt;
        private byte[] pRxBuf = new byte[70];
        private SerialPort comPort;
        public string commuStatus;
        private byte[] pCommuTx = new byte[70];
        private byte[] pTxBuf = new byte[70];
        private int txLength = 0;

        public CommWithLedController(SerialPort com, int screenId)
        {
            this.comPort = com;
            this.comPort.Open();
            this.comPort.DataReceived += new SerialDataReceivedEventHandler(this.CheckReturnData);
            this.sSyncCommu.Head = (byte)253;
            CommWithLedController.sCommuAtt.ScreenId = Convert.ToByte(screenId);
            CommWithLedController.sCommuAtt.BaudRate = 9600; //串口波特率 9600 / 38400 /115200
            CommWithLedController.sCommuAtt.ComNo = (byte)0;
            this.cRxNumber = (byte)0;
        }

        private void CheckReturnData(object sender, SerialDataReceivedEventArgs e)
        {
            int i = (int)this.cRxNumber;
            for (this.cRxNumber += Convert.ToByte(this.comPort.BytesToRead); i < (int)this.cRxNumber; ++i)
            {
                this.pRxBuf[i] = Convert.ToByte(this.comPort.ReadByte());
            }
        }

        public void CheckCommuStatus()
        {
            if (ProtocolDevIo.CheckCommuPack(this.pRxBuf, (int)this.cRxNumber))
            {
                if (this.pRxBuf[4] == (byte)0)
                {
                    this.commuStatus = "发送成功";
                    this.cRxNumber = (byte)0;
                }
                else
                    this.commuStatus = "应用数据异常";
            }
            else
            {
                this.commuStatus = "终端无返回";
            }
        }


        // 初始化屏幕病设置显示模式为二次开发模式
        public void SetScreenDisplayMode()
        {
            byte[] pBuf20 = new byte[32];
            pBuf20[0] = 2;
            pBuf20[1] = Convert.ToByte(0);
            pTxBuf[0] = 5;
            pBuf20.CopyTo(pTxBuf, 1);
            int txLength = 3;
            sCommuAtt.ScreenId = 255;
            int commu_tx = ProtocolDevIo.CreateCommuPack(pCommuTx, pTxBuf, sCommuAtt.ScreenId, sCommuAtt.ComNo, Convert.ToByte(txLength));
            comPort.Write(new byte[64], 0, commu_tx);
            Thread.Sleep(100);
            this.CleanLEDContents();//设置之后先清除屏幕内容
        }

        //清除屏幕内容
        public void CleanLEDContents()
        {
            pTxBuf[0] = 16; //16是清屏幕的操作类型
            int commu_tx = ProtocolDevIo.CreateCommuPack(pCommuTx, pTxBuf, sCommuAtt.ScreenId, sCommuAtt.ComNo, Convert.ToByte(1));
            this.comPort.Write(pCommuTx, 0, commu_tx);
            Thread.Sleep(200);
            if (ProtocolDevIo.CheckCommuPack(this.pRxBuf, (int)this.cRxNumber))
            {
                if (this.pRxBuf[4] == (byte)0)
                {
                    this.commuStatus = "清除屏幕指令发送成功";
                    this.cRxNumber = (byte)0;
                }
                else
                    this.commuStatus = "清除屏幕指令应用数据异常";
            }
            else
            {
                this.commuStatus = "清除屏幕指令终端无返回";
            }
        }

        //发送文本数据包到 LED 屏幕
        public void SendDataPack(string text, int xPos, int yPos, int space, int fontSize)
        {
            byte[] pBuf20 = new byte[70];
            pBuf20 = Encoding.Default.GetBytes(text);
            sDispText.XPos = Convert.ToUInt16(xPos);
            sDispText.YPos = Convert.ToUInt16(yPos);
            sDispText.Space = Convert.ToByte(0);
            sDispText.Leng = Convert.ToByte(pBuf20.Length);
            sDispText.Font = Convert.ToByte(1);
            sDispText.Size = Convert.ToByte(fontSize);
            sDispText.Color = Convert.ToByte(1);
            pCommuTx = new byte[70];
            pTxBuf = new byte[70];
            pTxBuf[0] = 23;
            pBuf20 = new byte[32];
            pBuf20 = StructToBytes(sDispText, Marshal.SizeOf(sDispText));
            pBuf20.CopyTo(pTxBuf, 1);
            txLength = 1 + Marshal.SizeOf(sDispText); ;
            pBuf20 = Encoding.Default.GetBytes(text);
            pBuf20.CopyTo(pTxBuf, 1 + Marshal.SizeOf(sDispText));
            txLength += pBuf20.Length;
            int com_tx = ProtocolDevIo.CreateCommuPack(pCommuTx, pTxBuf, sCommuAtt.ScreenId, sCommuAtt.ComNo, Convert.ToByte(txLength));
            comPort.Write(pCommuTx, 0, com_tx);
            Thread.Sleep(200);
            if (this.cRxNumber > (byte)7)
            {
                if (ProtocolDevIo.CheckCommuPack(this.pRxBuf, (int)this.cRxNumber))
                {
                    if (this.pRxBuf[4] == (byte)0)
                    {
                        Console.WriteLine("文字内容：(" + text + ")发送成功");
                        this.cRxNumber = (byte)0;
                    }
                    else
                    {
                        Console.WriteLine("文字发送应用数据异常");
                    }

                }
                else
                {
                    Console.WriteLine("文字发送终端无返回");
                }
            }
            else
            {
                Console.WriteLine("文字发送终端无返回");
            }
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
            byte[] buf = new byte[32];
            buf[0] = PackNo;
            buf[1] = ObjId;
            buf[2] = Convert.ToByte(Length + 7);
            for (int i = 0; i < Length; i++)
            {
                buf[3 + i] = Src[i];
            }
            int crc = Crc16.Crc16Calculate(0, buf, Convert.ToByte(Length + 3));
            buf.CopyTo(Dst, 1);
            Dst[0] = Convert.ToByte('S');
            Dst[4 + Length] = Convert.ToByte(crc % 256);
            Dst[4 + Length + 1] = Convert.ToByte(crc / 256);
            Dst[4 + Length + 2] = Convert.ToByte('@');
            return 4 + Length + 3;
        }

        //根据返回的信息判断消息发送是否成功
        public static bool CheckCommuPack(byte[] RxPack, int Length)
        {
            byte[] buf = new byte[128];
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
