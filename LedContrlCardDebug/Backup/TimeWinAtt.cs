// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.TimeWinAtt
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System.Runtime.InteropServices;

namespace LedContrlCardDebug
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct TimeWinAtt
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
    public byte TextFont;
    public byte TextSize;
    public byte TextColor;
    public ushort TimeOffset;
    public byte StyleLeng;
  }
}
