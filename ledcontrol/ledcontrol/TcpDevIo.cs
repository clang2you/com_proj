using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ledcontrol;

namespace ledcontrol
{
    public class CommuTcp
    {
        public byte[] EthentRxBuf = new byte[1024];
        private int RxRes = 0;
        public Socket TcpSocket = null;
        public COMMU_ATT sCommuAtt;
        public int sleepIntervel = 500;

        public CommuTcp(COMMU_ATT commuAtt)
        {
            sCommuAtt = commuAtt;
            TcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void ReceiveMessage(IAsyncResult ar)
        {
            try
            {
                Socket asyncState = ar.AsyncState as Socket;
                int Length = asyncState.EndReceive(ar);
                RxRes = !ProtocolDevIo.CheckCommuPack(EthentRxBuf, Length) ? 1 : (EthentRxBuf[4] != (byte)0 ? -1 : 0);
                asyncState.BeginReceive(EthentRxBuf, 0, EthentRxBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), (object)asyncState);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool IsSocketConnected()
        {
            bool flag = true;
            bool blocking = TcpSocket.Blocking;
            try
            {
                byte[] buffer = new byte[1];
                TcpSocket.Blocking = false;
                TcpSocket.Send(buffer, 0, SocketFlags.None);
                flag = true;
            }
            catch (SocketException ex)
            {
                flag = ex.NativeErrorCode.Equals(10035);
            }
            finally
            {
                TcpSocket.Blocking = blocking;
            }
            return flag;
        }

        public bool NetConect()
        {
            //if (TcpSocket == null) 
            //{
            //    TcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //}
            if (!IsSocketConnected())
            {
                try
                {
                    TcpSocket.Connect(sCommuAtt.IpAdd, sCommuAtt.Port);
                    TcpSocket.BeginReceive(EthentRxBuf, 0, EthentRxBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), (object)TcpSocket);
                }
                catch
                {
                    return false;
                }
            }
            return TcpSocket.Connected;
        }

        public void NetDisconect()
        {
            if (!IsSocketConnected())
                return;
            TcpSocket.Shutdown(SocketShutdown.Both);
            TcpSocket.Close();
        }

        public int TxAppPack(byte[] numArray, byte[] txBuf, int Length)
        {
            int num = 200;
            //byte[] numArray = new byte[272];
            RxRes = 1;
            if (!TcpSocket.Connected || Length > num)
                return RxRes;
            int commuPack = ProtocolDevIo.CreateCommuPack(numArray, txBuf, Convert.ToByte(sCommuAtt.ScreenId), Convert.ToByte(sCommuAtt.ComNo), Convert.ToByte(Length));
            TcpSocket.BeginSend(numArray, 0, commuPack, SocketFlags.None, (AsyncCallback)null, (object)null);
            Thread.Sleep(sleepIntervel);
            return RxRes;
        }
    }
}
