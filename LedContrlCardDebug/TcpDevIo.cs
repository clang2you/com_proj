// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.CommuTcp
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System;
using System.Net.Sockets;

namespace LedContrlCardDebug
{
  internal class CommuTcp
  {
    public static byte[] EthentRxBuf = new byte[1024];
    private static int RxRes = 0;
    private static Socket TcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    public static void ReceiveMessage(IAsyncResult ar)
    {
      try
      {
        Socket asyncState = ar.AsyncState as Socket;
        int Length = asyncState.EndReceive(ar);
        CommuTcp.RxRes = !ProtocolDevIo.CheckCommuPack(CommuTcp.EthentRxBuf, Length) ? 1 : (CommuTcp.EthentRxBuf[4] != (byte) 0 ? -1 : 0);
        asyncState.BeginReceive(CommuTcp.EthentRxBuf, 0, CommuTcp.EthentRxBuf.Length, SocketFlags.None, new AsyncCallback(CommuTcp.ReceiveMessage), (object) asyncState);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private static bool IsSocketConnected()
    {
      bool flag = true;
      bool blocking = CommuTcp.TcpSocket.Blocking;
      try
      {
        byte[] buffer = new byte[1];
        CommuTcp.TcpSocket.Blocking = false;
        CommuTcp.TcpSocket.Send(buffer, 0, SocketFlags.None);
        flag = true;
      }
      catch (SocketException ex)
      {
        flag = ex.NativeErrorCode.Equals(10035);
      }
      finally
      {
        CommuTcp.TcpSocket.Blocking = blocking;
      }
      return flag;
    }

    public static bool NetConect()
    {
      if (!CommuTcp.IsSocketConnected())
      {
        try
        {
          CommuTcp.TcpSocket.Connect(Convert.ToString(FormMain.sCommuAtt.IP0) + (object) '.' + Convert.ToString(FormMain.sCommuAtt.IP1) + (object) '.' + Convert.ToString(FormMain.sCommuAtt.IP2) + (object) '.' + Convert.ToString(FormMain.sCommuAtt.IP3), FormMain.sCommuAtt.Port);
          CommuTcp.TcpSocket.BeginReceive(CommuTcp.EthentRxBuf, 0, CommuTcp.EthentRxBuf.Length, SocketFlags.None, new AsyncCallback(CommuTcp.ReceiveMessage), (object) CommuTcp.TcpSocket);
        }
        catch
        {
          return false;
        }
      }
      return CommuTcp.TcpSocket.Connected;
    }

    public static void NetDisconect()
    {
      if (!CommuTcp.IsSocketConnected())
        return;
      CommuTcp.TcpSocket.Close();
    }

    public static int TxAppPack(byte[] txBuf, int Length)
    {
      int num = 200;
      byte[] numArray = new byte[272];
      CommuTcp.RxRes = 1;
      if (!CommuTcp.TcpSocket.Connected || Length > num)
        return CommuTcp.RxRes;
      int commuPack = ProtocolDevIo.CreateCommuPack(numArray, txBuf, Convert.ToByte(FormMain.sCommuAtt.ScreenId), Convert.ToByte(FormMain.sCommuAtt.ComNo), Convert.ToByte(Length));
      CommuTcp.TcpSocket.BeginSend(numArray, 0, commuPack, SocketFlags.None, (AsyncCallback) null, (object) null);
      for (int index = 0; index < 100; ++index)
        FormMain.DelayMs(30);
      return CommuTcp.RxRes;
    }
  }
}
