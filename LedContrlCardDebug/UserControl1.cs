// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.UserControl1
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System.ComponentModel;
using System.Windows.Forms;

namespace LedContrlCardDebug
{
  public class UserControl1 : UserControl
  {
    private IContainer components;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.AutoScaleMode = AutoScaleMode.Font;
    }

    public UserControl1()
    {
      this.InitializeComponent();
    }
  }
}
