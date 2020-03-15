// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.ProtocolDevIo
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System;

namespace LedContrlCardDebug
{
  internal class ProtocolDevIo
  {
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
      buf[2] = Convert.ToByte((int) Length + 7);
      for (int index = 0; index < (int) Length; ++index)
        buf[3 + index] = Src[index];
      int num = (int) Crc16.Crc16Calculate((ushort) 0, buf, (ushort) Convert.ToByte((int) Length + 3));
      buf.CopyTo((Array) Dst, 1);
      Dst[0] = Convert.ToByte('S');
      Dst[4 + (int) Length] = Convert.ToByte(num % 256);
      Dst[4 + (int) Length + 1] = Convert.ToByte(num / 256);
      Dst[4 + (int) Length + 2] = Convert.ToByte('@');
      return 4 + (int) Length + 3;
    }

    public static bool CheckCommuPack(byte[] RxPack, int Length)
    {
      byte[] buf = new byte[1040];
      if (RxPack[0] != (byte) 83 || RxPack[Length - 1] != (byte) 64 || (RxPack[2] != (byte) 0 || (int) RxPack[3] != Length))
        return false;
      Buffer.BlockCopy((Array) RxPack, 1, (Array) buf, 0, Length - 1);
      int num = (int) Crc16.Crc16Calculate((ushort) 0, buf, (ushort) Convert.ToByte(Length - 4));
      return (int) Convert.ToByte(num % 256) == (int) buf[Length - 4] && (int) Convert.ToByte(num / 256) == (int) buf[Length - 3];
    }
  }
}
