// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.CommuUdp
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System;
using System.Net;
using System.Net.Sockets;

namespace LedContrlCardDebug
{
  internal class CommuUdp
  {
    public static byte[] EthentRxBuf = new byte[1024];

    public static int TxAppPack(byte[] txBuf, int Length)
    {
      int num = 200;
      byte[] numArray = new byte[272];
      Console.WriteLine("This is a Client, host name is {0}", (object) Dns.GetHostName());
      IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(Convert.ToString(FormMain.sCommuAtt.IP0) + (object) '.' + Convert.ToString(FormMain.sCommuAtt.IP1) + (object) '.' + Convert.ToString(FormMain.sCommuAtt.IP2) + (object) '.' + Convert.ToString(FormMain.sCommuAtt.IP3)), FormMain.sCommuAtt.Port);
      Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
      if (Length > num)
        return 1;
      int commuPack = ProtocolDevIo.CreateCommuPack(numArray, txBuf, Convert.ToByte(FormMain.sCommuAtt.ScreenId), Convert.ToByte(FormMain.sCommuAtt.ComNo), Convert.ToByte(Length));
      socket.SendTo(numArray, commuPack, SocketFlags.None, (EndPoint) ipEndPoint);
      EndPoint remoteEP = (EndPoint) new IPEndPoint(IPAddress.Any, 0);
      socket.ReceiveTimeout = 3;
      try
      {
        int from = socket.ReceiveFrom(CommuUdp.EthentRxBuf, ref remoteEP);
        socket.Close();
        if (from <= 7 || !ProtocolDevIo.CheckCommuPack(CommuUdp.EthentRxBuf, from))
          return 1;
        return CommuUdp.EthentRxBuf[4] == (byte) 0 ? 0 : -1;
      }
      catch
      {
        socket.Close();
        return 1;
      }
    }
  }
}
