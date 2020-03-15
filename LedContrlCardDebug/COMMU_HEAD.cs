// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.COMMU_HEAD
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System.Runtime.InteropServices;

namespace LedContrlCardDebug
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct COMMU_HEAD
  {
    public byte StartCode;
    public byte ObjId;
    public byte LocId;
    public byte Leng;
    public byte PackType;
  }
}
