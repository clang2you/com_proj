// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.Crc16
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System;

namespace LedContrlCardDebug
{
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
      if (len == (ushort) 0)
        return 0;
      for (ushort index = 0; (int) index < (int) len; ++index)
      {
        byte num2 = Convert.ToByte((int) num1 / 256 / 16);
        ushort num3 = (ushort) ((uint) (ushort) ((uint) num1 << 4) ^ (uint) numArray[(int) num2 ^ (int) buf[(int) index] / 16]);
        byte num4 = Convert.ToByte((int) num3 / 256 / 16);
        num1 = (ushort) ((uint) (ushort) ((uint) num3 << 4) ^ (uint) numArray[(int) num4 ^ (int) buf[(int) index] & 15]);
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
      byte num1 = Convert.ToByte((int) crx / 256 / 16);
      crx <<= 4;
      ushort num2 = numArray[(int) num1 ^ (int) buf / 16];
      crx ^= num2;
      byte num3 = Convert.ToByte((int) crx / 256 / 16);
      crx <<= 4;
      ushort num4 = numArray[(int) num3 ^ (int) buf & 15];
      crx ^= num4;
      return crx;
    }
  }
}
