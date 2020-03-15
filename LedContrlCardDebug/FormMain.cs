// Decompiled with JetBrains decompiler
// Type: LedContrlCardDebug.FormMain
// Assembly: LedContrlCardDebug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 421199F9-C8E5-4F42-890A-38D1A92FC762
// Assembly location: C:\Users\lex\Downloads\T系列二次开发调试工具V2.2\LedContrlCardDebug.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LedContrlCardDebug
{
  public class FormMain : Form
  {
    private byte[] pRxBuf = new byte[256];
    private IContainer components;
    private GroupBox groupBox5;
    private ComboBox comboBox17;
    private Label label58;
    private NumericUpDown numericUpDown5;
    private Label label13;
    private Label label12;
    private Label label21;
    private CheckBox checkBox21;
    private NumericUpDown numericUpDown4;
    private Label label2;
    private ComboBox comboBox2;
    private ComboBox comboBox1;
    private Panel panel1;
    private Panel panel2;
    private Label label6;
    private Label label5;
    private TextBox textBox1;
    private Label label7;
    private TextBox textBox2;
    private GroupBox groupBox1;
    private Button button1;
    private Label label8;
    private TextBox textBox3;
    private GroupBox groupBox2;
    private Button button2;
    private Label label9;
    private TextBox textBox4;
    private TextBox textBox5;
    private GroupBox groupBox3;
    private TabControl tabControl1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private TabPage tabPage7;
    private TabPage tabPage8;
    private TabPage tabPage9;
    private TabPage tabPage10;
    private Button button5;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column8;
    private DataGridViewTextBoxColumn Column9;
    private DataGridViewTextBoxColumn Column10;
    private DataGridViewTextBoxColumn Column11;
    private DataGridViewTextBoxColumn Column12;
    private DataGridViewTextBoxColumn Column13;
    private DataGridViewTextBoxColumn Column14;
    private DataGridViewTextBoxColumn Column15;
    private DataGridViewTextBoxColumn Column16;
    private DataGridViewTextBoxColumn Column17;
    private DataGridViewTextBoxColumn Column18;
    private DataGridViewTextBoxColumn Column19;
    private DataGridViewTextBoxColumn Column20;
    private DataGridViewTextBoxColumn Column21;
    private DataGridViewTextBoxColumn Column22;
    private DataGridViewTextBoxColumn Column23;
    private DataGridViewTextBoxColumn Column24;
    private ComboBox comboBox4;
    private Label label14;
    private GroupBox groupBox6;
    private NumericUpDown numericUpDown11;
    private NumericUpDown numericUpDown12;
    private Label label18;
    private Label label19;
    private ComboBox comboBox5;
    private Label label20;
    private GroupBox groupBox4;
    private NumericUpDown numericUpDown9;
    private NumericUpDown numericUpDown10;
    private Label label15;
    private Label label17;
    private GroupBox groupBox8;
    private NumericUpDown numericUpDown15;
    private NumericUpDown numericUpDown16;
    private Label label27;
    private Label label28;
    private GroupBox groupBox7;
    private NumericUpDown numericUpDown13;
    private NumericUpDown numericUpDown14;
    private Label label23;
    private Label label24;
    private ComboBox comboBox6;
    private Label label25;
    private ComboBox comboBox7;
    private Label label26;
    private NumericUpDown numericUpDown1;
    private Label label3;
    private NumericUpDown numericUpDown2;
    private Label label4;
    private ComboBox comboBox8;
    private Label label16;
    private ComboBox comboBox9;
    private Label label22;
    private NumericUpDown numericUpDown3;
    private NumericUpDown numericUpDown6;
    private Label label29;
    private Label label30;
    private Label label36;
    private Label label37;
    private NumericUpDown numericUpDown20;
    private NumericUpDown numericUpDown21;
    private Label label32;
    private Label label34;
    private NumericUpDown numericUpDown8;
    private NumericUpDown numericUpDown17;
    private TabPage tabPage6;
    private NumericUpDown numericUpDown22;
    private Label label40;
    private NumericUpDown numericUpDown19;
    private ComboBox comboBox12;
    private Label label39;
    private Label label38;
    private ComboBox comboBox10;
    private Label label35;
    private NumericUpDown numericUpDown7;
    private NumericUpDown numericUpDown18;
    private Label label31;
    private TextBox textBox9;
    private Label label33;
    private Label label41;
    private Label label42;
    private NumericUpDown numericUpDown23;
    private NumericUpDown numericUpDown24;
    private Label label43;
    private Label label44;
    private NumericUpDown numericUpDown25;
    private NumericUpDown numericUpDown26;
    private Label label45;
    private Label label46;
    private NumericUpDown numericUpDown27;
    private NumericUpDown numericUpDown28;
    private NumericUpDown numericUpDown29;
    private Label label47;
    private ComboBox comboBox11;
    private Label label48;
    private ComboBox comboBox13;
    private Label label49;
    private Label label50;
    private Label label51;
    private NumericUpDown numericUpDown30;
    private NumericUpDown numericUpDown31;
    private Label label52;
    private Label label53;
    private NumericUpDown numericUpDown32;
    private NumericUpDown numericUpDown33;
    private Label label54;
    private Label label55;
    private NumericUpDown numericUpDown34;
    private NumericUpDown numericUpDown35;
    private NumericUpDown numericUpDown36;
    private Label label56;
    private ComboBox comboBox14;
    private Label label57;
    private ComboBox comboBox15;
    private Label label59;
    private NumericUpDown numericUpDown37;
    private Label label60;
    private GroupBox groupBox9;
    private NumericUpDown numericUpDown38;
    private NumericUpDown numericUpDown39;
    private Label label61;
    private Label label62;
    private GroupBox groupBox10;
    private NumericUpDown numericUpDown40;
    private NumericUpDown numericUpDown41;
    private Label label63;
    private Label label64;
    private ComboBox comboBox16;
    private Label label65;
    private ComboBox comboBox18;
    private Label label66;
    private NumericUpDown numericUpDown42;
    private Label label67;
    private GroupBox groupBox11;
    private NumericUpDown numericUpDown43;
    private NumericUpDown numericUpDown44;
    private Label label68;
    private Label label69;
    private GroupBox groupBox12;
    private NumericUpDown numericUpDown45;
    private NumericUpDown numericUpDown46;
    private Label label70;
    private Label label71;
    private ComboBox comboBox19;
    private Label label72;
    private ComboBox comboBox20;
    private Label label73;
    private Label label74;
    private Label label78;
    private Label label80;
    private Label label81;
    private Label label82;
    private ComboBox comboBox23;
    private Label label83;
    private NumericUpDown numericUpDown54;
    private NumericUpDown numericUpDown55;
    private Label label84;
    private TextBox textBox10;
    private Label label85;
    private NumericUpDown numericUpDown56;
    private Label label86;
    private NumericUpDown numericUpDown57;
    private ComboBox comboBox24;
    private Label label87;
    private Label label88;
    private ComboBox comboBox25;
    private Label label89;
    private NumericUpDown numericUpDown58;
    private NumericUpDown numericUpDown59;
    private Label label90;
    private Label label91;
    private CheckBox checkBox1;
    private Label label92;
    private NumericUpDown numericUpDown52;
    private ComboBox comboBox28;
    private ComboBox comboBox27;
    private ComboBox comboBox26;
    private NumericUpDown numericUpDown53;
    private ComboBox comboBox30;
    private Label label93;
    private Label label94;
    private ComboBox comboBox31;
    private Label label95;
    private NumericUpDown numericUpDown60;
    private NumericUpDown numericUpDown61;
    private Label label96;
    private Label label97;
    private Label label98;
    private Label label99;
    private Label label100;
    private NumericUpDown numericUpDown62;
    private NumericUpDown numericUpDown63;
    private Label label101;
    private Label label102;
    private ComboBox comboBox34;
    private TextBox textBox11;
    private ComboBox comboBox33;
    private Label label104;
    private Label label103;
    private ComboBox comboBox35;
    private Label label105;
    private TextBox textBox12;
    private ComboBox comboBox22;
    private ComboBox comboBox29;
    private ComboBox comboBox32;
    private Button button4;
    private Button button3;
    private TextBox textBox13;
    private Label label110;
    private Label label111;
    protected internal NumericUpDown numericUpDown48;
    private Button button6;
    private Button button7;
    private SerialPort serialPort1;
    private Button button8;
    private Label label114;
    private Label label123;
    private Label label122;
    private Label label121;
    private Label label120;
    private Label label119;
    private Label label118;
    private Label label117;
    private Label label116;
    private Label label115;
    private Label label127;
    private Label label128;
    private Label label129;
    private Label label130;
    private Label label131;
    private Label label132;
    private Label label124;
    private Label label125;
    private Label label126;
    private Label label133;
    private Label label134;
    private Label label135;
    private Label label136;
    private Label label137;
    private Label label138;
    private Label label139;
    private Label label140;
    private Label label141;
    private Label label142;
    private Label label143;
    private Label label144;
    private Label label145;
    private TextBox textBox8;
    private TextBox textBox16;
    private TextBox textBox17;
    private TextBox textBox18;
    private Label label146;
    private NumericUpDown numericUpDown68;
    private Label label147;
    private NumericUpDown numericUpDown69;
    private Label label148;
    private NumericUpDown numericUpDown70;
    private Label label149;
    private ComboBox comboBox21;
    private TabPage tabPage1;
    private TextBox textBox14;
    private Label label113;
    private TextBox textBox15;
    private TextBox textBox7;
    private Label label79;
    private Panel panel3;
    private TextBox textBox6;
    private Label label11;
    private ComboBox comboBox3;
    private Label label10;
    private Label label1;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private Label label112;
    private NumericUpDown numericUpDown66;
    private TextBox textBox19;
    private CheckBox checkBox2;
    private Label label75;
    private NumericUpDown numericUpDown47;
    private ComboBox comboBox36;
    private NumericUpDown numericUpDown49;
    private Label label76;
    private Label label77;
    private byte cRxNumber;
    public static COMMU_ATT sCommuAtt;
    private PowerSwitch sPowerSwitch;
    private SyncTime sSyncTime;
    private Pos2 sPos2;
    private DotLine sDotLine;
    private RecPar sRecPar;
    private PolygonPar sPolygonPar;
    private DispText sDispText;
    private TextWinAtt sTextWinAtt;
    private TimeWinAtt sTimeWinAtt;
    private RoundPar sRoundPar;
    private ArcPar sArcPar;
    private SyncCommu sSyncCommu;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.groupBox5 = new GroupBox();
      this.comboBox17 = new ComboBox();
      this.label58 = new Label();
      this.numericUpDown5 = new NumericUpDown();
      this.label13 = new Label();
      this.panel1 = new Panel();
      this.button7 = new Button();
      this.label7 = new Label();
      this.label6 = new Label();
      this.comboBox2 = new ComboBox();
      this.comboBox1 = new ComboBox();
      this.panel2 = new Panel();
      this.textBox8 = new TextBox();
      this.textBox16 = new TextBox();
      this.textBox17 = new TextBox();
      this.textBox18 = new TextBox();
      this.label146 = new Label();
      this.button8 = new Button();
      this.label5 = new Label();
      this.textBox1 = new TextBox();
      this.label12 = new Label();
      this.label21 = new Label();
      this.checkBox21 = new CheckBox();
      this.numericUpDown4 = new NumericUpDown();
      this.label2 = new Label();
      this.textBox2 = new TextBox();
      this.groupBox1 = new GroupBox();
      this.label127 = new Label();
      this.label128 = new Label();
      this.label129 = new Label();
      this.label130 = new Label();
      this.label131 = new Label();
      this.label132 = new Label();
      this.label123 = new Label();
      this.label122 = new Label();
      this.label121 = new Label();
      this.label120 = new Label();
      this.label119 = new Label();
      this.label118 = new Label();
      this.label117 = new Label();
      this.label116 = new Label();
      this.label115 = new Label();
      this.label114 = new Label();
      this.button1 = new Button();
      this.label8 = new Label();
      this.textBox3 = new TextBox();
      this.groupBox2 = new GroupBox();
      this.label124 = new Label();
      this.label125 = new Label();
      this.label126 = new Label();
      this.label133 = new Label();
      this.label134 = new Label();
      this.label135 = new Label();
      this.label136 = new Label();
      this.label137 = new Label();
      this.label138 = new Label();
      this.label139 = new Label();
      this.label140 = new Label();
      this.label141 = new Label();
      this.label142 = new Label();
      this.label143 = new Label();
      this.label144 = new Label();
      this.label145 = new Label();
      this.button2 = new Button();
      this.label9 = new Label();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.groupBox3 = new GroupBox();
      this.button6 = new Button();
      this.button4 = new Button();
      this.button3 = new Button();
      this.button5 = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.textBox19 = new TextBox();
      this.textBox14 = new TextBox();
      this.textBox15 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox6 = new TextBox();
      this.label11 = new Label();
      this.comboBox3 = new ComboBox();
      this.label10 = new Label();
      this.label1 = new Label();
      this.label113 = new Label();
      this.label79 = new Label();
      this.panel3 = new Panel();
      this.numericUpDown66 = new NumericUpDown();
      this.label112 = new Label();
      this.radioButton3 = new RadioButton();
      this.radioButton2 = new RadioButton();
      this.radioButton1 = new RadioButton();
      this.tabPage2 = new TabPage();
      this.dataGridView1 = new DataGridView();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.Column7 = new DataGridViewTextBoxColumn();
      this.Column8 = new DataGridViewTextBoxColumn();
      this.Column9 = new DataGridViewTextBoxColumn();
      this.Column10 = new DataGridViewTextBoxColumn();
      this.Column11 = new DataGridViewTextBoxColumn();
      this.Column12 = new DataGridViewTextBoxColumn();
      this.Column13 = new DataGridViewTextBoxColumn();
      this.Column14 = new DataGridViewTextBoxColumn();
      this.Column15 = new DataGridViewTextBoxColumn();
      this.Column16 = new DataGridViewTextBoxColumn();
      this.Column17 = new DataGridViewTextBoxColumn();
      this.Column18 = new DataGridViewTextBoxColumn();
      this.Column19 = new DataGridViewTextBoxColumn();
      this.Column20 = new DataGridViewTextBoxColumn();
      this.Column21 = new DataGridViewTextBoxColumn();
      this.Column22 = new DataGridViewTextBoxColumn();
      this.Column23 = new DataGridViewTextBoxColumn();
      this.Column24 = new DataGridViewTextBoxColumn();
      this.tabPage3 = new TabPage();
      this.numericUpDown70 = new NumericUpDown();
      this.label149 = new Label();
      this.groupBox4 = new GroupBox();
      this.numericUpDown9 = new NumericUpDown();
      this.numericUpDown10 = new NumericUpDown();
      this.label15 = new Label();
      this.label17 = new Label();
      this.comboBox5 = new ComboBox();
      this.label20 = new Label();
      this.groupBox6 = new GroupBox();
      this.numericUpDown11 = new NumericUpDown();
      this.numericUpDown12 = new NumericUpDown();
      this.label18 = new Label();
      this.label19 = new Label();
      this.comboBox4 = new ComboBox();
      this.label14 = new Label();
      this.tabPage4 = new TabPage();
      this.numericUpDown1 = new NumericUpDown();
      this.label3 = new Label();
      this.groupBox8 = new GroupBox();
      this.numericUpDown15 = new NumericUpDown();
      this.numericUpDown16 = new NumericUpDown();
      this.label27 = new Label();
      this.label28 = new Label();
      this.groupBox7 = new GroupBox();
      this.numericUpDown13 = new NumericUpDown();
      this.numericUpDown14 = new NumericUpDown();
      this.label23 = new Label();
      this.label24 = new Label();
      this.comboBox6 = new ComboBox();
      this.label25 = new Label();
      this.comboBox7 = new ComboBox();
      this.label26 = new Label();
      this.tabPage5 = new TabPage();
      this.label36 = new Label();
      this.label37 = new Label();
      this.numericUpDown20 = new NumericUpDown();
      this.numericUpDown21 = new NumericUpDown();
      this.label32 = new Label();
      this.label34 = new Label();
      this.numericUpDown8 = new NumericUpDown();
      this.numericUpDown17 = new NumericUpDown();
      this.label30 = new Label();
      this.label29 = new Label();
      this.numericUpDown3 = new NumericUpDown();
      this.numericUpDown6 = new NumericUpDown();
      this.numericUpDown2 = new NumericUpDown();
      this.label4 = new Label();
      this.comboBox8 = new ComboBox();
      this.label16 = new Label();
      this.comboBox9 = new ComboBox();
      this.label22 = new Label();
      this.tabPage6 = new TabPage();
      this.numericUpDown22 = new NumericUpDown();
      this.label40 = new Label();
      this.numericUpDown19 = new NumericUpDown();
      this.comboBox12 = new ComboBox();
      this.label39 = new Label();
      this.label38 = new Label();
      this.comboBox10 = new ComboBox();
      this.label35 = new Label();
      this.numericUpDown7 = new NumericUpDown();
      this.numericUpDown18 = new NumericUpDown();
      this.label31 = new Label();
      this.textBox9 = new TextBox();
      this.label33 = new Label();
      this.tabPage7 = new TabPage();
      this.comboBox21 = new ComboBox();
      this.label74 = new Label();
      this.numericUpDown48 = new NumericUpDown();
      this.label78 = new Label();
      this.tabPage8 = new TabPage();
      this.numericUpDown68 = new NumericUpDown();
      this.label147 = new Label();
      this.checkBox1 = new CheckBox();
      this.label92 = new Label();
      this.numericUpDown52 = new NumericUpDown();
      this.comboBox28 = new ComboBox();
      this.comboBox27 = new ComboBox();
      this.comboBox26 = new ComboBox();
      this.numericUpDown56 = new NumericUpDown();
      this.label86 = new Label();
      this.numericUpDown57 = new NumericUpDown();
      this.comboBox24 = new ComboBox();
      this.label87 = new Label();
      this.label88 = new Label();
      this.comboBox25 = new ComboBox();
      this.label89 = new Label();
      this.numericUpDown58 = new NumericUpDown();
      this.numericUpDown59 = new NumericUpDown();
      this.label90 = new Label();
      this.label91 = new Label();
      this.label80 = new Label();
      this.label81 = new Label();
      this.label82 = new Label();
      this.comboBox23 = new ComboBox();
      this.label83 = new Label();
      this.numericUpDown54 = new NumericUpDown();
      this.numericUpDown55 = new NumericUpDown();
      this.label84 = new Label();
      this.textBox10 = new TextBox();
      this.label85 = new Label();
      this.tabPage9 = new TabPage();
      this.numericUpDown69 = new NumericUpDown();
      this.label148 = new Label();
      this.comboBox22 = new ComboBox();
      this.comboBox29 = new ComboBox();
      this.comboBox32 = new ComboBox();
      this.comboBox34 = new ComboBox();
      this.textBox11 = new TextBox();
      this.comboBox33 = new ComboBox();
      this.label104 = new Label();
      this.label103 = new Label();
      this.numericUpDown53 = new NumericUpDown();
      this.comboBox30 = new ComboBox();
      this.label93 = new Label();
      this.label94 = new Label();
      this.comboBox31 = new ComboBox();
      this.label95 = new Label();
      this.numericUpDown60 = new NumericUpDown();
      this.numericUpDown61 = new NumericUpDown();
      this.label96 = new Label();
      this.label97 = new Label();
      this.label98 = new Label();
      this.label99 = new Label();
      this.label100 = new Label();
      this.numericUpDown62 = new NumericUpDown();
      this.numericUpDown63 = new NumericUpDown();
      this.label101 = new Label();
      this.label102 = new Label();
      this.tabPage10 = new TabPage();
      this.comboBox35 = new ComboBox();
      this.label105 = new Label();
      this.textBox12 = new TextBox();
      this.label41 = new Label();
      this.label42 = new Label();
      this.numericUpDown23 = new NumericUpDown();
      this.numericUpDown24 = new NumericUpDown();
      this.label43 = new Label();
      this.label44 = new Label();
      this.numericUpDown25 = new NumericUpDown();
      this.numericUpDown26 = new NumericUpDown();
      this.label45 = new Label();
      this.label46 = new Label();
      this.numericUpDown27 = new NumericUpDown();
      this.numericUpDown28 = new NumericUpDown();
      this.numericUpDown29 = new NumericUpDown();
      this.label47 = new Label();
      this.comboBox11 = new ComboBox();
      this.label48 = new Label();
      this.comboBox13 = new ComboBox();
      this.label49 = new Label();
      this.label50 = new Label();
      this.label51 = new Label();
      this.numericUpDown30 = new NumericUpDown();
      this.numericUpDown31 = new NumericUpDown();
      this.label52 = new Label();
      this.label53 = new Label();
      this.numericUpDown32 = new NumericUpDown();
      this.numericUpDown33 = new NumericUpDown();
      this.label54 = new Label();
      this.label55 = new Label();
      this.numericUpDown34 = new NumericUpDown();
      this.numericUpDown35 = new NumericUpDown();
      this.numericUpDown36 = new NumericUpDown();
      this.label56 = new Label();
      this.comboBox14 = new ComboBox();
      this.label57 = new Label();
      this.comboBox15 = new ComboBox();
      this.label59 = new Label();
      this.numericUpDown37 = new NumericUpDown();
      this.label60 = new Label();
      this.groupBox9 = new GroupBox();
      this.numericUpDown38 = new NumericUpDown();
      this.numericUpDown39 = new NumericUpDown();
      this.label61 = new Label();
      this.label62 = new Label();
      this.groupBox10 = new GroupBox();
      this.numericUpDown40 = new NumericUpDown();
      this.numericUpDown41 = new NumericUpDown();
      this.label63 = new Label();
      this.label64 = new Label();
      this.comboBox16 = new ComboBox();
      this.label65 = new Label();
      this.comboBox18 = new ComboBox();
      this.label66 = new Label();
      this.numericUpDown42 = new NumericUpDown();
      this.label67 = new Label();
      this.groupBox11 = new GroupBox();
      this.numericUpDown43 = new NumericUpDown();
      this.numericUpDown44 = new NumericUpDown();
      this.label68 = new Label();
      this.label69 = new Label();
      this.groupBox12 = new GroupBox();
      this.numericUpDown45 = new NumericUpDown();
      this.numericUpDown46 = new NumericUpDown();
      this.label70 = new Label();
      this.label71 = new Label();
      this.comboBox19 = new ComboBox();
      this.label72 = new Label();
      this.comboBox20 = new ComboBox();
      this.label73 = new Label();
      this.textBox13 = new TextBox();
      this.label110 = new Label();
      this.label111 = new Label();
      this.serialPort1 = new SerialPort(this.components);
      this.checkBox2 = new CheckBox();
      this.label75 = new Label();
      this.numericUpDown47 = new NumericUpDown();
      this.comboBox36 = new ComboBox();
      this.numericUpDown49 = new NumericUpDown();
      this.label76 = new Label();
      this.label77 = new Label();
      this.groupBox5.SuspendLayout();
      this.numericUpDown5.BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.numericUpDown4.BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.numericUpDown66.BeginInit();
      this.tabPage2.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.tabPage3.SuspendLayout();
      this.numericUpDown70.BeginInit();
      this.groupBox4.SuspendLayout();
      this.numericUpDown9.BeginInit();
      this.numericUpDown10.BeginInit();
      this.groupBox6.SuspendLayout();
      this.numericUpDown11.BeginInit();
      this.numericUpDown12.BeginInit();
      this.tabPage4.SuspendLayout();
      this.numericUpDown1.BeginInit();
      this.groupBox8.SuspendLayout();
      this.numericUpDown15.BeginInit();
      this.numericUpDown16.BeginInit();
      this.groupBox7.SuspendLayout();
      this.numericUpDown13.BeginInit();
      this.numericUpDown14.BeginInit();
      this.tabPage5.SuspendLayout();
      this.numericUpDown20.BeginInit();
      this.numericUpDown21.BeginInit();
      this.numericUpDown8.BeginInit();
      this.numericUpDown17.BeginInit();
      this.numericUpDown3.BeginInit();
      this.numericUpDown6.BeginInit();
      this.numericUpDown2.BeginInit();
      this.tabPage6.SuspendLayout();
      this.numericUpDown22.BeginInit();
      this.numericUpDown19.BeginInit();
      this.numericUpDown7.BeginInit();
      this.numericUpDown18.BeginInit();
      this.tabPage7.SuspendLayout();
      this.numericUpDown48.BeginInit();
      this.tabPage8.SuspendLayout();
      this.numericUpDown68.BeginInit();
      this.numericUpDown52.BeginInit();
      this.numericUpDown56.BeginInit();
      this.numericUpDown57.BeginInit();
      this.numericUpDown58.BeginInit();
      this.numericUpDown59.BeginInit();
      this.numericUpDown54.BeginInit();
      this.numericUpDown55.BeginInit();
      this.tabPage9.SuspendLayout();
      this.numericUpDown69.BeginInit();
      this.numericUpDown53.BeginInit();
      this.numericUpDown60.BeginInit();
      this.numericUpDown61.BeginInit();
      this.numericUpDown62.BeginInit();
      this.numericUpDown63.BeginInit();
      this.tabPage10.SuspendLayout();
      this.numericUpDown23.BeginInit();
      this.numericUpDown24.BeginInit();
      this.numericUpDown25.BeginInit();
      this.numericUpDown26.BeginInit();
      this.numericUpDown27.BeginInit();
      this.numericUpDown28.BeginInit();
      this.numericUpDown29.BeginInit();
      this.numericUpDown30.BeginInit();
      this.numericUpDown31.BeginInit();
      this.numericUpDown32.BeginInit();
      this.numericUpDown33.BeginInit();
      this.numericUpDown34.BeginInit();
      this.numericUpDown35.BeginInit();
      this.numericUpDown36.BeginInit();
      this.numericUpDown37.BeginInit();
      this.groupBox9.SuspendLayout();
      this.numericUpDown38.BeginInit();
      this.numericUpDown39.BeginInit();
      this.groupBox10.SuspendLayout();
      this.numericUpDown40.BeginInit();
      this.numericUpDown41.BeginInit();
      this.numericUpDown42.BeginInit();
      this.groupBox11.SuspendLayout();
      this.numericUpDown43.BeginInit();
      this.numericUpDown44.BeginInit();
      this.groupBox12.SuspendLayout();
      this.numericUpDown45.BeginInit();
      this.numericUpDown46.BeginInit();
      this.numericUpDown47.BeginInit();
      this.numericUpDown49.BeginInit();
      this.SuspendLayout();
      this.groupBox5.Controls.Add((Control) this.comboBox17);
      this.groupBox5.Controls.Add((Control) this.label58);
      this.groupBox5.Controls.Add((Control) this.numericUpDown5);
      this.groupBox5.Controls.Add((Control) this.label13);
      this.groupBox5.Controls.Add((Control) this.panel1);
      this.groupBox5.Controls.Add((Control) this.panel2);
      this.groupBox5.Location = new Point(12, 12);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(702, 65);
      this.groupBox5.TabIndex = 67;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "通 讯";
      this.groupBox5.Enter += new EventHandler(this.groupBox5_Enter);
      this.comboBox17.FormattingEnabled = true;
      this.comboBox17.Items.AddRange(new object[3]
      {
        (object) "串口",
        (object) "UDP",
        (object) "TCP"
      });
      this.comboBox17.Location = new Point(225, 25);
      this.comboBox17.Name = "comboBox17";
      this.comboBox17.Size = new Size(65, 20);
      this.comboBox17.TabIndex = 92;
      this.comboBox17.Text = "串口";
      this.comboBox17.SelectedIndexChanged += new EventHandler(this.comboBox17_SelectedIndexChanged);
      this.label58.AutoSize = true;
      this.label58.Location = new Point(164, 29);
      this.label58.Name = "label58";
      this.label58.Size = new Size(53, 12);
      this.label58.TabIndex = 91;
      this.label58.Text = "通讯方式";
      this.numericUpDown5.Location = new Point(80, 25);
      this.numericUpDown5.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown5.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown5.Name = "numericUpDown5";
      this.numericUpDown5.Size = new Size(51, 21);
      this.numericUpDown5.TabIndex = 85;
      this.numericUpDown5.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown5.ValueChanged += new EventHandler(this.numericUpDown5_ValueChanged);
      this.label13.AutoSize = true;
      this.label13.Location = new Point(19, 29);
      this.label13.Name = "label13";
      this.label13.Size = new Size(53, 12);
      this.label13.TabIndex = 80;
      this.label13.Text = "设备编号";
      this.panel1.Controls.Add((Control) this.button7);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.comboBox2);
      this.panel1.Controls.Add((Control) this.comboBox1);
      this.panel1.Location = new Point(313, 19);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(380, 40);
      this.panel1.TabIndex = (int) sbyte.MaxValue;
      this.button7.Location = new Point(305, 4);
      this.button7.Name = "button7";
      this.button7.Size = new Size(66, 25);
      this.button7.TabIndex = 122;
      this.button7.Text = "打开";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(148, 10);
      this.label7.Name = "label7";
      this.label7.Size = new Size(41, 12);
      this.label7.TabIndex = 121;
      this.label7.Text = "波特率";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(15, 11);
      this.label6.Name = "label6";
      this.label6.Size = new Size(41, 12);
      this.label6.TabIndex = 121;
      this.label6.Text = "串口号";
      this.label6.Click += new EventHandler(this.label6_Click);
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(62, 7);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(61, 20);
      this.comboBox2.TabIndex = 94;
      this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[3]
      {
        (object) "9600Bps",
        (object) "38400Bps",
        (object) "115200Bps"
      });
      this.comboBox1.Location = new Point(195, 6);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(81, 20);
      this.comboBox1.TabIndex = 93;
      this.comboBox1.Text = "9600Bps";
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.panel2.Controls.Add((Control) this.textBox8);
      this.panel2.Controls.Add((Control) this.textBox16);
      this.panel2.Controls.Add((Control) this.textBox17);
      this.panel2.Controls.Add((Control) this.textBox18);
      this.panel2.Controls.Add((Control) this.label146);
      this.panel2.Controls.Add((Control) this.button8);
      this.panel2.Controls.Add((Control) this.label5);
      this.panel2.Controls.Add((Control) this.textBox1);
      this.panel2.Controls.Add((Control) this.label12);
      this.panel2.Controls.Add((Control) this.label21);
      this.panel2.Location = new Point(310, 18);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(383, 41);
      this.panel2.TabIndex = 128;
      this.textBox8.Location = new Point(58, 9);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(24, 21);
      this.textBox8.TabIndex = (int) sbyte.MaxValue;
      this.textBox8.Text = "192";
      this.textBox8.TextChanged += new EventHandler(this.textBox8_TextChanged_1);
      this.textBox16.Location = new Point(87, 9);
      this.textBox16.Name = "textBox16";
      this.textBox16.Size = new Size(24, 21);
      this.textBox16.TabIndex = 124;
      this.textBox16.Text = "168";
      this.textBox16.TextChanged += new EventHandler(this.textBox16_TextChanged);
      this.textBox17.Location = new Point(147, 9);
      this.textBox17.Name = "textBox17";
      this.textBox17.Size = new Size(24, 21);
      this.textBox17.TabIndex = 126;
      this.textBox17.Text = "168";
      this.textBox17.TextChanged += new EventHandler(this.textBox17_TextChanged);
      this.textBox18.Location = new Point(117, 9);
      this.textBox18.Name = "textBox18";
      this.textBox18.Size = new Size(24, 21);
      this.textBox18.TabIndex = 125;
      this.textBox18.Text = "1";
      this.textBox18.TextChanged += new EventHandler(this.textBox18_TextChanged);
      this.label146.AutoSize = true;
      this.label146.Location = new Point(80, 12);
      this.label146.Name = "label146";
      this.label146.Size = new Size(71, 12);
      this.label146.TabIndex = 128;
      this.label146.Text = ".    .    .";
      this.button8.Location = new Point(308, 6);
      this.button8.Name = "button8";
      this.button8.Size = new Size(66, 25);
      this.button8.TabIndex = 123;
      this.button8.Text = "连接";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.label5.AutoSize = true;
      this.label5.Location = new Point(199, 12);
      this.label5.Name = "label5";
      this.label5.Size = new Size(29, 12);
      this.label5.TabIndex = 120;
      this.label5.Text = "端口";
      this.textBox1.Location = new Point(235, 8);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(35, 21);
      this.textBox1.TabIndex = 119;
      this.textBox1.Text = "3000";
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.label12.AutoSize = true;
      this.label12.Location = new Point(63, 15);
      this.label12.Name = "label12";
      this.label12.Size = new Size(11, 12);
      this.label12.TabIndex = 81;
      this.label12.Text = ".";
      this.label12.Click += new EventHandler(this.label12_Click);
      this.label21.AutoSize = true;
      this.label21.Location = new Point(11, 12);
      this.label21.Name = "label21";
      this.label21.Size = new Size(41, 12);
      this.label21.TabIndex = 84;
      this.label21.Text = "IP地址";
      this.checkBox21.AutoSize = true;
      this.checkBox21.Location = new Point(18, 19);
      this.checkBox21.Name = "checkBox21";
      this.checkBox21.Size = new Size(72, 16);
      this.checkBox21.TabIndex = 100;
      this.checkBox21.Text = "定时亮度";
      this.checkBox21.UseVisualStyleBackColor = true;
      this.checkBox21.CheckedChanged += new EventHandler(this.checkBox21_CheckedChanged);
      this.numericUpDown4.Location = new Point(211, 16);
      this.numericUpDown4.Maximum = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown4.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new Size(51, 21);
      this.numericUpDown4.TabIndex = 123;
      this.numericUpDown4.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label2.AutoSize = true;
      this.label2.Location = new Point(138, 20);
      this.label2.Name = "label2";
      this.label2.Size = new Size(65, 12);
      this.label2.TabIndex = 120;
      this.label2.Text = "实时亮度值";
      this.textBox2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.textBox2.Location = new Point(17, 37);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = ScrollBars.Vertical;
      this.textBox2.Size = new Size(583, 66);
      this.textBox2.TabIndex = (int) sbyte.MaxValue;
      this.groupBox1.Controls.Add((Control) this.label127);
      this.groupBox1.Controls.Add((Control) this.label128);
      this.groupBox1.Controls.Add((Control) this.label129);
      this.groupBox1.Controls.Add((Control) this.label130);
      this.groupBox1.Controls.Add((Control) this.label131);
      this.groupBox1.Controls.Add((Control) this.label132);
      this.groupBox1.Controls.Add((Control) this.label123);
      this.groupBox1.Controls.Add((Control) this.label122);
      this.groupBox1.Controls.Add((Control) this.label121);
      this.groupBox1.Controls.Add((Control) this.label120);
      this.groupBox1.Controls.Add((Control) this.label119);
      this.groupBox1.Controls.Add((Control) this.label118);
      this.groupBox1.Controls.Add((Control) this.label117);
      this.groupBox1.Controls.Add((Control) this.label116);
      this.groupBox1.Controls.Add((Control) this.label115);
      this.groupBox1.Controls.Add((Control) this.label114);
      this.groupBox1.Controls.Add((Control) this.button1);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.textBox3);
      this.groupBox1.Controls.Add((Control) this.textBox2);
      this.groupBox1.Location = new Point(12, 292);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(702, 118);
      this.groupBox1.TabIndex = 128;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "发 送";
      this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
      this.label127.BorderStyle = BorderStyle.FixedSingle;
      this.label127.Location = new Point(543, 24);
      this.label127.Name = "label127";
      this.label127.Size = new Size(36, 14);
      this.label127.TabIndex = 146;
      this.label127.Text = "15";
      this.label127.TextAlign = ContentAlignment.TopCenter;
      this.label127.Click += new EventHandler(this.label127_Click);
      this.label128.BorderStyle = BorderStyle.FixedSingle;
      this.label128.Location = new Point(508, 24);
      this.label128.Name = "label128";
      this.label128.Size = new Size(36, 14);
      this.label128.TabIndex = 145;
      this.label128.Text = "14";
      this.label128.TextAlign = ContentAlignment.TopCenter;
      this.label128.Click += new EventHandler(this.label128_Click);
      this.label129.BorderStyle = BorderStyle.FixedSingle;
      this.label129.Location = new Point(473, 24);
      this.label129.Name = "label129";
      this.label129.Size = new Size(36, 14);
      this.label129.TabIndex = 144;
      this.label129.Text = "13";
      this.label129.TextAlign = ContentAlignment.TopCenter;
      this.label129.Click += new EventHandler(this.label129_Click);
      this.label130.BorderStyle = BorderStyle.FixedSingle;
      this.label130.Location = new Point(438, 24);
      this.label130.Name = "label130";
      this.label130.Size = new Size(36, 14);
      this.label130.TabIndex = 143;
      this.label130.Text = "12";
      this.label130.TextAlign = ContentAlignment.TopCenter;
      this.label130.Click += new EventHandler(this.label130_Click);
      this.label131.BorderStyle = BorderStyle.FixedSingle;
      this.label131.Location = new Point(403, 24);
      this.label131.Name = "label131";
      this.label131.Size = new Size(36, 14);
      this.label131.TabIndex = 142;
      this.label131.Text = "11";
      this.label131.TextAlign = ContentAlignment.TopCenter;
      this.label131.Click += new EventHandler(this.label131_Click);
      this.label132.BorderStyle = BorderStyle.FixedSingle;
      this.label132.Location = new Point(368, 24);
      this.label132.Name = "label132";
      this.label132.Size = new Size(36, 14);
      this.label132.TabIndex = 141;
      this.label132.Text = "10";
      this.label132.TextAlign = ContentAlignment.TopCenter;
      this.label132.Click += new EventHandler(this.label132_Click);
      this.label123.BorderStyle = BorderStyle.FixedSingle;
      this.label123.Location = new Point(333, 24);
      this.label123.Name = "label123";
      this.label123.Size = new Size(36, 14);
      this.label123.TabIndex = 140;
      this.label123.Text = "9";
      this.label123.TextAlign = ContentAlignment.TopCenter;
      this.label123.Click += new EventHandler(this.label123_Click);
      this.label122.BorderStyle = BorderStyle.FixedSingle;
      this.label122.Location = new Point(298, 24);
      this.label122.Name = "label122";
      this.label122.Size = new Size(36, 14);
      this.label122.TabIndex = 139;
      this.label122.Text = "8";
      this.label122.TextAlign = ContentAlignment.TopCenter;
      this.label122.Click += new EventHandler(this.label122_Click);
      this.label121.BorderStyle = BorderStyle.FixedSingle;
      this.label121.Location = new Point(263, 24);
      this.label121.Name = "label121";
      this.label121.Size = new Size(36, 14);
      this.label121.TabIndex = 138;
      this.label121.Text = "7";
      this.label121.TextAlign = ContentAlignment.TopCenter;
      this.label121.Click += new EventHandler(this.label121_Click);
      this.label120.BorderStyle = BorderStyle.FixedSingle;
      this.label120.Location = new Point(228, 24);
      this.label120.Name = "label120";
      this.label120.Size = new Size(36, 14);
      this.label120.TabIndex = 137;
      this.label120.Text = "6";
      this.label120.TextAlign = ContentAlignment.TopCenter;
      this.label120.Click += new EventHandler(this.label120_Click);
      this.label119.BorderStyle = BorderStyle.FixedSingle;
      this.label119.Location = new Point(193, 24);
      this.label119.Name = "label119";
      this.label119.Size = new Size(36, 14);
      this.label119.TabIndex = 136;
      this.label119.Text = "5";
      this.label119.TextAlign = ContentAlignment.TopCenter;
      this.label119.Click += new EventHandler(this.label119_Click);
      this.label118.BorderStyle = BorderStyle.FixedSingle;
      this.label118.Location = new Point(158, 24);
      this.label118.Name = "label118";
      this.label118.Size = new Size(36, 14);
      this.label118.TabIndex = 135;
      this.label118.Text = "4";
      this.label118.TextAlign = ContentAlignment.TopCenter;
      this.label118.Click += new EventHandler(this.label118_Click);
      this.label117.BorderStyle = BorderStyle.FixedSingle;
      this.label117.Location = new Point(123, 24);
      this.label117.Name = "label117";
      this.label117.Size = new Size(36, 14);
      this.label117.TabIndex = 134;
      this.label117.Text = "3";
      this.label117.TextAlign = ContentAlignment.MiddleCenter;
      this.label117.Click += new EventHandler(this.label117_Click);
      this.label116.BorderStyle = BorderStyle.FixedSingle;
      this.label116.Location = new Point(88, 24);
      this.label116.Name = "label116";
      this.label116.Size = new Size(36, 14);
      this.label116.TabIndex = 133;
      this.label116.Text = "2";
      this.label116.TextAlign = ContentAlignment.MiddleCenter;
      this.label116.Click += new EventHandler(this.label116_Click);
      this.label115.BorderStyle = BorderStyle.FixedSingle;
      this.label115.Location = new Point(53, 24);
      this.label115.Name = "label115";
      this.label115.Size = new Size(36, 14);
      this.label115.TabIndex = 132;
      this.label115.Text = "1";
      this.label115.TextAlign = ContentAlignment.MiddleCenter;
      this.label115.Click += new EventHandler(this.label115_Click);
      this.label114.BorderStyle = BorderStyle.FixedSingle;
      this.label114.Location = new Point(18, 24);
      this.label114.Name = "label114";
      this.label114.Size = new Size(36, 14);
      this.label114.TabIndex = 131;
      this.label114.Text = "0";
      this.label114.TextAlign = ContentAlignment.MiddleCenter;
      this.label114.Click += new EventHandler(this.label114_Click);
      this.button1.Location = new Point(618, 76);
      this.button1.Name = "button1";
      this.button1.Size = new Size(66, 23);
      this.button1.TabIndex = 130;
      this.button1.Text = "清 空";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label8.AutoSize = true;
      this.label8.Location = new Point(619, 53);
      this.label8.Name = "label8";
      this.label8.Size = new Size(29, 12);
      this.label8.TabIndex = 129;
      this.label8.Text = "计数";
      this.textBox3.Location = new Point(654, 49);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(27, 21);
      this.textBox3.TabIndex = 129;
      this.textBox3.Text = "0";
      this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.groupBox2.Controls.Add((Control) this.label124);
      this.groupBox2.Controls.Add((Control) this.label125);
      this.groupBox2.Controls.Add((Control) this.label126);
      this.groupBox2.Controls.Add((Control) this.label133);
      this.groupBox2.Controls.Add((Control) this.label134);
      this.groupBox2.Controls.Add((Control) this.label135);
      this.groupBox2.Controls.Add((Control) this.label136);
      this.groupBox2.Controls.Add((Control) this.label137);
      this.groupBox2.Controls.Add((Control) this.label138);
      this.groupBox2.Controls.Add((Control) this.label139);
      this.groupBox2.Controls.Add((Control) this.label140);
      this.groupBox2.Controls.Add((Control) this.label141);
      this.groupBox2.Controls.Add((Control) this.label142);
      this.groupBox2.Controls.Add((Control) this.label143);
      this.groupBox2.Controls.Add((Control) this.label144);
      this.groupBox2.Controls.Add((Control) this.label145);
      this.groupBox2.Controls.Add((Control) this.button2);
      this.groupBox2.Controls.Add((Control) this.label9);
      this.groupBox2.Controls.Add((Control) this.textBox4);
      this.groupBox2.Controls.Add((Control) this.textBox5);
      this.groupBox2.Location = new Point(12, 416);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(702, 81);
      this.groupBox2.TabIndex = 129;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "接 收";
      this.label124.BorderStyle = BorderStyle.FixedSingle;
      this.label124.Location = new Point(543, 25);
      this.label124.Name = "label124";
      this.label124.Size = new Size(36, 14);
      this.label124.TabIndex = 162;
      this.label124.Text = "15";
      this.label124.TextAlign = ContentAlignment.TopCenter;
      this.label125.BorderStyle = BorderStyle.FixedSingle;
      this.label125.Location = new Point(508, 25);
      this.label125.Name = "label125";
      this.label125.Size = new Size(36, 14);
      this.label125.TabIndex = 161;
      this.label125.Text = "14";
      this.label125.TextAlign = ContentAlignment.TopCenter;
      this.label126.BorderStyle = BorderStyle.FixedSingle;
      this.label126.Location = new Point(473, 25);
      this.label126.Name = "label126";
      this.label126.Size = new Size(36, 14);
      this.label126.TabIndex = 160;
      this.label126.Text = "13";
      this.label126.TextAlign = ContentAlignment.TopCenter;
      this.label133.BorderStyle = BorderStyle.FixedSingle;
      this.label133.Location = new Point(438, 25);
      this.label133.Name = "label133";
      this.label133.Size = new Size(36, 14);
      this.label133.TabIndex = 159;
      this.label133.Text = "12";
      this.label133.TextAlign = ContentAlignment.TopCenter;
      this.label134.BorderStyle = BorderStyle.FixedSingle;
      this.label134.Location = new Point(403, 25);
      this.label134.Name = "label134";
      this.label134.Size = new Size(36, 14);
      this.label134.TabIndex = 158;
      this.label134.Text = "11";
      this.label134.TextAlign = ContentAlignment.TopCenter;
      this.label135.BorderStyle = BorderStyle.FixedSingle;
      this.label135.Location = new Point(368, 25);
      this.label135.Name = "label135";
      this.label135.Size = new Size(36, 14);
      this.label135.TabIndex = 157;
      this.label135.Text = "10";
      this.label135.TextAlign = ContentAlignment.TopCenter;
      this.label136.BorderStyle = BorderStyle.FixedSingle;
      this.label136.Location = new Point(333, 25);
      this.label136.Name = "label136";
      this.label136.Size = new Size(36, 14);
      this.label136.TabIndex = 156;
      this.label136.Text = "9";
      this.label136.TextAlign = ContentAlignment.TopCenter;
      this.label137.BorderStyle = BorderStyle.FixedSingle;
      this.label137.Location = new Point(298, 25);
      this.label137.Name = "label137";
      this.label137.Size = new Size(36, 14);
      this.label137.TabIndex = 155;
      this.label137.Text = "8";
      this.label137.TextAlign = ContentAlignment.TopCenter;
      this.label138.BorderStyle = BorderStyle.FixedSingle;
      this.label138.Location = new Point(263, 25);
      this.label138.Name = "label138";
      this.label138.Size = new Size(36, 14);
      this.label138.TabIndex = 154;
      this.label138.Text = "7";
      this.label138.TextAlign = ContentAlignment.TopCenter;
      this.label139.BorderStyle = BorderStyle.FixedSingle;
      this.label139.Location = new Point(228, 25);
      this.label139.Name = "label139";
      this.label139.Size = new Size(36, 14);
      this.label139.TabIndex = 153;
      this.label139.Text = "6";
      this.label139.TextAlign = ContentAlignment.TopCenter;
      this.label140.BorderStyle = BorderStyle.FixedSingle;
      this.label140.Location = new Point(193, 25);
      this.label140.Name = "label140";
      this.label140.Size = new Size(36, 14);
      this.label140.TabIndex = 152;
      this.label140.Text = "5";
      this.label140.TextAlign = ContentAlignment.TopCenter;
      this.label141.BorderStyle = BorderStyle.FixedSingle;
      this.label141.Location = new Point(158, 25);
      this.label141.Name = "label141";
      this.label141.Size = new Size(36, 14);
      this.label141.TabIndex = 151;
      this.label141.Text = "4";
      this.label141.TextAlign = ContentAlignment.TopCenter;
      this.label142.BorderStyle = BorderStyle.FixedSingle;
      this.label142.Location = new Point(123, 25);
      this.label142.Name = "label142";
      this.label142.Size = new Size(36, 14);
      this.label142.TabIndex = 150;
      this.label142.Text = "3";
      this.label142.TextAlign = ContentAlignment.MiddleCenter;
      this.label143.BorderStyle = BorderStyle.FixedSingle;
      this.label143.Location = new Point(88, 25);
      this.label143.Name = "label143";
      this.label143.Size = new Size(36, 14);
      this.label143.TabIndex = 149;
      this.label143.Text = "2";
      this.label143.TextAlign = ContentAlignment.MiddleCenter;
      this.label144.BorderStyle = BorderStyle.FixedSingle;
      this.label144.Location = new Point(53, 25);
      this.label144.Name = "label144";
      this.label144.Size = new Size(36, 14);
      this.label144.TabIndex = 148;
      this.label144.Text = "1";
      this.label144.TextAlign = ContentAlignment.MiddleCenter;
      this.label145.BorderStyle = BorderStyle.FixedSingle;
      this.label145.Location = new Point(18, 25);
      this.label145.Name = "label145";
      this.label145.Size = new Size(36, 14);
      this.label145.TabIndex = 147;
      this.label145.Text = "0";
      this.label145.TextAlign = ContentAlignment.MiddleCenter;
      this.button2.Location = new Point(618, 47);
      this.button2.Name = "button2";
      this.button2.Size = new Size(66, 23);
      this.button2.TabIndex = 130;
      this.button2.Text = "清 空";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(619, 26);
      this.label9.Name = "label9";
      this.label9.Size = new Size(29, 12);
      this.label9.TabIndex = 129;
      this.label9.Text = "计数";
      this.textBox4.Location = new Point(654, 22);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(27, 21);
      this.textBox4.TabIndex = 129;
      this.textBox4.Text = "0";
      this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
      this.textBox5.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.textBox5.Location = new Point(17, 38);
      this.textBox5.Multiline = true;
      this.textBox5.Name = "textBox5";
      this.textBox5.ScrollBars = ScrollBars.Vertical;
      this.textBox5.Size = new Size(583, 32);
      this.textBox5.TabIndex = (int) sbyte.MaxValue;
      this.groupBox3.Controls.Add((Control) this.button6);
      this.groupBox3.Controls.Add((Control) this.button4);
      this.groupBox3.Controls.Add((Control) this.button3);
      this.groupBox3.Controls.Add((Control) this.button5);
      this.groupBox3.Controls.Add((Control) this.tabControl1);
      this.groupBox3.Location = new Point(12, 87);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(702, 191);
      this.groupBox3.TabIndex = 132;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "操 作";
      this.groupBox3.Enter += new EventHandler(this.groupBox3_Enter);
      this.button6.Location = new Point(618, 147);
      this.button6.Name = "button6";
      this.button6.Size = new Size(66, 27);
      this.button6.TabIndex = 137;
      this.button6.Text = "查 询";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button4.Location = new Point(618, 112);
      this.button4.Name = "button4";
      this.button4.Size = new Size(66, 27);
      this.button4.TabIndex = 136;
      this.button4.Text = "发 送";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click_1);
      this.button3.Location = new Point(618, 77);
      this.button3.Name = "button3";
      this.button3.Size = new Size(66, 27);
      this.button3.TabIndex = 135;
      this.button3.Text = "生 成";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button5.Location = new Point(618, 42);
      this.button5.Name = "button5";
      this.button5.Size = new Size(66, 27);
      this.button5.TabIndex = 134;
      this.button5.Text = "默 认";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Controls.Add((Control) this.tabPage5);
      this.tabControl1.Controls.Add((Control) this.tabPage6);
      this.tabControl1.Controls.Add((Control) this.tabPage7);
      this.tabControl1.Controls.Add((Control) this.tabPage8);
      this.tabControl1.Controls.Add((Control) this.tabPage9);
      this.tabControl1.Controls.Add((Control) this.tabPage10);
      this.tabControl1.ItemSize = new Size(60, 18);
      this.tabControl1.Location = new Point(12, 20);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(588, 160);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabPage1.Controls.Add((Control) this.textBox19);
      this.tabPage1.Controls.Add((Control) this.textBox14);
      this.tabPage1.Controls.Add((Control) this.textBox15);
      this.tabPage1.Controls.Add((Control) this.textBox7);
      this.tabPage1.Controls.Add((Control) this.textBox6);
      this.tabPage1.Controls.Add((Control) this.label11);
      this.tabPage1.Controls.Add((Control) this.comboBox3);
      this.tabPage1.Controls.Add((Control) this.label10);
      this.tabPage1.Controls.Add((Control) this.label1);
      this.tabPage1.Controls.Add((Control) this.label113);
      this.tabPage1.Controls.Add((Control) this.label79);
      this.tabPage1.Controls.Add((Control) this.panel3);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(580, 134);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "杂项控制";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.textBox19.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.textBox19.Location = new Point(6, 88);
      this.textBox19.Multiline = true;
      this.textBox19.Name = "textBox19";
      this.textBox19.Size = new Size(570, 40);
      this.textBox19.TabIndex = 140;
      this.textBox19.Visible = false;
      this.textBox14.Location = new Point(249, 60);
      this.textBox14.Name = "textBox14";
      this.textBox14.Size = new Size(18, 21);
      this.textBox14.TabIndex = 138;
      this.textBox14.Text = "00";
      this.textBox14.Visible = false;
      this.textBox15.Location = new Point(214, 60);
      this.textBox15.Name = "textBox15";
      this.textBox15.Size = new Size(18, 21);
      this.textBox15.TabIndex = 137;
      this.textBox15.Text = "09";
      this.textBox15.Visible = false;
      this.textBox7.Location = new Point(115, 60);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(18, 21);
      this.textBox7.TabIndex = 135;
      this.textBox7.Text = "00";
      this.textBox7.Visible = false;
      this.textBox6.Location = new Point(80, 60);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(18, 21);
      this.textBox6.TabIndex = 132;
      this.textBox6.Text = "08";
      this.textBox6.Visible = false;
      this.textBox6.TextChanged += new EventHandler(this.textBox6_TextChanged);
      this.label11.AutoSize = true;
      this.label11.Location = new Point(27, 76);
      this.label11.Name = "label11";
      this.label11.Size = new Size(0, 12);
      this.label11.TabIndex = 131;
      this.label11.Visible = false;
      this.label11.Click += new EventHandler(this.label11_Click);
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Items.AddRange(new object[7]
      {
        (object) "校准时间",
        (object) "手动开屏",
        (object) "手动关屏",
        (object) "定时开关",
        (object) "播放控制",
        (object) "恢复出厂设置",
        (object) "原值发送"
      });
      this.comboBox3.Location = new Point(29, 19);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(125, 20);
      this.comboBox3.TabIndex = 130;
      this.comboBox3.Text = "校准时间";
      this.comboBox3.SelectedIndexChanged += new EventHandler(this.comboBox3_SelectedIndexChanged);
      this.label10.AutoSize = true;
      this.label10.Location = new Point(27, 22);
      this.label10.Name = "label10";
      this.label10.Size = new Size(0, 12);
      this.label10.TabIndex = 129;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(155, 64);
      this.label1.Name = "label1";
      this.label1.Size = new Size(0, 12);
      this.label1.TabIndex = 119;
      this.label1.Visible = false;
      this.label113.AutoSize = true;
      this.label113.Location = new Point(161, 63);
      this.label113.Name = "label113";
      this.label113.Size = new Size(89, 12);
      this.label113.TabIndex = 139;
      this.label113.Text = "关屏时间    ：";
      this.label113.Visible = false;
      this.label79.AutoSize = true;
      this.label79.Location = new Point(27, 63);
      this.label79.Name = "label79";
      this.label79.Size = new Size(89, 12);
      this.label79.TabIndex = 136;
      this.label79.Text = "开屏时间    ：";
      this.label79.Visible = false;
      this.panel3.Controls.Add((Control) this.numericUpDown66);
      this.panel3.Controls.Add((Control) this.label112);
      this.panel3.Controls.Add((Control) this.radioButton3);
      this.panel3.Controls.Add((Control) this.radioButton2);
      this.panel3.Controls.Add((Control) this.radioButton1);
      this.panel3.Location = new Point(177, 9);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(406, 82);
      this.panel3.TabIndex = 134;
      this.panel3.Visible = false;
      this.numericUpDown66.Location = new Point(318, 12);
      this.numericUpDown66.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown66.Name = "numericUpDown66";
      this.numericUpDown66.Size = new Size(51, 21);
      this.numericUpDown66.TabIndex = 124;
      this.label112.AutoSize = true;
      this.label112.Location = new Point(262, 16);
      this.label112.Name = "label112";
      this.label112.Size = new Size(53, 12);
      this.label112.TabIndex = 4;
      this.label112.Text = "节目编号";
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new Point(14, 57);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new Size(203, 16);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.Text = "同时播放通用节目和二次开发节目";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new Point(14, 34);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(119, 16);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.Text = "播放二次开发节目";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Location = new Point(14, 11);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(95, 16);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "播放通用节目";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged_1);
      this.tabPage2.Controls.Add((Control) this.dataGridView1);
      this.tabPage2.Controls.Add((Control) this.label2);
      this.tabPage2.Controls.Add((Control) this.checkBox21);
      this.tabPage2.Controls.Add((Control) this.numericUpDown4);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(580, 134);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "亮度控制";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column10, (DataGridViewColumn) this.Column11, (DataGridViewColumn) this.Column12, (DataGridViewColumn) this.Column13, (DataGridViewColumn) this.Column14, (DataGridViewColumn) this.Column15, (DataGridViewColumn) this.Column16, (DataGridViewColumn) this.Column17, (DataGridViewColumn) this.Column18, (DataGridViewColumn) this.Column19, (DataGridViewColumn) this.Column20, (DataGridViewColumn) this.Column21, (DataGridViewColumn) this.Column22, (DataGridViewColumn) this.Column23, (DataGridViewColumn) this.Column24);
      this.dataGridView1.Location = new Point(18, 55);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new Size(554, 63);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.Visible = false;
      this.Column1.HeaderText = "0:00";
      this.Column1.Name = "Column1";
      this.Column1.Width = 36;
      this.Column2.HeaderText = "1:00";
      this.Column2.Name = "Column2";
      this.Column2.Width = 36;
      this.Column3.HeaderText = "2:00";
      this.Column3.Name = "Column3";
      this.Column3.Width = 36;
      this.Column4.HeaderText = "3:00";
      this.Column4.Name = "Column4";
      this.Column4.Width = 36;
      this.Column5.HeaderText = "4:00";
      this.Column5.Name = "Column5";
      this.Column5.Width = 36;
      this.Column6.HeaderText = "5:00";
      this.Column6.Name = "Column6";
      this.Column6.Width = 36;
      this.Column7.HeaderText = "6:00";
      this.Column7.Name = "Column7";
      this.Column7.Width = 36;
      this.Column8.HeaderText = "7:00";
      this.Column8.Name = "Column8";
      this.Column8.Width = 36;
      this.Column9.HeaderText = "8:00";
      this.Column9.Name = "Column9";
      this.Column9.Width = 36;
      this.Column10.HeaderText = "9:00";
      this.Column10.Name = "Column10";
      this.Column10.Width = 36;
      this.Column11.HeaderText = "10:00";
      this.Column11.Name = "Column11";
      this.Column11.Width = 40;
      this.Column12.HeaderText = "11:00";
      this.Column12.Name = "Column12";
      this.Column12.Width = 40;
      this.Column13.HeaderText = "12:00";
      this.Column13.Name = "Column13";
      this.Column13.Width = 40;
      this.Column14.HeaderText = "13:00";
      this.Column14.Name = "Column14";
      this.Column14.Width = 40;
      this.Column15.HeaderText = "14:00";
      this.Column15.Name = "Column15";
      this.Column15.Width = 40;
      this.Column16.HeaderText = "15:00";
      this.Column16.Name = "Column16";
      this.Column16.Width = 40;
      this.Column17.HeaderText = "16:00";
      this.Column17.Name = "Column17";
      this.Column17.Width = 40;
      this.Column18.HeaderText = "17:00";
      this.Column18.Name = "Column18";
      this.Column18.Width = 40;
      this.Column19.HeaderText = "18:00";
      this.Column19.Name = "Column19";
      this.Column19.Width = 40;
      this.Column20.HeaderText = "19:00";
      this.Column20.Name = "Column20";
      this.Column20.Width = 40;
      this.Column21.HeaderText = "20:00";
      this.Column21.Name = "Column21";
      this.Column21.Width = 40;
      this.Column22.HeaderText = "21:00";
      this.Column22.Name = "Column22";
      this.Column22.Width = 40;
      this.Column23.HeaderText = "22:00";
      this.Column23.Name = "Column23";
      this.Column23.Width = 40;
      this.Column24.HeaderText = "23:00";
      this.Column24.Name = "Column24";
      this.Column24.Width = 40;
      this.tabPage3.Controls.Add((Control) this.numericUpDown70);
      this.tabPage3.Controls.Add((Control) this.label149);
      this.tabPage3.Controls.Add((Control) this.groupBox4);
      this.tabPage3.Controls.Add((Control) this.comboBox5);
      this.tabPage3.Controls.Add((Control) this.label20);
      this.tabPage3.Controls.Add((Control) this.groupBox6);
      this.tabPage3.Controls.Add((Control) this.comboBox4);
      this.tabPage3.Controls.Add((Control) this.label14);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(580, 134);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "杂项显示";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.numericUpDown70.Location = new Point(238, 18);
      this.numericUpDown70.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown70.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown70.Name = "numericUpDown70";
      this.numericUpDown70.Size = new Size(51, 21);
      this.numericUpDown70.TabIndex = 140;
      this.numericUpDown70.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown70.Visible = false;
      this.label149.AutoSize = true;
      this.label149.Location = new Point(190, 22);
      this.label149.Name = "label149";
      this.label149.Size = new Size(41, 12);
      this.label149.TabIndex = 139;
      this.label149.Text = "窗口号";
      this.label149.Visible = false;
      this.groupBox4.Controls.Add((Control) this.numericUpDown9);
      this.groupBox4.Controls.Add((Control) this.numericUpDown10);
      this.groupBox4.Controls.Add((Control) this.label15);
      this.groupBox4.Controls.Add((Control) this.label17);
      this.groupBox4.Location = new Point(180, 59);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(185, 58);
      this.groupBox4.TabIndex = 137;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "起始坐标";
      this.groupBox4.Visible = false;
      this.numericUpDown9.Location = new Point(114, 24);
      this.numericUpDown9.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown9.Name = "numericUpDown9";
      this.numericUpDown9.Size = new Size(51, 21);
      this.numericUpDown9.TabIndex = 135;
      this.numericUpDown9.Value = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numericUpDown10.Location = new Point(29, 24);
      this.numericUpDown10.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown10.Name = "numericUpDown10";
      this.numericUpDown10.Size = new Size(51, 21);
      this.numericUpDown10.TabIndex = 134;
      this.numericUpDown10.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label15.AutoSize = true;
      this.label15.Location = new Point(98, 28);
      this.label15.Name = "label15";
      this.label15.Size = new Size(11, 12);
      this.label15.TabIndex = 133;
      this.label15.Text = "Y";
      this.label17.AutoSize = true;
      this.label17.Location = new Point(12, 28);
      this.label17.Name = "label17";
      this.label17.Size = new Size(11, 12);
      this.label17.TabIndex = 132;
      this.label17.Text = "X";
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox5.Location = new Point(76, 71);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new Size(86, 20);
      this.comboBox5.TabIndex = 138;
      this.comboBox5.Text = "黑色";
      this.comboBox5.Visible = false;
      this.comboBox5.SelectedIndexChanged += new EventHandler(this.comboBox5_SelectedIndexChanged);
      this.label20.AutoSize = true;
      this.label20.Location = new Point(15, 74);
      this.label20.Name = "label20";
      this.label20.Size = new Size(53, 12);
      this.label20.TabIndex = 137;
      this.label20.Text = "背景颜色";
      this.label20.Visible = false;
      this.groupBox6.Controls.Add((Control) this.numericUpDown11);
      this.groupBox6.Controls.Add((Control) this.numericUpDown12);
      this.groupBox6.Controls.Add((Control) this.label18);
      this.groupBox6.Controls.Add((Control) this.label19);
      this.groupBox6.Location = new Point(379, 59);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(185, 58);
      this.groupBox6.TabIndex = 136;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "结束坐标";
      this.groupBox6.Visible = false;
      this.numericUpDown11.Location = new Point(114, 24);
      this.numericUpDown11.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown11.Name = "numericUpDown11";
      this.numericUpDown11.Size = new Size(51, 21);
      this.numericUpDown11.TabIndex = 135;
      this.numericUpDown11.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown12.Location = new Point(29, 24);
      this.numericUpDown12.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown12.Name = "numericUpDown12";
      this.numericUpDown12.Size = new Size(51, 21);
      this.numericUpDown12.TabIndex = 134;
      this.numericUpDown12.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.label18.AutoSize = true;
      this.label18.Location = new Point(98, 28);
      this.label18.Name = "label18";
      this.label18.Size = new Size(11, 12);
      this.label18.TabIndex = 133;
      this.label18.Text = "Y";
      this.label19.AutoSize = true;
      this.label19.Location = new Point(12, 28);
      this.label19.Name = "label19";
      this.label19.Size = new Size(11, 12);
      this.label19.TabIndex = 132;
      this.label19.Text = "X";
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Items.AddRange(new object[4]
      {
        (object) "清屏",
        (object) "设置背景",
        (object) "区域反转",
        (object) "删除窗口"
      });
      this.comboBox4.Location = new Point(76, 19);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new Size(86, 20);
      this.comboBox4.TabIndex = 132;
      this.comboBox4.Text = "清屏";
      this.comboBox4.SelectedIndexChanged += new EventHandler(this.comboBox4_SelectedIndexChanged);
      this.label14.AutoSize = true;
      this.label14.Location = new Point(15, 22);
      this.label14.Name = "label14";
      this.label14.Size = new Size(53, 12);
      this.label14.TabIndex = 131;
      this.label14.Text = "操作项目";
      this.tabPage4.Controls.Add((Control) this.numericUpDown1);
      this.tabPage4.Controls.Add((Control) this.label3);
      this.tabPage4.Controls.Add((Control) this.groupBox8);
      this.tabPage4.Controls.Add((Control) this.groupBox7);
      this.tabPage4.Controls.Add((Control) this.comboBox6);
      this.tabPage4.Controls.Add((Control) this.label25);
      this.tabPage4.Controls.Add((Control) this.comboBox7);
      this.tabPage4.Controls.Add((Control) this.label26);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(580, 134);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "绘制点线";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.numericUpDown1.Location = new Point(77, 90);
      this.numericUpDown1.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown1.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new Size(88, 21);
      this.numericUpDown1.TabIndex = 136;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label3.AutoSize = true;
      this.label3.Location = new Point(40, 94);
      this.label3.Name = "label3";
      this.label3.Size = new Size(29, 12);
      this.label3.TabIndex = 144;
      this.label3.Text = "线宽";
      this.groupBox8.Controls.Add((Control) this.numericUpDown15);
      this.groupBox8.Controls.Add((Control) this.numericUpDown16);
      this.groupBox8.Controls.Add((Control) this.label27);
      this.groupBox8.Controls.Add((Control) this.label28);
      this.groupBox8.Location = new Point(379, 53);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(185, 58);
      this.groupBox8.TabIndex = 142;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "结束坐标";
      this.groupBox8.Visible = false;
      this.numericUpDown15.Location = new Point(114, 24);
      this.numericUpDown15.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown15.Name = "numericUpDown15";
      this.numericUpDown15.Size = new Size(51, 21);
      this.numericUpDown15.TabIndex = 135;
      this.numericUpDown15.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown16.Location = new Point(29, 24);
      this.numericUpDown16.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown16.Name = "numericUpDown16";
      this.numericUpDown16.Size = new Size(51, 21);
      this.numericUpDown16.TabIndex = 134;
      this.numericUpDown16.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label27.AutoSize = true;
      this.label27.Location = new Point(98, 28);
      this.label27.Name = "label27";
      this.label27.Size = new Size(11, 12);
      this.label27.TabIndex = 133;
      this.label27.Text = "Y";
      this.label28.AutoSize = true;
      this.label28.Location = new Point(12, 28);
      this.label28.Name = "label28";
      this.label28.Size = new Size(11, 12);
      this.label28.TabIndex = 132;
      this.label28.Text = "X";
      this.groupBox7.Controls.Add((Control) this.numericUpDown13);
      this.groupBox7.Controls.Add((Control) this.numericUpDown14);
      this.groupBox7.Controls.Add((Control) this.label23);
      this.groupBox7.Controls.Add((Control) this.label24);
      this.groupBox7.Location = new Point(180, 53);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(185, 58);
      this.groupBox7.TabIndex = 141;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "起始坐标";
      this.numericUpDown13.Location = new Point(114, 24);
      this.numericUpDown13.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown13.Name = "numericUpDown13";
      this.numericUpDown13.Size = new Size(51, 21);
      this.numericUpDown13.TabIndex = 135;
      this.numericUpDown13.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown14.Location = new Point(29, 24);
      this.numericUpDown14.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown14.Name = "numericUpDown14";
      this.numericUpDown14.Size = new Size(51, 21);
      this.numericUpDown14.TabIndex = 134;
      this.numericUpDown14.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label23.AutoSize = true;
      this.label23.Location = new Point(98, 28);
      this.label23.Name = "label23";
      this.label23.Size = new Size(11, 12);
      this.label23.TabIndex = 133;
      this.label23.Text = "Y";
      this.label24.AutoSize = true;
      this.label24.Location = new Point(12, 28);
      this.label24.Name = "label24";
      this.label24.Size = new Size(11, 12);
      this.label24.TabIndex = 132;
      this.label24.Text = "X";
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox6.Location = new Point(75, 54);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new Size(88, 20);
      this.comboBox6.TabIndex = 143;
      this.comboBox6.Text = "红色";
      this.label25.AutoSize = true;
      this.label25.Location = new Point(40, 57);
      this.label25.Name = "label25";
      this.label25.Size = new Size(29, 12);
      this.label25.TabIndex = 142;
      this.label25.Text = "颜色";
      this.comboBox7.FormattingEnabled = true;
      this.comboBox7.Items.AddRange(new object[2]
      {
        (object) "画点",
        (object) "画线"
      });
      this.comboBox7.Location = new Point(77, 19);
      this.comboBox7.Name = "comboBox7";
      this.comboBox7.Size = new Size(86, 20);
      this.comboBox7.TabIndex = 140;
      this.comboBox7.Text = "画点";
      this.comboBox7.SelectedIndexChanged += new EventHandler(this.comboBox7_SelectedIndexChanged);
      this.label26.AutoSize = true;
      this.label26.Location = new Point(16, 22);
      this.label26.Name = "label26";
      this.label26.Size = new Size(53, 12);
      this.label26.TabIndex = 139;
      this.label26.Text = "绘制对象";
      this.tabPage5.Controls.Add((Control) this.label36);
      this.tabPage5.Controls.Add((Control) this.label37);
      this.tabPage5.Controls.Add((Control) this.numericUpDown20);
      this.tabPage5.Controls.Add((Control) this.numericUpDown21);
      this.tabPage5.Controls.Add((Control) this.label32);
      this.tabPage5.Controls.Add((Control) this.label34);
      this.tabPage5.Controls.Add((Control) this.numericUpDown8);
      this.tabPage5.Controls.Add((Control) this.numericUpDown17);
      this.tabPage5.Controls.Add((Control) this.label30);
      this.tabPage5.Controls.Add((Control) this.label29);
      this.tabPage5.Controls.Add((Control) this.numericUpDown3);
      this.tabPage5.Controls.Add((Control) this.numericUpDown6);
      this.tabPage5.Controls.Add((Control) this.numericUpDown2);
      this.tabPage5.Controls.Add((Control) this.label4);
      this.tabPage5.Controls.Add((Control) this.comboBox8);
      this.tabPage5.Controls.Add((Control) this.label16);
      this.tabPage5.Controls.Add((Control) this.comboBox9);
      this.tabPage5.Controls.Add((Control) this.label22);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(580, 134);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "绘制图形";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.label36.AutoSize = true;
      this.label36.Location = new Point(454, 57);
      this.label36.Name = "label36";
      this.label36.Size = new Size(47, 12);
      this.label36.TabIndex = 160;
      this.label36.Text = "坐标 X3";
      this.label36.Visible = false;
      this.label37.AutoSize = true;
      this.label37.Location = new Point(454, 94);
      this.label37.Name = "label37";
      this.label37.Size = new Size(47, 12);
      this.label37.TabIndex = 161;
      this.label37.Text = "坐标 Y3";
      this.label37.Visible = false;
      this.numericUpDown20.Location = new Point(511, 90);
      this.numericUpDown20.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown20.Name = "numericUpDown20";
      this.numericUpDown20.Size = new Size(51, 21);
      this.numericUpDown20.TabIndex = 163;
      this.numericUpDown20.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown20.Visible = false;
      this.numericUpDown21.Location = new Point(511, 53);
      this.numericUpDown21.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown21.Name = "numericUpDown21";
      this.numericUpDown21.Size = new Size(51, 21);
      this.numericUpDown21.TabIndex = 162;
      this.numericUpDown21.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown21.Visible = false;
      this.label32.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label32.AutoSize = true;
      this.label32.Location = new Point(193, 57);
      this.label32.Name = "label32";
      this.label32.RightToLeft = RightToLeft.No;
      this.label32.Size = new Size(47, 12);
      this.label32.TabIndex = 154;
      this.label32.Text = "坐标 X1";
      this.label32.TextAlign = ContentAlignment.TopRight;
      this.label34.AutoSize = true;
      this.label34.Location = new Point(193, 94);
      this.label34.Name = "label34";
      this.label34.Size = new Size(47, 12);
      this.label34.TabIndex = 155;
      this.label34.Text = "坐标 Y1";
      this.numericUpDown8.Location = new Point(246, 90);
      this.numericUpDown8.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown8.Name = "numericUpDown8";
      this.numericUpDown8.Size = new Size(51, 21);
      this.numericUpDown8.TabIndex = 157;
      this.numericUpDown8.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown17.Location = new Point(246, 53);
      this.numericUpDown17.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown17.Name = "numericUpDown17";
      this.numericUpDown17.Size = new Size(51, 21);
      this.numericUpDown17.TabIndex = 156;
      this.numericUpDown17.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label30.AutoSize = true;
      this.label30.Location = new Point(326, 57);
      this.label30.Name = "label30";
      this.label30.Size = new Size(47, 12);
      this.label30.TabIndex = 132;
      this.label30.Text = "坐标 X2";
      this.label29.AutoSize = true;
      this.label29.Location = new Point(326, 94);
      this.label29.Name = "label29";
      this.label29.Size = new Size(47, 12);
      this.label29.TabIndex = 133;
      this.label29.Text = "坐标 Y2";
      this.numericUpDown3.Location = new Point(378, 90);
      this.numericUpDown3.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new Size(51, 21);
      this.numericUpDown3.TabIndex = 135;
      this.numericUpDown3.Value = new Decimal(new int[4]
      {
        12,
        0,
        0,
        0
      });
      this.numericUpDown6.Location = new Point(378, 53);
      this.numericUpDown6.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown6.Name = "numericUpDown6";
      this.numericUpDown6.Size = new Size(51, 21);
      this.numericUpDown6.TabIndex = 134;
      this.numericUpDown6.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown2.Location = new Point(77, 90);
      this.numericUpDown2.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown2.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new Size(88, 21);
      this.numericUpDown2.TabIndex = 145;
      this.numericUpDown2.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label4.AutoSize = true;
      this.label4.Location = new Point(40, 94);
      this.label4.Name = "label4";
      this.label4.Size = new Size(29, 12);
      this.label4.TabIndex = 150;
      this.label4.Text = "线宽";
      this.comboBox8.FormattingEnabled = true;
      this.comboBox8.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox8.Location = new Point(75, 53);
      this.comboBox8.Name = "comboBox8";
      this.comboBox8.Size = new Size(88, 20);
      this.comboBox8.TabIndex = 149;
      this.comboBox8.Text = "红色";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(40, 57);
      this.label16.Name = "label16";
      this.label16.Size = new Size(29, 12);
      this.label16.TabIndex = 148;
      this.label16.Text = "颜色";
      this.comboBox9.FormattingEnabled = true;
      this.comboBox9.Items.AddRange(new object[4]
      {
        (object) "矩形",
        (object) "多边形",
        (object) "圆",
        (object) "圆弧"
      });
      this.comboBox9.Location = new Point(77, 19);
      this.comboBox9.Name = "comboBox9";
      this.comboBox9.Size = new Size(86, 20);
      this.comboBox9.TabIndex = 147;
      this.comboBox9.Text = "矩形";
      this.comboBox9.SelectedIndexChanged += new EventHandler(this.comboBox9_SelectedIndexChanged);
      this.label22.AutoSize = true;
      this.label22.Location = new Point(16, 22);
      this.label22.Name = "label22";
      this.label22.Size = new Size(53, 12);
      this.label22.TabIndex = 146;
      this.label22.Text = "图形类型";
      this.tabPage6.Controls.Add((Control) this.numericUpDown22);
      this.tabPage6.Controls.Add((Control) this.label40);
      this.tabPage6.Controls.Add((Control) this.numericUpDown19);
      this.tabPage6.Controls.Add((Control) this.comboBox12);
      this.tabPage6.Controls.Add((Control) this.label39);
      this.tabPage6.Controls.Add((Control) this.label38);
      this.tabPage6.Controls.Add((Control) this.comboBox10);
      this.tabPage6.Controls.Add((Control) this.label35);
      this.tabPage6.Controls.Add((Control) this.numericUpDown7);
      this.tabPage6.Controls.Add((Control) this.numericUpDown18);
      this.tabPage6.Controls.Add((Control) this.label31);
      this.tabPage6.Controls.Add((Control) this.textBox9);
      this.tabPage6.Controls.Add((Control) this.label33);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new Padding(3);
      this.tabPage6.Size = new Size(580, 134);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "显示文字";
      this.tabPage6.UseVisualStyleBackColor = true;
      this.tabPage6.Click += new EventHandler(this.tabPage6_Click);
      this.numericUpDown22.Location = new Point(510, 89);
      this.numericUpDown22.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown22.Name = "numericUpDown22";
      this.numericUpDown22.Size = new Size(51, 21);
      this.numericUpDown22.TabIndex = 158;
      this.numericUpDown22.TabStop = false;
      this.label40.AutoSize = true;
      this.label40.Location = new Point(475, 93);
      this.label40.Name = "label40";
      this.label40.Size = new Size(29, 12);
      this.label40.TabIndex = 157;
      this.label40.Text = "间距";
      this.numericUpDown19.Increment = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.numericUpDown19.Location = new Point(510, 55);
      this.numericUpDown19.Maximum = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown19.Minimum = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown19.Name = "numericUpDown19";
      this.numericUpDown19.Size = new Size(51, 21);
      this.numericUpDown19.TabIndex = 156;
      this.numericUpDown19.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.comboBox12.FormattingEnabled = true;
      this.comboBox12.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox12.Location = new Point(400, 89);
      this.comboBox12.Name = "comboBox12";
      this.comboBox12.Size = new Size(51, 20);
      this.comboBox12.TabIndex = 155;
      this.comboBox12.Text = "红色";
      this.label39.AutoSize = true;
      this.label39.Location = new Point(365, 93);
      this.label39.Name = "label39";
      this.label39.Size = new Size(29, 12);
      this.label39.TabIndex = 154;
      this.label39.Text = "颜色";
      this.label38.AutoSize = true;
      this.label38.Location = new Point(475, 59);
      this.label38.Name = "label38";
      this.label38.Size = new Size(29, 12);
      this.label38.TabIndex = 152;
      this.label38.Text = "字号";
      this.comboBox10.FormattingEnabled = true;
      this.comboBox10.Items.AddRange(new object[4]
      {
        (object) "自定义",
        (object) "宋体",
        (object) "楷体",
        (object) "黑体"
      });
      this.comboBox10.Location = new Point(400, 55);
      this.comboBox10.Name = "comboBox10";
      this.comboBox10.Size = new Size(51, 20);
      this.comboBox10.TabIndex = 151;
      this.comboBox10.Text = "宋体";
      this.label35.AutoSize = true;
      this.label35.Location = new Point(365, 59);
      this.label35.Name = "label35";
      this.label35.Size = new Size(29, 12);
      this.label35.TabIndex = 150;
      this.label35.Text = "字体";
      this.numericUpDown7.Location = new Point(510, 21);
      this.numericUpDown7.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown7.Name = "numericUpDown7";
      this.numericUpDown7.Size = new Size(51, 21);
      this.numericUpDown7.TabIndex = 135;
      this.numericUpDown7.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown7.ValueChanged += new EventHandler(this.numericUpDown7_ValueChanged);
      this.numericUpDown18.Location = new Point(399, 21);
      this.numericUpDown18.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown18.Name = "numericUpDown18";
      this.numericUpDown18.Size = new Size(51, 21);
      this.numericUpDown18.TabIndex = 134;
      this.numericUpDown18.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label31.AutoSize = true;
      this.label31.Location = new Point(469, 25);
      this.label31.Name = "label31";
      this.label31.Size = new Size(35, 12);
      this.label31.TabIndex = 133;
      this.label31.Text = "Y坐标";
      this.label31.Click += new EventHandler(this.label31_Click);
      this.textBox9.Location = new Point(18, 18);
      this.textBox9.Multiline = true;
      this.textBox9.Name = "textBox9";
      this.textBox9.ScrollBars = ScrollBars.Vertical;
      this.textBox9.Size = new Size(327, 92);
      this.textBox9.TabIndex = 128;
      this.textBox9.Text = "ABCD123";
      this.label33.AutoSize = true;
      this.label33.Location = new Point(358, 25);
      this.label33.Name = "label33";
      this.label33.Size = new Size(35, 12);
      this.label33.TabIndex = 132;
      this.label33.Text = "X坐标";
      this.tabPage7.Controls.Add((Control) this.comboBox21);
      this.tabPage7.Controls.Add((Control) this.label74);
      this.tabPage7.Controls.Add((Control) this.numericUpDown48);
      this.tabPage7.Controls.Add((Control) this.label78);
      this.tabPage7.Location = new Point(4, 22);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Padding = new Padding(3);
      this.tabPage7.Size = new Size(580, 134);
      this.tabPage7.TabIndex = 6;
      this.tabPage7.Text = "IO操作";
      this.tabPage7.UseVisualStyleBackColor = true;
      this.comboBox21.FormattingEnabled = true;
      this.comboBox21.Items.AddRange(new object[3]
      {
        (object) "输出高电平",
        (object) "输出低电平",
        (object) "读取电平状态"
      });
      this.comboBox21.Location = new Point(49, 31);
      this.comboBox21.Name = "comboBox21";
      this.comboBox21.Size = new Size(86, 20);
      this.comboBox21.TabIndex = 169;
      this.comboBox21.Text = "输出高电平";
      this.label74.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label74.AutoSize = true;
      this.label74.Location = new Point(191, 35);
      this.label74.Name = "label74";
      this.label74.RightToLeft = RightToLeft.No;
      this.label74.Size = new Size(41, 12);
      this.label74.TabIndex = 166;
      this.label74.Text = "IO编号";
      this.label74.TextAlign = ContentAlignment.TopRight;
      this.numericUpDown48.Location = new Point(243, 31);
      this.numericUpDown48.Maximum = new Decimal(new int[4]
      {
        99,
        0,
        0,
        0
      });
      this.numericUpDown48.Name = "numericUpDown48";
      this.numericUpDown48.Size = new Size(51, 21);
      this.numericUpDown48.TabIndex = 168;
      this.label78.AutoSize = true;
      this.label78.Location = new Point(14, 35);
      this.label78.Name = "label78";
      this.label78.Size = new Size(29, 12);
      this.label78.TabIndex = 165;
      this.label78.Text = "操作";
      this.tabPage8.Controls.Add((Control) this.numericUpDown68);
      this.tabPage8.Controls.Add((Control) this.label147);
      this.tabPage8.Controls.Add((Control) this.checkBox1);
      this.tabPage8.Controls.Add((Control) this.label92);
      this.tabPage8.Controls.Add((Control) this.numericUpDown52);
      this.tabPage8.Controls.Add((Control) this.comboBox28);
      this.tabPage8.Controls.Add((Control) this.comboBox27);
      this.tabPage8.Controls.Add((Control) this.comboBox26);
      this.tabPage8.Controls.Add((Control) this.numericUpDown56);
      this.tabPage8.Controls.Add((Control) this.label86);
      this.tabPage8.Controls.Add((Control) this.numericUpDown57);
      this.tabPage8.Controls.Add((Control) this.comboBox24);
      this.tabPage8.Controls.Add((Control) this.label87);
      this.tabPage8.Controls.Add((Control) this.label88);
      this.tabPage8.Controls.Add((Control) this.comboBox25);
      this.tabPage8.Controls.Add((Control) this.label89);
      this.tabPage8.Controls.Add((Control) this.numericUpDown58);
      this.tabPage8.Controls.Add((Control) this.numericUpDown59);
      this.tabPage8.Controls.Add((Control) this.label90);
      this.tabPage8.Controls.Add((Control) this.label91);
      this.tabPage8.Controls.Add((Control) this.label80);
      this.tabPage8.Controls.Add((Control) this.label81);
      this.tabPage8.Controls.Add((Control) this.label82);
      this.tabPage8.Controls.Add((Control) this.comboBox23);
      this.tabPage8.Controls.Add((Control) this.label83);
      this.tabPage8.Controls.Add((Control) this.numericUpDown54);
      this.tabPage8.Controls.Add((Control) this.numericUpDown55);
      this.tabPage8.Controls.Add((Control) this.label84);
      this.tabPage8.Controls.Add((Control) this.textBox10);
      this.tabPage8.Controls.Add((Control) this.label85);
      this.tabPage8.Location = new Point(4, 22);
      this.tabPage8.Name = "tabPage8";
      this.tabPage8.Padding = new Padding(3);
      this.tabPage8.Size = new Size(580, 134);
      this.tabPage8.TabIndex = 7;
      this.tabPage8.Text = "文本窗";
      this.tabPage8.UseVisualStyleBackColor = true;
      this.numericUpDown68.Location = new Point(330, 96);
      this.numericUpDown68.Maximum = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown68.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown68.Name = "numericUpDown68";
      this.numericUpDown68.Size = new Size(38, 21);
      this.numericUpDown68.TabIndex = 191;
      this.numericUpDown68.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label147.AutoSize = true;
      this.label147.Location = new Point(283, 100);
      this.label147.Name = "label147";
      this.label147.Size = new Size(41, 12);
      this.label147.TabIndex = 190;
      this.label147.Text = "窗口号";
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(396, 100);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(84, 16);
      this.checkBox1.TabIndex = 189;
      this.checkBox1.Text = "播放前清场";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.label92.AutoSize = true;
      this.label92.Location = new Point(397, 74);
      this.label92.Name = "label92";
      this.label92.Size = new Size(29, 12);
      this.label92.TabIndex = 188;
      this.label92.Text = "停留";
      this.numericUpDown52.Location = new Point(429, 44);
      this.numericUpDown52.Maximum = new Decimal(new int[4]
      {
        7,
        0,
        0,
        0
      });
      this.numericUpDown52.Name = "numericUpDown52";
      this.numericUpDown52.Size = new Size(34, 21);
      this.numericUpDown52.TabIndex = 187;
      this.numericUpDown52.Value = new Decimal(new int[4]
      {
        6,
        0,
        0,
        0
      });
      this.comboBox28.FormattingEnabled = true;
      this.comboBox28.Items.AddRange(new object[43]
      {
        (object) "固定",
        (object) "上覆盖",
        (object) "下覆盖",
        (object) "左覆盖",
        (object) "右覆盖",
        (object) "上移",
        (object) "下移",
        (object) "左移",
        (object) "右移",
        (object) "水平百叶",
        (object) "垂直百叶",
        (object) "左上覆盖",
        (object) "左下覆盖",
        (object) "右上覆盖",
        (object) "右下覆盖",
        (object) "中间向四周（矩形）",
        (object) "四周向中间（矩形）",
        (object) "闪烁",
        (object) "向中覆盖",
        (object) "向两边覆盖",
        (object) "飘雪",
        (object) "雪花",
        (object) "堆叠",
        (object) "左斜线",
        (object) "右斜线",
        (object) "上帘",
        (object) "下帘",
        (object) "左帘",
        (object) "右帘",
        (object) "水平擦",
        (object) "垂直擦",
        (object) "马赛克  ",
        (object) "水平刷",
        (object) "垂直刷",
        (object) "左上移动",
        (object) "左下移动",
        (object) "右上移动",
        (object) "右下移动",
        (object) "中间向四周（十字）",
        (object) "四周向中间（十字）",
        (object) "中出",
        (object) "边出",
        (object) "随机"
      });
      this.comboBox28.Location = new Point(444, 18);
      this.comboBox28.Name = "comboBox28";
      this.comboBox28.Size = new Size(119, 20);
      this.comboBox28.TabIndex = 186;
      this.comboBox28.Text = "左移";
      this.comboBox28.SelectedIndexChanged += new EventHandler(this.comboBox28_SelectedIndexChanged);
      this.comboBox27.FormattingEnabled = true;
      this.comboBox27.Items.AddRange(new object[4]
      {
        (object) "靠上",
        (object) "靠下",
        (object) "居中",
        (object) "平均"
      });
      this.comboBox27.Location = new Point(322, 70);
      this.comboBox27.Name = "comboBox27";
      this.comboBox27.Size = new Size(46, 20);
      this.comboBox27.TabIndex = 185;
      this.comboBox27.Text = "靠上";
      this.comboBox26.FormattingEnabled = true;
      this.comboBox26.Items.AddRange(new object[4]
      {
        (object) "靠左",
        (object) "靠右",
        (object) "居中",
        (object) "平均分配"
      });
      this.comboBox26.Location = new Point(321, 44);
      this.comboBox26.Name = "comboBox26";
      this.comboBox26.Size = new Size(47, 20);
      this.comboBox26.TabIndex = 184;
      this.comboBox26.Text = "靠左";
      this.numericUpDown56.Location = new Point(429, 70);
      this.numericUpDown56.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown56.Name = "numericUpDown56";
      this.numericUpDown56.Size = new Size(34, 21);
      this.numericUpDown56.TabIndex = 183;
      this.numericUpDown56.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label86.AutoSize = true;
      this.label86.Location = new Point(397, 48);
      this.label86.Name = "label86";
      this.label86.Size = new Size(29, 12);
      this.label86.TabIndex = 182;
      this.label86.Text = "速度";
      this.numericUpDown57.Increment = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.numericUpDown57.Location = new Point(518, 70);
      this.numericUpDown57.Maximum = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown57.Minimum = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown57.Name = "numericUpDown57";
      this.numericUpDown57.Size = new Size(45, 21);
      this.numericUpDown57.TabIndex = 181;
      this.numericUpDown57.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.comboBox24.FormattingEnabled = true;
      this.comboBox24.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox24.Location = new Point(518, 98);
      this.comboBox24.Name = "comboBox24";
      this.comboBox24.Size = new Size(45, 20);
      this.comboBox24.TabIndex = 180;
      this.comboBox24.Text = "红色";
      this.label87.AutoSize = true;
      this.label87.Location = new Point(488, 102);
      this.label87.Name = "label87";
      this.label87.Size = new Size(29, 12);
      this.label87.TabIndex = 179;
      this.label87.Text = "颜色";
      this.label88.AutoSize = true;
      this.label88.Location = new Point(488, 74);
      this.label88.Name = "label88";
      this.label88.Size = new Size(29, 12);
      this.label88.TabIndex = 178;
      this.label88.Text = "字号";
      this.comboBox25.FormattingEnabled = true;
      this.comboBox25.Items.AddRange(new object[4]
      {
        (object) "自定义",
        (object) "宋体",
        (object) "楷体",
        (object) "黑体"
      });
      this.comboBox25.Location = new Point(518, 44);
      this.comboBox25.Name = "comboBox25";
      this.comboBox25.Size = new Size(45, 20);
      this.comboBox25.TabIndex = 177;
      this.comboBox25.Text = "宋体";
      this.label89.AutoSize = true;
      this.label89.Location = new Point(488, 48);
      this.label89.Name = "label89";
      this.label89.Size = new Size(29, 12);
      this.label89.TabIndex = 176;
      this.label89.Text = "字体";
      this.numericUpDown58.Location = new Point(229, 96);
      this.numericUpDown58.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown58.Name = "numericUpDown58";
      this.numericUpDown58.Size = new Size(45, 21);
      this.numericUpDown58.TabIndex = 175;
      this.numericUpDown58.Value = new Decimal(new int[4]
      {
        32,
        0,
        0,
        0
      });
      this.numericUpDown59.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown59.Location = new Point(229, 70);
      this.numericUpDown59.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown59.Name = "numericUpDown59";
      this.numericUpDown59.Size = new Size(45, 21);
      this.numericUpDown59.TabIndex = 174;
      this.numericUpDown59.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.label90.AutoSize = true;
      this.label90.Location = new Point(189, 100);
      this.label90.Name = "label90";
      this.label90.Size = new Size(35, 12);
      this.label90.TabIndex = 173;
      this.label90.Text = "Y点数";
      this.label91.AutoSize = true;
      this.label91.Location = new Point(189, 74);
      this.label91.Name = "label91";
      this.label91.Size = new Size(35, 12);
      this.label91.TabIndex = 172;
      this.label91.Text = "X点数";
      this.label80.AutoSize = true;
      this.label80.Location = new Point(412, 21);
      this.label80.Name = "label80";
      this.label80.Size = new Size(29, 12);
      this.label80.TabIndex = 170;
      this.label80.Text = "特技";
      this.label81.AutoSize = true;
      this.label81.Location = new Point(289, 48);
      this.label81.Name = "label81";
      this.label81.Size = new Size(29, 12);
      this.label81.TabIndex = 167;
      this.label81.Text = "横向";
      this.label82.AutoSize = true;
      this.label82.Location = new Point(289, 74);
      this.label82.Name = "label82";
      this.label82.Size = new Size(29, 12);
      this.label82.TabIndex = 166;
      this.label82.Text = "纵向";
      this.comboBox23.FormattingEnabled = true;
      this.comboBox23.Items.AddRange(new object[4]
      {
        (object) "单行分页",
        (object) "单行连续",
        (object) "多行分页",
        (object) "多行连续"
      });
      this.comboBox23.Location = new Point(322, 18);
      this.comboBox23.Name = "comboBox23";
      this.comboBox23.Size = new Size(73, 20);
      this.comboBox23.TabIndex = 165;
      this.comboBox23.Text = "单行连续";
      this.label83.AutoSize = true;
      this.label83.Location = new Point(289, 22);
      this.label83.Name = "label83";
      this.label83.Size = new Size(29, 12);
      this.label83.TabIndex = 164;
      this.label83.Text = "排版";
      this.numericUpDown54.Location = new Point(229, 44);
      this.numericUpDown54.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown54.Name = "numericUpDown54";
      this.numericUpDown54.Size = new Size(45, 21);
      this.numericUpDown54.TabIndex = 163;
      this.numericUpDown55.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown55.Location = new Point(229, 18);
      this.numericUpDown55.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown55.Name = "numericUpDown55";
      this.numericUpDown55.Size = new Size(45, 21);
      this.numericUpDown55.TabIndex = 162;
      this.label84.AutoSize = true;
      this.label84.Location = new Point(189, 48);
      this.label84.Name = "label84";
      this.label84.Size = new Size(35, 12);
      this.label84.TabIndex = 161;
      this.label84.Text = "Y坐标";
      this.textBox10.Location = new Point(17, 18);
      this.textBox10.Multiline = true;
      this.textBox10.Name = "textBox10";
      this.textBox10.ScrollBars = ScrollBars.Vertical;
      this.textBox10.Size = new Size(165, 99);
      this.textBox10.TabIndex = 159;
      this.textBox10.Text = "Welcome";
      this.label85.AutoSize = true;
      this.label85.Location = new Point(189, 22);
      this.label85.Name = "label85";
      this.label85.Size = new Size(35, 12);
      this.label85.TabIndex = 160;
      this.label85.Text = "X坐标";
      this.tabPage9.Controls.Add((Control) this.checkBox2);
      this.tabPage9.Controls.Add((Control) this.label75);
      this.tabPage9.Controls.Add((Control) this.numericUpDown47);
      this.tabPage9.Controls.Add((Control) this.comboBox36);
      this.tabPage9.Controls.Add((Control) this.numericUpDown49);
      this.tabPage9.Controls.Add((Control) this.label76);
      this.tabPage9.Controls.Add((Control) this.label77);
      this.tabPage9.Controls.Add((Control) this.numericUpDown69);
      this.tabPage9.Controls.Add((Control) this.label148);
      this.tabPage9.Controls.Add((Control) this.comboBox22);
      this.tabPage9.Controls.Add((Control) this.comboBox29);
      this.tabPage9.Controls.Add((Control) this.comboBox32);
      this.tabPage9.Controls.Add((Control) this.comboBox34);
      this.tabPage9.Controls.Add((Control) this.textBox11);
      this.tabPage9.Controls.Add((Control) this.comboBox33);
      this.tabPage9.Controls.Add((Control) this.label104);
      this.tabPage9.Controls.Add((Control) this.label103);
      this.tabPage9.Controls.Add((Control) this.numericUpDown53);
      this.tabPage9.Controls.Add((Control) this.comboBox30);
      this.tabPage9.Controls.Add((Control) this.label93);
      this.tabPage9.Controls.Add((Control) this.label94);
      this.tabPage9.Controls.Add((Control) this.comboBox31);
      this.tabPage9.Controls.Add((Control) this.label95);
      this.tabPage9.Controls.Add((Control) this.numericUpDown60);
      this.tabPage9.Controls.Add((Control) this.numericUpDown61);
      this.tabPage9.Controls.Add((Control) this.label96);
      this.tabPage9.Controls.Add((Control) this.label97);
      this.tabPage9.Controls.Add((Control) this.label98);
      this.tabPage9.Controls.Add((Control) this.label99);
      this.tabPage9.Controls.Add((Control) this.label100);
      this.tabPage9.Controls.Add((Control) this.numericUpDown62);
      this.tabPage9.Controls.Add((Control) this.numericUpDown63);
      this.tabPage9.Controls.Add((Control) this.label101);
      this.tabPage9.Controls.Add((Control) this.label102);
      this.tabPage9.Location = new Point(4, 22);
      this.tabPage9.Name = "tabPage9";
      this.tabPage9.Padding = new Padding(3);
      this.tabPage9.Size = new Size(580, 134);
      this.tabPage9.TabIndex = 8;
      this.tabPage9.Text = "时间窗";
      this.tabPage9.UseVisualStyleBackColor = true;
      this.tabPage9.Click += new EventHandler(this.tabPage9_Click);
      this.numericUpDown69.Location = new Point(519, 98);
      this.numericUpDown69.Maximum = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown69.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown69.Name = "numericUpDown69";
      this.numericUpDown69.Size = new Size(39, 21);
      this.numericUpDown69.TabIndex = 216;
      this.numericUpDown69.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label148.AutoSize = true;
      this.label148.Location = new Point(472, 102);
      this.label148.Name = "label148";
      this.label148.Size = new Size(41, 12);
      this.label148.TabIndex = 215;
      this.label148.Text = "窗口号";
      this.comboBox22.FormattingEnabled = true;
      this.comboBox22.Items.AddRange(new object[4]
      {
        (object) "靠上",
        (object) "靠下",
        (object) "居中",
        (object) "平均"
      });
      this.comboBox22.Location = new Point(172, 72);
      this.comboBox22.Name = "comboBox22";
      this.comboBox22.Size = new Size(73, 20);
      this.comboBox22.TabIndex = 214;
      this.comboBox22.Text = "靠上";
      this.comboBox29.FormattingEnabled = true;
      this.comboBox29.Items.AddRange(new object[4]
      {
        (object) "靠左",
        (object) "靠右",
        (object) "居中",
        (object) "平均分配"
      });
      this.comboBox29.Location = new Point(171, 46);
      this.comboBox29.Name = "comboBox29";
      this.comboBox29.Size = new Size(73, 20);
      this.comboBox29.TabIndex = 213;
      this.comboBox29.Text = "靠左";
      this.comboBox32.FormattingEnabled = true;
      this.comboBox32.Items.AddRange(new object[2]
      {
        (object) "单行",
        (object) "多行"
      });
      this.comboBox32.Location = new Point(172, 20);
      this.comboBox32.Name = "comboBox32";
      this.comboBox32.Size = new Size(73, 20);
      this.comboBox32.TabIndex = 212;
      this.comboBox32.Text = "单行";
      this.comboBox34.FormattingEnabled = true;
      this.comboBox34.Items.AddRange(new object[2]
      {
        (object) "-",
        (object) "+"
      });
      this.comboBox34.Location = new Point(170, 97);
      this.comboBox34.Name = "comboBox34";
      this.comboBox34.Size = new Size(37, 20);
      this.comboBox34.TabIndex = 211;
      this.comboBox34.Text = "-";
      this.comboBox34.Visible = false;
      this.textBox11.Location = new Point(207, 97);
      this.textBox11.Name = "textBox11";
      this.textBox11.Size = new Size(38, 21);
      this.textBox11.TabIndex = 210;
      this.textBox11.Text = "00:00";
      this.textBox11.Visible = false;
      this.comboBox33.FormattingEnabled = true;
      this.comboBox33.Items.AddRange(new object[10]
      {
        (object) "YY-MM-DD HH-mm-SS",
        (object) "YYYY-MM-DD HH-mm-SS",
        (object) "YY/MM/DD HH:mm:SS",
        (object) "YY/MM/DD ww HH/mm/SS",
        (object) "YY年MM月DD日 星期WW",
        (object) "YY年M月D日  H:m:S",
        (object) "HH:mm:SS",
        (object) "H:m:S",
        (object) "星期WW",
        (object) "ww"
      });
      this.comboBox33.Location = new Point(303, 19);
      this.comboBox33.Name = "comboBox33";
      this.comboBox33.Size = new Size(147, 20);
      this.comboBox33.TabIndex = 209;
      this.comboBox33.Text = "YY-MM-DD HH-mm-SS";
      this.comboBox33.SelectedIndexChanged += new EventHandler(this.comboBox33_SelectedIndexChanged);
      this.label104.AutoSize = true;
      this.label104.Location = new Point(268, 23);
      this.label104.Name = "label104";
      this.label104.Size = new Size(29, 12);
      this.label104.TabIndex = 208;
      this.label104.Text = "风格";
      this.label103.AutoSize = true;
      this.label103.Location = new Point(138, 101);
      this.label103.Name = "label103";
      this.label103.Size = new Size(29, 12);
      this.label103.TabIndex = 206;
      this.label103.Text = "时差";
      this.label103.Visible = false;
      this.numericUpDown53.Increment = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.numericUpDown53.Location = new Point(303, 45);
      this.numericUpDown53.Maximum = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown53.Minimum = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown53.Name = "numericUpDown53";
      this.numericUpDown53.Size = new Size(119, 21);
      this.numericUpDown53.TabIndex = 203;
      this.numericUpDown53.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown53.ValueChanged += new EventHandler(this.numericUpDown53_ValueChanged);
      this.comboBox30.FormattingEnabled = true;
      this.comboBox30.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox30.Location = new Point(506, 47);
      this.comboBox30.Name = "comboBox30";
      this.comboBox30.Size = new Size(52, 20);
      this.comboBox30.TabIndex = 202;
      this.comboBox30.Text = "红色";
      this.label93.AutoSize = true;
      this.label93.Location = new Point(472, 49);
      this.label93.Name = "label93";
      this.label93.Size = new Size(29, 12);
      this.label93.TabIndex = 201;
      this.label93.Text = "颜色";
      this.label94.AutoSize = true;
      this.label94.Location = new Point(268, 49);
      this.label94.Name = "label94";
      this.label94.Size = new Size(29, 12);
      this.label94.TabIndex = 200;
      this.label94.Text = "字号";
      this.comboBox31.FormattingEnabled = true;
      this.comboBox31.Items.AddRange(new object[4]
      {
        (object) "自定义",
        (object) "宋体",
        (object) "楷体",
        (object) "黑体"
      });
      this.comboBox31.Location = new Point(506, 19);
      this.comboBox31.Name = "comboBox31";
      this.comboBox31.Size = new Size(52, 20);
      this.comboBox31.TabIndex = 199;
      this.comboBox31.Text = "宋体";
      this.label95.AutoSize = true;
      this.label95.Location = new Point(472, 23);
      this.label95.Name = "label95";
      this.label95.Size = new Size(29, 12);
      this.label95.TabIndex = 198;
      this.label95.Text = "字体";
      this.numericUpDown60.Location = new Point(63, 98);
      this.numericUpDown60.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown60.Name = "numericUpDown60";
      this.numericUpDown60.Size = new Size(51, 21);
      this.numericUpDown60.TabIndex = 197;
      this.numericUpDown60.Value = new Decimal(new int[4]
      {
        32,
        0,
        0,
        0
      });
      this.numericUpDown61.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown61.Location = new Point(63, 72);
      this.numericUpDown61.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown61.Name = "numericUpDown61";
      this.numericUpDown61.Size = new Size(51, 21);
      this.numericUpDown61.TabIndex = 196;
      this.numericUpDown61.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.label96.AutoSize = true;
      this.label96.Location = new Point(23, 102);
      this.label96.Name = "label96";
      this.label96.Size = new Size(35, 12);
      this.label96.TabIndex = 195;
      this.label96.Text = "Y点数";
      this.label97.AutoSize = true;
      this.label97.Location = new Point(23, 76);
      this.label97.Name = "label97";
      this.label97.Size = new Size(35, 12);
      this.label97.TabIndex = 194;
      this.label97.Text = "X点数";
      this.label98.AutoSize = true;
      this.label98.Location = new Point(137, 49);
      this.label98.Name = "label98";
      this.label98.Size = new Size(29, 12);
      this.label98.TabIndex = 193;
      this.label98.Text = "横向";
      this.label99.AutoSize = true;
      this.label99.Location = new Point(137, 75);
      this.label99.Name = "label99";
      this.label99.Size = new Size(29, 12);
      this.label99.TabIndex = 192;
      this.label99.Text = "纵向";
      this.label100.AutoSize = true;
      this.label100.Location = new Point(137, 23);
      this.label100.Name = "label100";
      this.label100.Size = new Size(29, 12);
      this.label100.TabIndex = 190;
      this.label100.Text = "排版";
      this.numericUpDown62.Location = new Point(63, 46);
      this.numericUpDown62.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown62.Name = "numericUpDown62";
      this.numericUpDown62.Size = new Size(51, 21);
      this.numericUpDown62.TabIndex = 189;
      this.numericUpDown63.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown63.Location = new Point(63, 20);
      this.numericUpDown63.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown63.Name = "numericUpDown63";
      this.numericUpDown63.Size = new Size(51, 21);
      this.numericUpDown63.TabIndex = 188;
      this.label101.AutoSize = true;
      this.label101.Location = new Point(23, 50);
      this.label101.Name = "label101";
      this.label101.Size = new Size(35, 12);
      this.label101.TabIndex = 187;
      this.label101.Text = "Y坐标";
      this.label102.AutoSize = true;
      this.label102.Location = new Point(23, 24);
      this.label102.Name = "label102";
      this.label102.Size = new Size(35, 12);
      this.label102.TabIndex = 186;
      this.label102.Text = "X坐标";
      this.tabPage10.Controls.Add((Control) this.comboBox35);
      this.tabPage10.Controls.Add((Control) this.label105);
      this.tabPage10.Controls.Add((Control) this.textBox12);
      this.tabPage10.Location = new Point(4, 22);
      this.tabPage10.Name = "tabPage10";
      this.tabPage10.Padding = new Padding(3);
      this.tabPage10.Size = new Size(580, 134);
      this.tabPage10.TabIndex = 9;
      this.tabPage10.Text = "语音";
      this.tabPage10.UseVisualStyleBackColor = true;
      this.comboBox35.FormattingEnabled = true;
      this.comboBox35.Items.AddRange(new object[1]
      {
        (object) "播放语音"
      });
      this.comboBox35.Location = new Point(79, 18);
      this.comboBox35.Name = "comboBox35";
      this.comboBox35.Size = new Size(86, 20);
      this.comboBox35.TabIndex = 132;
      this.comboBox35.Text = "播放语音";
      this.comboBox35.SelectedIndexChanged += new EventHandler(this.comboBox35_SelectedIndexChanged);
      this.label105.AutoSize = true;
      this.label105.Location = new Point(18, 21);
      this.label105.Name = "label105";
      this.label105.Size = new Size(53, 12);
      this.label105.TabIndex = 131;
      this.label105.Text = "操作项目";
      this.textBox12.Location = new Point(20, 46);
      this.textBox12.Multiline = true;
      this.textBox12.Name = "textBox12";
      this.textBox12.ScrollBars = ScrollBars.Vertical;
      this.textBox12.Size = new Size(543, 74);
      this.textBox12.TabIndex = 193;
      this.textBox12.Text = "您好,欢迎光临!";
      this.textBox12.TextChanged += new EventHandler(this.textBox12_TextChanged);
      this.label41.AutoSize = true;
      this.label41.Location = new Point(454, 57);
      this.label41.Name = "label41";
      this.label41.Size = new Size(47, 12);
      this.label41.TabIndex = 160;
      this.label41.Text = "坐标 X3";
      this.label42.AutoSize = true;
      this.label42.Location = new Point(454, 94);
      this.label42.Name = "label42";
      this.label42.Size = new Size(47, 12);
      this.label42.TabIndex = 161;
      this.label42.Text = "坐标 Y3";
      this.numericUpDown23.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown23.Location = new Point(511, 90);
      this.numericUpDown23.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown23.Name = "numericUpDown23";
      this.numericUpDown23.Size = new Size(51, 21);
      this.numericUpDown23.TabIndex = 163;
      this.numericUpDown23.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown24.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown24.Location = new Point(511, 53);
      this.numericUpDown24.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown24.Name = "numericUpDown24";
      this.numericUpDown24.Size = new Size(51, 21);
      this.numericUpDown24.TabIndex = 162;
      this.numericUpDown24.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label43.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label43.AutoSize = true;
      this.label43.Location = new Point(193, 57);
      this.label43.Name = "label43";
      this.label43.RightToLeft = RightToLeft.No;
      this.label43.Size = new Size(47, 12);
      this.label43.TabIndex = 154;
      this.label43.Text = "坐标 X1";
      this.label43.TextAlign = ContentAlignment.TopRight;
      this.label44.AutoSize = true;
      this.label44.Location = new Point(193, 94);
      this.label44.Name = "label44";
      this.label44.Size = new Size(47, 12);
      this.label44.TabIndex = 155;
      this.label44.Text = "坐标 Y1";
      this.numericUpDown25.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown25.Location = new Point(246, 90);
      this.numericUpDown25.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown25.Name = "numericUpDown25";
      this.numericUpDown25.Size = new Size(51, 21);
      this.numericUpDown25.TabIndex = 157;
      this.numericUpDown25.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown26.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown26.Location = new Point(246, 53);
      this.numericUpDown26.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown26.Name = "numericUpDown26";
      this.numericUpDown26.Size = new Size(51, 21);
      this.numericUpDown26.TabIndex = 156;
      this.numericUpDown26.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label45.AutoSize = true;
      this.label45.Location = new Point(326, 57);
      this.label45.Name = "label45";
      this.label45.Size = new Size(47, 12);
      this.label45.TabIndex = 132;
      this.label45.Text = "坐标 X2";
      this.label46.AutoSize = true;
      this.label46.Location = new Point(326, 94);
      this.label46.Name = "label46";
      this.label46.Size = new Size(47, 12);
      this.label46.TabIndex = 133;
      this.label46.Text = "坐标 Y2";
      this.numericUpDown27.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown27.Location = new Point(378, 90);
      this.numericUpDown27.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown27.Name = "numericUpDown27";
      this.numericUpDown27.Size = new Size(51, 21);
      this.numericUpDown27.TabIndex = 135;
      this.numericUpDown27.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown28.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown28.Location = new Point(378, 53);
      this.numericUpDown28.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown28.Name = "numericUpDown28";
      this.numericUpDown28.Size = new Size(51, 21);
      this.numericUpDown28.TabIndex = 134;
      this.numericUpDown28.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown29.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown29.Location = new Point(77, 90);
      this.numericUpDown29.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown29.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown29.Name = "numericUpDown29";
      this.numericUpDown29.Size = new Size(88, 21);
      this.numericUpDown29.TabIndex = 145;
      this.numericUpDown29.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label47.AutoSize = true;
      this.label47.Location = new Point(40, 94);
      this.label47.Name = "label47";
      this.label47.Size = new Size(29, 12);
      this.label47.TabIndex = 150;
      this.label47.Text = "线宽";
      this.comboBox11.FormattingEnabled = true;
      this.comboBox11.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox11.Location = new Point(75, 53);
      this.comboBox11.Name = "comboBox11";
      this.comboBox11.Size = new Size(88, 20);
      this.comboBox11.TabIndex = 149;
      this.comboBox11.Text = "红色";
      this.label48.AutoSize = true;
      this.label48.Location = new Point(40, 57);
      this.label48.Name = "label48";
      this.label48.Size = new Size(29, 12);
      this.label48.TabIndex = 148;
      this.label48.Text = "颜色";
      this.comboBox13.FormattingEnabled = true;
      this.comboBox13.Items.AddRange(new object[4]
      {
        (object) "矩形",
        (object) "多边形",
        (object) "圆",
        (object) "圆弧"
      });
      this.comboBox13.Location = new Point(77, 19);
      this.comboBox13.Name = "comboBox13";
      this.comboBox13.Size = new Size(86, 20);
      this.comboBox13.TabIndex = 147;
      this.comboBox13.Text = "矩形";
      this.label49.AutoSize = true;
      this.label49.Location = new Point(16, 22);
      this.label49.Name = "label49";
      this.label49.Size = new Size(53, 12);
      this.label49.TabIndex = 146;
      this.label49.Text = "图形类型";
      this.label50.AutoSize = true;
      this.label50.Location = new Point(454, 57);
      this.label50.Name = "label50";
      this.label50.Size = new Size(47, 12);
      this.label50.TabIndex = 160;
      this.label50.Text = "坐标 X3";
      this.label51.AutoSize = true;
      this.label51.Location = new Point(454, 94);
      this.label51.Name = "label51";
      this.label51.Size = new Size(47, 12);
      this.label51.TabIndex = 161;
      this.label51.Text = "坐标 Y3";
      this.numericUpDown30.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown30.Location = new Point(511, 90);
      this.numericUpDown30.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown30.Name = "numericUpDown30";
      this.numericUpDown30.Size = new Size(51, 21);
      this.numericUpDown30.TabIndex = 163;
      this.numericUpDown30.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown31.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown31.Location = new Point(511, 53);
      this.numericUpDown31.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown31.Name = "numericUpDown31";
      this.numericUpDown31.Size = new Size(51, 21);
      this.numericUpDown31.TabIndex = 162;
      this.numericUpDown31.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label52.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label52.AutoSize = true;
      this.label52.Location = new Point(193, 57);
      this.label52.Name = "label52";
      this.label52.RightToLeft = RightToLeft.No;
      this.label52.Size = new Size(47, 12);
      this.label52.TabIndex = 154;
      this.label52.Text = "坐标 X1";
      this.label52.TextAlign = ContentAlignment.TopRight;
      this.label53.AutoSize = true;
      this.label53.Location = new Point(193, 94);
      this.label53.Name = "label53";
      this.label53.Size = new Size(47, 12);
      this.label53.TabIndex = 155;
      this.label53.Text = "坐标 Y1";
      this.numericUpDown32.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown32.Location = new Point(246, 90);
      this.numericUpDown32.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown32.Name = "numericUpDown32";
      this.numericUpDown32.Size = new Size(51, 21);
      this.numericUpDown32.TabIndex = 157;
      this.numericUpDown32.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown33.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown33.Location = new Point(246, 53);
      this.numericUpDown33.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown33.Name = "numericUpDown33";
      this.numericUpDown33.Size = new Size(51, 21);
      this.numericUpDown33.TabIndex = 156;
      this.numericUpDown33.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label54.AutoSize = true;
      this.label54.Location = new Point(326, 57);
      this.label54.Name = "label54";
      this.label54.Size = new Size(47, 12);
      this.label54.TabIndex = 132;
      this.label54.Text = "坐标 X2";
      this.label55.AutoSize = true;
      this.label55.Location = new Point(326, 94);
      this.label55.Name = "label55";
      this.label55.Size = new Size(47, 12);
      this.label55.TabIndex = 133;
      this.label55.Text = "坐标 Y2";
      this.numericUpDown34.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown34.Location = new Point(378, 90);
      this.numericUpDown34.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown34.Name = "numericUpDown34";
      this.numericUpDown34.Size = new Size(51, 21);
      this.numericUpDown34.TabIndex = 135;
      this.numericUpDown34.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown35.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown35.Location = new Point(378, 53);
      this.numericUpDown35.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown35.Name = "numericUpDown35";
      this.numericUpDown35.Size = new Size(51, 21);
      this.numericUpDown35.TabIndex = 134;
      this.numericUpDown35.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown36.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown36.Location = new Point(77, 90);
      this.numericUpDown36.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown36.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown36.Name = "numericUpDown36";
      this.numericUpDown36.Size = new Size(88, 21);
      this.numericUpDown36.TabIndex = 145;
      this.numericUpDown36.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label56.AutoSize = true;
      this.label56.Location = new Point(40, 94);
      this.label56.Name = "label56";
      this.label56.Size = new Size(29, 12);
      this.label56.TabIndex = 150;
      this.label56.Text = "线宽";
      this.comboBox14.FormattingEnabled = true;
      this.comboBox14.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox14.Location = new Point(75, 53);
      this.comboBox14.Name = "comboBox14";
      this.comboBox14.Size = new Size(88, 20);
      this.comboBox14.TabIndex = 149;
      this.comboBox14.Text = "红色";
      this.label57.AutoSize = true;
      this.label57.Location = new Point(40, 57);
      this.label57.Name = "label57";
      this.label57.Size = new Size(29, 12);
      this.label57.TabIndex = 148;
      this.label57.Text = "颜色";
      this.comboBox15.FormattingEnabled = true;
      this.comboBox15.Items.AddRange(new object[4]
      {
        (object) "矩形",
        (object) "多边形",
        (object) "圆",
        (object) "圆弧"
      });
      this.comboBox15.Location = new Point(77, 19);
      this.comboBox15.Name = "comboBox15";
      this.comboBox15.Size = new Size(86, 20);
      this.comboBox15.TabIndex = 147;
      this.comboBox15.Text = "矩形";
      this.label59.AutoSize = true;
      this.label59.Location = new Point(16, 22);
      this.label59.Name = "label59";
      this.label59.Size = new Size(53, 12);
      this.label59.TabIndex = 146;
      this.label59.Text = "图形类型";
      this.numericUpDown37.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown37.Location = new Point(77, 90);
      this.numericUpDown37.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown37.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown37.Name = "numericUpDown37";
      this.numericUpDown37.Size = new Size(88, 21);
      this.numericUpDown37.TabIndex = 136;
      this.numericUpDown37.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label60.AutoSize = true;
      this.label60.Location = new Point(40, 94);
      this.label60.Name = "label60";
      this.label60.Size = new Size(29, 12);
      this.label60.TabIndex = 144;
      this.label60.Text = "线宽";
      this.groupBox9.Controls.Add((Control) this.numericUpDown38);
      this.groupBox9.Controls.Add((Control) this.numericUpDown39);
      this.groupBox9.Controls.Add((Control) this.label61);
      this.groupBox9.Controls.Add((Control) this.label62);
      this.groupBox9.Location = new Point(387, 53);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new Size(185, 58);
      this.groupBox9.TabIndex = 142;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "结束坐标";
      this.numericUpDown38.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown38.Location = new Point(114, 24);
      this.numericUpDown38.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown38.Name = "numericUpDown38";
      this.numericUpDown38.Size = new Size(51, 21);
      this.numericUpDown38.TabIndex = 135;
      this.numericUpDown38.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown39.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown39.Location = new Point(29, 24);
      this.numericUpDown39.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown39.Name = "numericUpDown39";
      this.numericUpDown39.Size = new Size(51, 21);
      this.numericUpDown39.TabIndex = 134;
      this.numericUpDown39.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label61.AutoSize = true;
      this.label61.Location = new Point(98, 28);
      this.label61.Name = "label61";
      this.label61.Size = new Size(11, 12);
      this.label61.TabIndex = 133;
      this.label61.Text = "Y";
      this.label62.AutoSize = true;
      this.label62.Location = new Point(12, 28);
      this.label62.Name = "label62";
      this.label62.Size = new Size(11, 12);
      this.label62.TabIndex = 132;
      this.label62.Text = "X";
      this.groupBox10.Controls.Add((Control) this.numericUpDown40);
      this.groupBox10.Controls.Add((Control) this.numericUpDown41);
      this.groupBox10.Controls.Add((Control) this.label63);
      this.groupBox10.Controls.Add((Control) this.label64);
      this.groupBox10.Location = new Point(188, 53);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new Size(185, 58);
      this.groupBox10.TabIndex = 141;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "起始坐标";
      this.numericUpDown40.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown40.Location = new Point(114, 24);
      this.numericUpDown40.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown40.Name = "numericUpDown40";
      this.numericUpDown40.Size = new Size(51, 21);
      this.numericUpDown40.TabIndex = 135;
      this.numericUpDown40.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown41.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown41.Location = new Point(29, 24);
      this.numericUpDown41.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown41.Name = "numericUpDown41";
      this.numericUpDown41.Size = new Size(51, 21);
      this.numericUpDown41.TabIndex = 134;
      this.numericUpDown41.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label63.AutoSize = true;
      this.label63.Location = new Point(98, 28);
      this.label63.Name = "label63";
      this.label63.Size = new Size(11, 12);
      this.label63.TabIndex = 133;
      this.label63.Text = "Y";
      this.label64.AutoSize = true;
      this.label64.Location = new Point(12, 28);
      this.label64.Name = "label64";
      this.label64.Size = new Size(11, 12);
      this.label64.TabIndex = 132;
      this.label64.Text = "X";
      this.comboBox16.FormattingEnabled = true;
      this.comboBox16.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox16.Location = new Point(75, 54);
      this.comboBox16.Name = "comboBox16";
      this.comboBox16.Size = new Size(88, 20);
      this.comboBox16.TabIndex = 143;
      this.comboBox16.Text = "红色";
      this.label65.AutoSize = true;
      this.label65.Location = new Point(40, 57);
      this.label65.Name = "label65";
      this.label65.Size = new Size(29, 12);
      this.label65.TabIndex = 142;
      this.label65.Text = "颜色";
      this.comboBox18.FormattingEnabled = true;
      this.comboBox18.Items.AddRange(new object[2]
      {
        (object) "画点",
        (object) "画线"
      });
      this.comboBox18.Location = new Point(77, 19);
      this.comboBox18.Name = "comboBox18";
      this.comboBox18.Size = new Size(86, 20);
      this.comboBox18.TabIndex = 140;
      this.comboBox18.Text = "画点";
      this.label66.AutoSize = true;
      this.label66.Location = new Point(16, 22);
      this.label66.Name = "label66";
      this.label66.Size = new Size(53, 12);
      this.label66.TabIndex = 139;
      this.label66.Text = "绘制对象";
      this.numericUpDown42.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown42.Location = new Point(77, 90);
      this.numericUpDown42.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown42.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown42.Name = "numericUpDown42";
      this.numericUpDown42.Size = new Size(88, 21);
      this.numericUpDown42.TabIndex = 136;
      this.numericUpDown42.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label67.AutoSize = true;
      this.label67.Location = new Point(40, 94);
      this.label67.Name = "label67";
      this.label67.Size = new Size(29, 12);
      this.label67.TabIndex = 144;
      this.label67.Text = "线宽";
      this.groupBox11.Controls.Add((Control) this.numericUpDown43);
      this.groupBox11.Controls.Add((Control) this.numericUpDown44);
      this.groupBox11.Controls.Add((Control) this.label68);
      this.groupBox11.Controls.Add((Control) this.label69);
      this.groupBox11.Location = new Point(387, 53);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new Size(185, 58);
      this.groupBox11.TabIndex = 142;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "结束坐标";
      this.numericUpDown43.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown43.Location = new Point(114, 24);
      this.numericUpDown43.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown43.Name = "numericUpDown43";
      this.numericUpDown43.Size = new Size(51, 21);
      this.numericUpDown43.TabIndex = 135;
      this.numericUpDown43.Value = new Decimal(new int[4]
      {
        24,
        0,
        0,
        0
      });
      this.numericUpDown44.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown44.Location = new Point(29, 24);
      this.numericUpDown44.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown44.Name = "numericUpDown44";
      this.numericUpDown44.Size = new Size(51, 21);
      this.numericUpDown44.TabIndex = 134;
      this.numericUpDown44.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label68.AutoSize = true;
      this.label68.Location = new Point(98, 28);
      this.label68.Name = "label68";
      this.label68.Size = new Size(11, 12);
      this.label68.TabIndex = 133;
      this.label68.Text = "Y";
      this.label69.AutoSize = true;
      this.label69.Location = new Point(12, 28);
      this.label69.Name = "label69";
      this.label69.Size = new Size(11, 12);
      this.label69.TabIndex = 132;
      this.label69.Text = "X";
      this.groupBox12.Controls.Add((Control) this.numericUpDown45);
      this.groupBox12.Controls.Add((Control) this.numericUpDown46);
      this.groupBox12.Controls.Add((Control) this.label70);
      this.groupBox12.Controls.Add((Control) this.label71);
      this.groupBox12.Location = new Point(188, 53);
      this.groupBox12.Name = "groupBox12";
      this.groupBox12.Size = new Size(185, 58);
      this.groupBox12.TabIndex = 141;
      this.groupBox12.TabStop = false;
      this.groupBox12.Text = "起始坐标";
      this.numericUpDown45.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown45.Location = new Point(114, 24);
      this.numericUpDown45.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown45.Name = "numericUpDown45";
      this.numericUpDown45.Size = new Size(51, 21);
      this.numericUpDown45.TabIndex = 135;
      this.numericUpDown45.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown46.Increment = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.numericUpDown46.Location = new Point(29, 24);
      this.numericUpDown46.Maximum = new Decimal(new int[4]
      {
        4096,
        0,
        0,
        0
      });
      this.numericUpDown46.Name = "numericUpDown46";
      this.numericUpDown46.Size = new Size(51, 21);
      this.numericUpDown46.TabIndex = 134;
      this.numericUpDown46.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label70.AutoSize = true;
      this.label70.Location = new Point(98, 28);
      this.label70.Name = "label70";
      this.label70.Size = new Size(11, 12);
      this.label70.TabIndex = 133;
      this.label70.Text = "Y";
      this.label71.AutoSize = true;
      this.label71.Location = new Point(12, 28);
      this.label71.Name = "label71";
      this.label71.Size = new Size(11, 12);
      this.label71.TabIndex = 132;
      this.label71.Text = "X";
      this.comboBox19.FormattingEnabled = true;
      this.comboBox19.Items.AddRange(new object[8]
      {
        (object) "黑色",
        (object) "红色",
        (object) "绿色",
        (object) "黄色",
        (object) "蓝色",
        (object) "紫色",
        (object) "青色",
        (object) "白色"
      });
      this.comboBox19.Location = new Point(75, 54);
      this.comboBox19.Name = "comboBox19";
      this.comboBox19.Size = new Size(88, 20);
      this.comboBox19.TabIndex = 143;
      this.comboBox19.Text = "红色";
      this.label72.AutoSize = true;
      this.label72.Location = new Point(40, 57);
      this.label72.Name = "label72";
      this.label72.Size = new Size(29, 12);
      this.label72.TabIndex = 142;
      this.label72.Text = "颜色";
      this.comboBox20.FormattingEnabled = true;
      this.comboBox20.Items.AddRange(new object[2]
      {
        (object) "画点",
        (object) "画线"
      });
      this.comboBox20.Location = new Point(77, 19);
      this.comboBox20.Name = "comboBox20";
      this.comboBox20.Size = new Size(86, 20);
      this.comboBox20.TabIndex = 140;
      this.comboBox20.Text = "画点";
      this.label73.AutoSize = true;
      this.label73.Location = new Point(16, 22);
      this.label73.Name = "label73";
      this.label73.Size = new Size(53, 12);
      this.label73.TabIndex = 139;
      this.label73.Text = "绘制对象";
      this.textBox13.ForeColor = SystemColors.MenuHighlight;
      this.textBox13.Location = new Point(49, 510);
      this.textBox13.Name = "textBox13";
      this.textBox13.ScrollBars = ScrollBars.Vertical;
      this.textBox13.Size = new Size(543, 21);
      this.textBox13.TabIndex = 133;
      this.label110.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label110.AutoSize = true;
      this.label110.Location = new Point(15, 514);
      this.label110.Name = "label110";
      this.label110.RightToLeft = RightToLeft.No;
      this.label110.Size = new Size(29, 12);
      this.label110.TabIndex = 163;
      this.label110.Text = "提示";
      this.label110.TextAlign = ContentAlignment.TopRight;
      this.label111.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label111.AutoSize = true;
      this.label111.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label111.ForeColor = Color.Blue;
      this.label111.Location = new Point(610, 513);
      this.label111.Name = "label111";
      this.label111.RightToLeft = RightToLeft.No;
      this.label111.Size = new Size(105, 14);
      this.label111.TabIndex = 164;
      this.label111.Text = "www.hitiwi.com";
      this.label111.TextAlign = ContentAlignment.TopRight;
      this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(366, 101);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(84, 16);
      this.checkBox2.TabIndex = 223;
      this.checkBox2.Text = "播放前清场";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.label75.AutoSize = true;
      this.label75.Location = new Point(268, 102);
      this.label75.Name = "label75";
      this.label75.Size = new Size(29, 12);
      this.label75.TabIndex = 222;
      this.label75.Text = "停留";
      this.numericUpDown47.Location = new Point(506, 72);
      this.numericUpDown47.Maximum = new Decimal(new int[4]
      {
        7,
        0,
        0,
        0
      });
      this.numericUpDown47.Name = "numericUpDown47";
      this.numericUpDown47.Size = new Size(52, 21);
      this.numericUpDown47.TabIndex = 221;
      this.numericUpDown47.Value = new Decimal(new int[4]
      {
        6,
        0,
        0,
        0
      });
      this.comboBox36.FormattingEnabled = true;
      this.comboBox36.Items.AddRange(new object[43]
      {
        (object) "固定",
        (object) "上覆盖",
        (object) "下覆盖",
        (object) "左覆盖",
        (object) "右覆盖",
        (object) "上移",
        (object) "下移",
        (object) "左移",
        (object) "右移",
        (object) "水平百叶",
        (object) "垂直百叶",
        (object) "左上覆盖",
        (object) "左下覆盖",
        (object) "右上覆盖",
        (object) "右下覆盖",
        (object) "中间向四周（矩形）",
        (object) "四周向中间（矩形）",
        (object) "闪烁",
        (object) "向中覆盖",
        (object) "向两边覆盖",
        (object) "飘雪",
        (object) "雪花",
        (object) "堆叠",
        (object) "左斜线",
        (object) "右斜线",
        (object) "上帘",
        (object) "下帘",
        (object) "左帘",
        (object) "右帘",
        (object) "水平擦",
        (object) "垂直擦",
        (object) "马赛克  ",
        (object) "水平刷",
        (object) "垂直刷",
        (object) "左上移动",
        (object) "左下移动",
        (object) "右上移动",
        (object) "右下移动",
        (object) "中间向四周（十字）",
        (object) "四周向中间（十字）",
        (object) "中出",
        (object) "边出",
        (object) "随机"
      });
      this.comboBox36.Location = new Point(303, 72);
      this.comboBox36.Name = "comboBox36";
      this.comboBox36.Size = new Size(119, 20);
      this.comboBox36.TabIndex = 220;
      this.comboBox36.Text = "左移";
      this.numericUpDown49.Location = new Point(303, 98);
      this.numericUpDown49.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown49.Name = "numericUpDown49";
      this.numericUpDown49.Size = new Size(34, 21);
      this.numericUpDown49.TabIndex = 219;
      this.numericUpDown49.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label76.AutoSize = true;
      this.label76.Location = new Point(472, 75);
      this.label76.Name = "label76";
      this.label76.Size = new Size(29, 12);
      this.label76.TabIndex = 218;
      this.label76.Text = "速度";
      this.label77.AutoSize = true;
      this.label77.Location = new Point(268, 75);
      this.label77.Name = "label77";
      this.label77.Size = new Size(29, 12);
      this.label77.TabIndex = 217;
      this.label77.Text = "特技";
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(727, 537);
      this.Controls.Add((Control) this.label111);
      this.Controls.Add((Control) this.label110);
      this.Controls.Add((Control) this.textBox13);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox5);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.MinimizeBox = false;
      this.Name = nameof(FormMain);
      this.Text = "T系列控制卡调试助手 Ver2.2";
      this.Load += new EventHandler(this.Form1_Load);
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.numericUpDown5.EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.numericUpDown4.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.numericUpDown66.EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.numericUpDown70.EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.numericUpDown9.EndInit();
      this.numericUpDown10.EndInit();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.numericUpDown11.EndInit();
      this.numericUpDown12.EndInit();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      this.numericUpDown1.EndInit();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.numericUpDown15.EndInit();
      this.numericUpDown16.EndInit();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.numericUpDown13.EndInit();
      this.numericUpDown14.EndInit();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.numericUpDown20.EndInit();
      this.numericUpDown21.EndInit();
      this.numericUpDown8.EndInit();
      this.numericUpDown17.EndInit();
      this.numericUpDown3.EndInit();
      this.numericUpDown6.EndInit();
      this.numericUpDown2.EndInit();
      this.tabPage6.ResumeLayout(false);
      this.tabPage6.PerformLayout();
      this.numericUpDown22.EndInit();
      this.numericUpDown19.EndInit();
      this.numericUpDown7.EndInit();
      this.numericUpDown18.EndInit();
      this.tabPage7.ResumeLayout(false);
      this.tabPage7.PerformLayout();
      this.numericUpDown48.EndInit();
      this.tabPage8.ResumeLayout(false);
      this.tabPage8.PerformLayout();
      this.numericUpDown68.EndInit();
      this.numericUpDown52.EndInit();
      this.numericUpDown56.EndInit();
      this.numericUpDown57.EndInit();
      this.numericUpDown58.EndInit();
      this.numericUpDown59.EndInit();
      this.numericUpDown54.EndInit();
      this.numericUpDown55.EndInit();
      this.tabPage9.ResumeLayout(false);
      this.tabPage9.PerformLayout();
      this.numericUpDown69.EndInit();
      this.numericUpDown53.EndInit();
      this.numericUpDown60.EndInit();
      this.numericUpDown61.EndInit();
      this.numericUpDown62.EndInit();
      this.numericUpDown63.EndInit();
      this.tabPage10.ResumeLayout(false);
      this.tabPage10.PerformLayout();
      this.numericUpDown23.EndInit();
      this.numericUpDown24.EndInit();
      this.numericUpDown25.EndInit();
      this.numericUpDown26.EndInit();
      this.numericUpDown27.EndInit();
      this.numericUpDown28.EndInit();
      this.numericUpDown29.EndInit();
      this.numericUpDown30.EndInit();
      this.numericUpDown31.EndInit();
      this.numericUpDown32.EndInit();
      this.numericUpDown33.EndInit();
      this.numericUpDown34.EndInit();
      this.numericUpDown35.EndInit();
      this.numericUpDown36.EndInit();
      this.numericUpDown37.EndInit();
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.numericUpDown38.EndInit();
      this.numericUpDown39.EndInit();
      this.groupBox10.ResumeLayout(false);
      this.groupBox10.PerformLayout();
      this.numericUpDown40.EndInit();
      this.numericUpDown41.EndInit();
      this.numericUpDown42.EndInit();
      this.groupBox11.ResumeLayout(false);
      this.groupBox11.PerformLayout();
      this.numericUpDown43.EndInit();
      this.numericUpDown44.EndInit();
      this.groupBox12.ResumeLayout(false);
      this.groupBox12.PerformLayout();
      this.numericUpDown45.EndInit();
      this.numericUpDown46.EndInit();
      this.numericUpDown47.EndInit();
      this.numericUpDown49.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public static void DelayMs(int milliSecond)
    {
      int tickCount = Environment.TickCount;
      while (Math.Abs(Environment.TickCount - tickCount) < milliSecond)
        Application.DoEvents();
    }

    public byte CharToHex(int i)
    {
      return Convert.ToByte(i / 10 * 16 + i % 10);
    }

    public void GetPowerSwitch()
    {
      this.sPowerSwitch.OptType = this.comboBox3.SelectedIndex != 1 ? (this.comboBox3.SelectedIndex != 2 ? byte.MaxValue : (byte) 15) : (byte) 0;
      this.sPowerSwitch.OnTime = Convert.ToUInt16(!(this.textBox6.Text != "") || !(this.textBox7.Text != "") ? 0 : (int) Convert.ToUInt16((int) this.CharToHex(Convert.ToInt32(this.textBox6.Text)) * 256 + (int) this.CharToHex(Convert.ToInt32(this.textBox7.Text))));
      this.sPowerSwitch.OffTime = Convert.ToUInt16(!(this.textBox14.Text != "") || !(this.textBox15.Text != "") ? 0 : (int) Convert.ToUInt16((int) this.CharToHex(Convert.ToInt32(this.textBox15.Text)) * 256 + (int) this.CharToHex(Convert.ToInt32(this.textBox14.Text))));
    }

    public int BufCharToHex(byte[] SrcBuf, int SrcLength, byte[] DesBuf)
    {
      bool flag = false;
      int index1 = 0;
      int index2;
      for (index2 = 0; index2 < SrcLength - 1; ++index2)
      {
        if (SrcBuf[index2] >= (byte) 97 && SrcBuf[index2] <= (byte) 102)
        {
          if (flag)
          {
            DesBuf[index1] = Convert.ToByte((int) DesBuf[index1] * 16 + (int) SrcBuf[index2] - 97 + 10);
            ++index1;
            flag = false;
          }
          else
          {
            DesBuf[index1] = Convert.ToByte((int) SrcBuf[index2] - 97 + 10);
            flag = true;
          }
        }
        else if (SrcBuf[index2] >= (byte) 65 && SrcBuf[index2] <= (byte) 70)
        {
          if (flag)
          {
            DesBuf[index1] = Convert.ToByte((int) DesBuf[index1] * 16 + (int) SrcBuf[index2] - 65 + 10);
            ++index1;
            flag = false;
          }
          else
          {
            DesBuf[index1] = Convert.ToByte((int) SrcBuf[index2] - 65 + 10);
            flag = true;
          }
        }
        else if (SrcBuf[index2] == (byte) 48 && SrcBuf[index2 + 1] == (byte) 120)
        {
          if (SrcBuf[index2] == (byte) 48 && SrcBuf[index2 + 1] == (byte) 120)
            flag = false;
        }
        else if (SrcBuf[index2] >= (byte) 48 && SrcBuf[index2] <= (byte) 57)
        {
          if (flag)
          {
            DesBuf[index1] = Convert.ToByte((int) DesBuf[index1] * 16 + (int) SrcBuf[index2] - 48);
            ++index1;
            flag = false;
          }
          else
          {
            DesBuf[index1] = Convert.ToByte((int) SrcBuf[index2] - 48);
            flag = true;
          }
        }
        else if (flag)
        {
          ++index1;
          flag = false;
        }
      }
      if (flag)
      {
        if (SrcBuf[index2] >= (byte) 97 && SrcBuf[index2] <= (byte) 102)
        {
          DesBuf[index1] = Convert.ToByte((int) DesBuf[index1] * 16 + (int) SrcBuf[index2] - 97 + 10);
          ++index1;
        }
        else if (SrcBuf[index2] >= (byte) 65 && SrcBuf[index2] <= (byte) 70)
        {
          DesBuf[index1] = Convert.ToByte((int) DesBuf[index1] * 16 + (int) SrcBuf[index2] - 65 + 10);
          ++index1;
        }
        else if (SrcBuf[index2] >= (byte) 48 && SrcBuf[index2] <= (byte) 57)
        {
          DesBuf[index1] = Convert.ToByte((int) DesBuf[index1] * 16 + (int) SrcBuf[index2] - 48);
          ++index1;
        }
      }
      return index1;
    }

    public string Week()
    {
      return new string[7]
      {
        "星期日",
        "星期一",
        "星期二",
        "星期三",
        "星期四",
        "星期五",
        "星期六"
      }[Convert.ToInt32((object) DateTime.Now.DayOfWeek)];
    }

    public void GetSyncTime()
    {
      DateTime now = DateTime.Now;
      this.sSyncTime.Second = this.CharToHex(now.Second);
      this.sSyncTime.Minute = this.CharToHex(now.Minute);
      this.sSyncTime.Hour = this.CharToHex(now.Hour);
      this.sSyncTime.Day = this.CharToHex(now.Day);
      this.sSyncTime.Week = Convert.ToByte((object) DateTime.Now.DayOfWeek);
      this.sSyncTime.Month = this.CharToHex(now.Month);
      this.sSyncTime.Year = this.CharToHex(now.Year - 2000);
    }

    public void GetPlayControl()
    {
    }

    public void GetRecPar()
    {
      this.sRecPar.Width = Convert.ToByte(this.numericUpDown2.Value);
      this.sRecPar.Color = Convert.ToByte(this.comboBox8.SelectedIndex);
      this.sRecPar.WinXPos0 = Convert.ToUInt16(this.numericUpDown17.Value);
      this.sRecPar.WinYPos0 = Convert.ToUInt16(this.numericUpDown8.Value);
      this.sRecPar.WinXPos1 = Convert.ToUInt16(this.numericUpDown6.Value);
      this.sRecPar.WinYPos1 = Convert.ToUInt16(this.numericUpDown3.Value);
    }

    public void GetPolygonPar()
    {
      this.sPolygonPar.Width = Convert.ToByte(this.numericUpDown2.Value);
      this.sPolygonPar.Color = Convert.ToByte(this.comboBox8.SelectedIndex);
      this.sPolygonPar.DotNumber = (byte) 3;
      this.sPolygonPar.WinXPos0 = Convert.ToUInt16(this.numericUpDown17.Value);
      this.sPolygonPar.WinYPos0 = Convert.ToUInt16(this.numericUpDown8.Value);
      this.sPolygonPar.WinXPos1 = Convert.ToUInt16(this.numericUpDown6.Value);
      this.sPolygonPar.WinYPos1 = Convert.ToUInt16(this.numericUpDown3.Value);
      this.sPolygonPar.WinXPos2 = Convert.ToUInt16(this.numericUpDown21.Value);
      this.sPolygonPar.WinYPos2 = Convert.ToUInt16(this.numericUpDown20.Value);
    }

    public void GetRoundPar()
    {
      this.sRoundPar.Width = Convert.ToByte(this.numericUpDown2.Value);
      this.sRoundPar.Color = Convert.ToByte(this.comboBox8.SelectedIndex);
      this.sRoundPar.WinXPos0 = Convert.ToUInt16(this.numericUpDown17.Value);
      this.sRoundPar.WinYPos0 = Convert.ToUInt16(this.numericUpDown8.Value);
      this.sRoundPar.RDot = Convert.ToUInt16(this.numericUpDown6.Value);
    }

    public void GetArcPar()
    {
      this.sArcPar.Width = Convert.ToByte(this.numericUpDown2.Value);
      this.sArcPar.Color = Convert.ToByte(this.comboBox8.SelectedIndex);
      this.sArcPar.WinXPos0 = Convert.ToUInt16(this.numericUpDown17.Value);
      this.sArcPar.WinYPos0 = Convert.ToUInt16(this.numericUpDown8.Value);
      this.sArcPar.RDot = Convert.ToUInt16(this.numericUpDown6.Value);
      this.sArcPar.StarAngle = Convert.ToUInt16(this.numericUpDown21.Value);
      this.sArcPar.EndAngle = Convert.ToUInt16(this.numericUpDown20.Value);
    }

    public void GetDispText()
    {
      byte[] numArray = new byte[512];
      byte[] bytes = Encoding.Default.GetBytes(this.textBox9.Text);
      this.sDispText.XPos = Convert.ToUInt16(this.numericUpDown18.Value);
      this.sDispText.YPos = Convert.ToUInt16(this.numericUpDown7.Value);
      this.sDispText.Space = Convert.ToByte(this.numericUpDown22.Value);
      this.sDispText.Leng = Convert.ToByte(bytes.Length);
      this.sDispText.Font = Convert.ToByte(this.comboBox10.SelectedIndex);
      this.sDispText.Size = Convert.ToByte(this.numericUpDown19.Value);
      this.sDispText.Color = Convert.ToByte(this.comboBox12.SelectedIndex);
    }

    public void TextToHex()
    {
      this.sDispText.XPos = Convert.ToUInt16(this.numericUpDown18.Value);
      this.sDispText.YPos = Convert.ToUInt16(this.numericUpDown7.Value);
      this.sDispText.Space = Convert.ToByte(this.numericUpDown22.Value);
      this.sDispText.Leng = Convert.ToByte(this.textBox9.TextLength);
      this.sDispText.Font = Convert.ToByte(this.comboBox10.SelectedIndex);
      this.sDispText.Size = Convert.ToByte(this.numericUpDown19.Value);
      this.sDispText.Color = Convert.ToByte(this.comboBox12.SelectedIndex);
    }

    public void GetTextWinAtt()
    {
      byte[] numArray = new byte[512];
      byte[] bytes = Encoding.Default.GetBytes(this.textBox10.Text);
      this.sTextWinAtt.Type = Convert.ToByte(1);
      this.sTextWinAtt.No = Convert.ToByte(this.numericUpDown68.Value);
      this.sTextWinAtt.XPos = Convert.ToUInt16(this.numericUpDown55.Value);
      this.sTextWinAtt.YPos = Convert.ToUInt16(this.numericUpDown54.Value);
      this.sTextWinAtt.XDot = Convert.ToUInt16(this.numericUpDown59.Value);
      this.sTextWinAtt.YDot = Convert.ToUInt16(this.numericUpDown58.Value);
      this.sTextWinAtt.Rev1 = (ushort) 0;
      this.sTextWinAtt.PlayStunt = Convert.ToByte(this.comboBox28.SelectedIndex);
      this.sTextWinAtt.PlaySpeed = Convert.ToByte(this.numericUpDown52.Value);
      this.sTextWinAtt.PlayStay = Convert.ToByte(this.numericUpDown56.Value);
      this.sTextWinAtt.PlayIsClear = Convert.ToByte(this.checkBox1.Checked);
      this.sTextWinAtt.PageStyle = Convert.ToByte(this.comboBox23.SelectedIndex);
      this.sTextWinAtt.VStyle = Convert.ToByte(this.comboBox26.SelectedIndex + 1);
      this.sTextWinAtt.HStyle = Convert.ToByte(this.comboBox27.SelectedIndex + 1);
      this.sTextWinAtt.Rev2 = (byte) 0;
      this.sTextWinAtt.CodeLeng = Convert.ToUInt16(bytes.Length);
      this.sTextWinAtt.TextFont = Convert.ToByte(this.comboBox25.SelectedIndex);
      this.sTextWinAtt.TextSize = Convert.ToByte(this.numericUpDown57.Value);
      this.sTextWinAtt.TextColor = Convert.ToByte(this.comboBox24.SelectedIndex);
    }

    public void GetTimeWinAtt()
    {
      byte[] numArray = new byte[512];
      this.sTimeWinAtt.Type = Convert.ToByte(2);
      this.sTimeWinAtt.No = Convert.ToByte(this.numericUpDown69.Value);
      this.sTimeWinAtt.XPos = Convert.ToUInt16(this.numericUpDown63.Value);
      this.sTimeWinAtt.YPos = Convert.ToUInt16(this.numericUpDown62.Value);
      this.sTimeWinAtt.XDot = Convert.ToUInt16(this.numericUpDown61.Value);
      this.sTimeWinAtt.YDot = Convert.ToUInt16(this.numericUpDown60.Value);
      this.sTimeWinAtt.Rev1 = Convert.ToUInt16(0);
      this.sTimeWinAtt.PlayStunt = Convert.ToByte(this.comboBox36.SelectedIndex);
      this.sTimeWinAtt.PlaySpeed = Convert.ToByte(this.numericUpDown47.Value);
      this.sTimeWinAtt.PlayStay = Convert.ToByte(this.numericUpDown49.Value);
      this.sTimeWinAtt.PlayIsClear = Convert.ToByte(this.checkBox2.Checked);
      this.sTimeWinAtt.PageStyle = Convert.ToByte(this.comboBox32.SelectedIndex);
      this.sTimeWinAtt.VStyle = Convert.ToByte(this.comboBox29.SelectedIndex + 1);
      this.sTimeWinAtt.HStyle = Convert.ToByte(this.comboBox22.SelectedIndex + 1);
      this.sTimeWinAtt.TextFont = Convert.ToByte(this.comboBox31.SelectedIndex);
      this.sTimeWinAtt.TextSize = Convert.ToByte(this.numericUpDown53.Value);
      this.sTimeWinAtt.TextColor = Convert.ToByte(this.comboBox30.SelectedIndex);
      this.sTimeWinAtt.TimeOffset = Convert.ToUInt16(0);
      this.sTimeWinAtt.StyleLeng = Convert.ToByte(Encoding.Default.GetBytes(this.comboBox33.SelectedItem.ToString()).Length);
    }

    public byte GetOptType()
    {
      switch (this.tabControl1.SelectedIndex)
      {
        case 0:
          if (this.comboBox3.SelectedIndex == 1 || this.comboBox3.SelectedIndex == 2)
            return 0;
          if (this.comboBox3.SelectedIndex == 3)
            return 1;
          if (this.comboBox3.SelectedIndex == 0)
            return 2;
          if (this.comboBox3.SelectedIndex == 4)
            return 5;
          if (this.comboBox3.SelectedIndex == 5)
            return byte.MaxValue;
          return this.comboBox3.SelectedIndex == 6 ? (byte) 253 : (byte) 254;
        case 1:
          return this.checkBox21.Checked ? (byte) 4 : (byte) 3;
        case 2:
          if (this.comboBox4.SelectedIndex == 0)
            return 16;
          if (this.comboBox4.SelectedIndex == 1)
            return 17;
          if (this.comboBox4.SelectedIndex == 2)
            return 25;
          return this.comboBox4.SelectedIndex == 3 ? (byte) 28 : (byte) 254;
        case 3:
          return 18;
        case 4:
          if (this.comboBox9.SelectedIndex == 0)
            return 19;
          if (this.comboBox9.SelectedIndex == 1)
            return 20;
          if (this.comboBox9.SelectedIndex == 2)
            return 21;
          return this.comboBox9.SelectedIndex == 3 ? (byte) 22 : (byte) 254;
        case 5:
          return 23;
        case 6:
          return this.comboBox21.SelectedIndex == 2 ? (byte) 7 : (byte) 6;
        case 7:
          return 26;
        case 8:
          return 27;
        case 9:
          return 9;
        default:
          return 254;
      }
    }

    public FormMain()
    {
      this.InitializeComponent();
    }

    private void groupBox5_Enter(object sender, EventArgs e)
    {
    }

    private void label12_Click(object sender, EventArgs e)
    {
    }

    private void label6_Click(object sender, EventArgs e)
    {
    }

    private void label11_Click(object sender, EventArgs e)
    {
    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {
    }

    private void button5_Click(object sender, EventArgs e)
    {
      switch (this.tabControl1.SelectedIndex)
      {
        case 0:
          this.textBox6.Text = "08";
          this.textBox7.Text = "10";
          this.textBox15.Text = "18";
          this.textBox14.Text = "20";
          this.radioButton1.Checked = true;
          break;
        case 1:
          this.numericUpDown4.Value = new Decimal(8);
          break;
        case 2:
          this.numericUpDown10.Value = new Decimal(8);
          this.numericUpDown9.Value = new Decimal(10);
          this.numericUpDown12.Value = new Decimal(24);
          this.numericUpDown11.Value = new Decimal(16);
          this.comboBox5.SelectedIndex = 0;
          break;
        case 3:
          this.comboBox6.SelectedIndex = 1;
          this.numericUpDown1.Value = new Decimal(1);
          this.numericUpDown14.Value = new Decimal(8);
          this.numericUpDown13.Value = new Decimal(16);
          this.numericUpDown16.Value = new Decimal(8);
          this.numericUpDown15.Value = new Decimal(24);
          break;
        case 4:
          this.comboBox8.SelectedIndex = 1;
          this.numericUpDown2.Value = new Decimal(1);
          this.numericUpDown17.Value = new Decimal(8);
          this.numericUpDown8.Value = new Decimal(8);
          this.numericUpDown6.Value = new Decimal(24);
          this.numericUpDown3.Value = new Decimal(8);
          this.numericUpDown21.Value = new Decimal(16);
          this.numericUpDown20.Value = new Decimal(16);
          break;
        case 5:
          this.numericUpDown18.Value = new Decimal(8);
          this.numericUpDown7.Value = new Decimal(6);
          this.numericUpDown19.Value = new Decimal(16);
          this.numericUpDown22.Value = new Decimal(0);
          this.comboBox10.SelectedIndex = 1;
          this.comboBox12.SelectedIndex = 1;
          this.textBox9.Text = "Welcom";
          break;
        case 7:
          this.numericUpDown55.Value = new Decimal(0);
          this.numericUpDown54.Value = new Decimal(0);
          this.numericUpDown59.Value = new Decimal(64);
          this.numericUpDown58.Value = new Decimal(32);
          this.numericUpDown52.Value = new Decimal(6);
          this.numericUpDown56.Value = new Decimal(1);
          this.numericUpDown57.Value = new Decimal(16);
          this.comboBox23.SelectedIndex = 0;
          this.comboBox26.SelectedIndex = 0;
          this.comboBox27.SelectedIndex = 0;
          this.comboBox28.SelectedIndex = 7;
          this.comboBox25.SelectedIndex = 1;
          this.comboBox24.SelectedIndex = 1;
          this.textBox10.Text = "Text Window";
          break;
        case 8:
          this.numericUpDown63.Value = new Decimal(0);
          this.numericUpDown62.Value = new Decimal(0);
          this.numericUpDown61.Value = new Decimal(64);
          this.numericUpDown60.Value = new Decimal(16);
          this.numericUpDown53.Value = new Decimal(16);
          this.comboBox32.SelectedIndex = 0;
          this.comboBox29.SelectedIndex = 0;
          this.comboBox22.SelectedIndex = 0;
          this.comboBox33.SelectedIndex = 0;
          this.comboBox31.SelectedIndex = 1;
          this.comboBox30.SelectedIndex = 1;
          this.textBox11.Text = "00:00";
          break;
        case 9:
          this.textBox12.Text = "你好，欢迎光临";
          break;
      }
    }

    public static byte[] StructToBytes(object structObj, int size)
    {
      byte[] destination = new byte[size];
      IntPtr num = Marshal.AllocHGlobal(size);
      Marshal.StructureToPtr(structObj, num, false);
      Marshal.Copy(num, destination, 0, size);
      Marshal.FreeHGlobal(num);
      return destination;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.label32.Text = "ab";
    }

    private void label31_Click(object sender, EventArgs e)
    {
    }

    private void numericUpDown7_ValueChanged(object sender, EventArgs e)
    {
    }

    private void tabPage9_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.textBox2.Text = " ";
      this.textBox3.Text = "0";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.textBox4.Text = "0";
      this.textBox5.Text = " ";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      byte[] numArray = new byte[512];
      byte[] DesBuf = new byte[513];
      int num1 = 0;
      byte optType = this.GetOptType();
      DesBuf[0] = optType;
      this.groupBox1.Text = "数 据";
      this.textBox5.Text = "";
      this.textBox2.Text = "";
      switch (optType)
      {
        case 0:
          this.GetPowerSwitch();
          FormMain.StructToBytes((object) this.sPowerSwitch, Marshal.SizeOf((object) this.sPowerSwitch)).CopyTo((Array) DesBuf, 1);
          num1 = 2;
          break;
        case 1:
          this.GetPowerSwitch();
          FormMain.StructToBytes((object) this.sPowerSwitch, Marshal.SizeOf((object) this.sPowerSwitch)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sPowerSwitch);
          break;
        case 2:
          this.GetSyncTime();
          FormMain.StructToBytes((object) this.sSyncTime, Marshal.SizeOf((object) this.sSyncTime)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sSyncTime);
          break;
        case 3:
          numArray[0] = Convert.ToByte(this.numericUpDown4.Value);
          DesBuf[1] = Convert.ToByte(this.numericUpDown4.Value);
          num1 = 2;
          break;
        case 4:
          for (int index = 0; index < 24; ++index)
            numArray[index] = Convert.ToByte(this.dataGridView1.Rows[0].Cells[index].Value);
          numArray.CopyTo((Array) DesBuf, 1);
          num1 = 25;
          break;
        case 5:
          if (this.radioButton1.Checked)
            numArray[0] = (byte) 1;
          else if (this.radioButton2.Checked)
            numArray[0] = (byte) 2;
          else if (this.radioButton3.Checked)
            numArray[0] = (byte) 3;
          numArray[1] = Convert.ToByte(this.numericUpDown66.Value);
          numArray.CopyTo((Array) DesBuf, 1);
          num1 = 3;
          break;
        case 6:
          numArray[1] = this.comboBox21.SelectedIndex != 0 ? (this.comboBox21.SelectedIndex != 1 ? (byte) 3 : (byte) 0) : (byte) 1;
          numArray[0] = Convert.ToByte(this.numericUpDown48.Value);
          numArray.CopyTo((Array) DesBuf, 1);
          num1 = 3;
          break;
        case 7:
          numArray[0] = Convert.ToByte(this.numericUpDown48.Value);
          numArray.CopyTo((Array) DesBuf, 1);
          num1 = 2;
          break;
        case 9:
          if (this.comboBox35.SelectedIndex == 0)
          {
            this.sSyncCommu.Cmd = (byte) 1;
            this.sSyncCommu.Par = (byte) 0;
          }
          else
          {
            this.sSyncCommu.Cmd = (byte) 1;
            this.sSyncCommu.Par = (byte) 0;
          }
          this.sSyncCommu.Leng = Convert.ToUInt16(Encoding.Default.GetBytes(this.textBox12.Text).Length + 2);
          this.sSyncCommu.Leng = Convert.ToUInt16((int) this.sSyncCommu.Leng / 256 + (int) this.sSyncCommu.Leng % 256 * 256);
          FormMain.StructToBytes((object) this.sSyncCommu, Marshal.SizeOf((object) this.sSyncCommu)).CopyTo((Array) DesBuf, 1);
          byte[] bytes1 = Encoding.Default.GetBytes(this.textBox12.Text);
          bytes1.CopyTo((Array) DesBuf, 1 + Marshal.SizeOf((object) this.sSyncCommu));
          num1 = 1 + Marshal.SizeOf((object) this.sSyncCommu) + bytes1.Length;
          break;
        case 16:
          num1 = 1;
          break;
        case 17:
          numArray[0] = Convert.ToByte(this.comboBox5.SelectedIndex);
          numArray.CopyTo((Array) DesBuf, 1);
          num1 = 2;
          break;
        case 18:
          if (this.comboBox7.SelectedIndex == 0)
          {
            this.numericUpDown16.Value = this.numericUpDown14.Value;
            this.numericUpDown15.Value = this.numericUpDown13.Value;
          }
          this.sDotLine.Width = Convert.ToByte(this.numericUpDown1.Value);
          this.sDotLine.Color = Convert.ToByte(this.comboBox6.SelectedIndex);
          this.sDotLine.WinXPos0 = Convert.ToUInt16(this.numericUpDown14.Value);
          this.sDotLine.WinYPos0 = Convert.ToUInt16(this.numericUpDown13.Value);
          this.sDotLine.WinXPos1 = Convert.ToUInt16(this.numericUpDown16.Value);
          this.sDotLine.WinYPos1 = Convert.ToUInt16(this.numericUpDown15.Value);
          FormMain.StructToBytes((object) this.sDotLine, Marshal.SizeOf((object) this.sDotLine)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sDotLine);
          break;
        case 19:
          this.GetRecPar();
          FormMain.StructToBytes((object) this.sRecPar, Marshal.SizeOf((object) this.sRecPar)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sRecPar);
          break;
        case 20:
          this.GetPolygonPar();
          FormMain.StructToBytes((object) this.sPolygonPar, Marshal.SizeOf((object) this.sPolygonPar)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sPolygonPar);
          break;
        case 21:
          this.GetRoundPar();
          FormMain.StructToBytes((object) this.sRoundPar, Marshal.SizeOf((object) this.sRoundPar)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sRoundPar);
          break;
        case 22:
          this.GetArcPar();
          FormMain.StructToBytes((object) this.sArcPar, Marshal.SizeOf((object) this.sArcPar)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sArcPar);
          break;
        case 23:
          this.GetDispText();
          FormMain.StructToBytes((object) this.sDispText, Marshal.SizeOf((object) this.sDispText)).CopyTo((Array) DesBuf, 1);
          int num2 = 1 + Marshal.SizeOf((object) this.sDispText);
          byte[] bytes2 = Encoding.Default.GetBytes(this.textBox9.Text);
          bytes2.CopyTo((Array) DesBuf, 1 + Marshal.SizeOf((object) this.sDispText));
          num1 = num2 + bytes2.Length;
          break;
        case 25:
          this.sPos2.WinXPos0 = Convert.ToUInt16(this.numericUpDown10.Value);
          this.sPos2.WinYPos0 = Convert.ToUInt16(this.numericUpDown9.Value);
          this.sPos2.WinXPos1 = Convert.ToUInt16(this.numericUpDown12.Value);
          this.sPos2.WinYPos1 = Convert.ToUInt16(this.numericUpDown11.Value);
          FormMain.StructToBytes((object) this.sPos2, Marshal.SizeOf((object) this.sPos2)).CopyTo((Array) DesBuf, 1);
          num1 = 1 + Marshal.SizeOf((object) this.sPos2);
          break;
        case 26:
          this.GetTextWinAtt();
          FormMain.StructToBytes((object) this.sTextWinAtt, Marshal.SizeOf((object) this.sTextWinAtt)).CopyTo((Array) DesBuf, 1);
          int num3 = 1 + Marshal.SizeOf((object) this.sTextWinAtt);
          byte[] bytes3 = Encoding.Default.GetBytes(this.textBox10.Text);
          bytes3.CopyTo((Array) DesBuf, 1 + Marshal.SizeOf((object) this.sTextWinAtt));
          num1 = num3 + bytes3.Length;
          break;
        case 27:
          this.GetTimeWinAtt();
          FormMain.StructToBytes((object) this.sTimeWinAtt, Marshal.SizeOf((object) this.sTimeWinAtt)).CopyTo((Array) DesBuf, 1);
          int num4 = 1 + Marshal.SizeOf((object) this.sTimeWinAtt);
          byte[] bytes4 = Encoding.Default.GetBytes(this.comboBox33.SelectedItem.ToString());
          bytes4.CopyTo((Array) DesBuf, 1 + Marshal.SizeOf((object) this.sTimeWinAtt));
          num1 = num4 + bytes4.Length;
          break;
        case 28:
          numArray[0] = Convert.ToByte(this.numericUpDown70.Value);
          numArray.CopyTo((Array) DesBuf, 1);
          num1 = 2;
          break;
        case 253:
          byte[] bytes5 = Encoding.Default.GetBytes(this.textBox19.Text);
          num1 = this.BufCharToHex(bytes5, bytes5.Length, DesBuf);
          break;
        case byte.MaxValue:
          num1 = 1;
          break;
      }
      for (int index = 0; index < num1; ++index)
      {
        if (DesBuf[index] > (byte) 15)
        {
          TextBox textBox2 = this.textBox2;
          textBox2.Text = textBox2.Text + "0x" + Convert.ToString(DesBuf[index], 16) + (object) ',';
        }
        else
        {
          TextBox textBox2 = this.textBox2;
          textBox2.Text = textBox2.Text + "0x0" + Convert.ToString(DesBuf[index], 16) + (object) ',';
        }
      }
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
      this.groupBox1.Text = "发 送";
      byte[] numArray1 = new byte[512];
      byte[] numArray2 = new byte[768];
      byte[] numArray3 = new byte[1024];
      int Length = 0;
      byte optType = this.GetOptType();
      this.cRxNumber = (byte) 0;
      numArray2[0] = optType;
      this.groupBox1.Text = "数 据";
      switch (optType)
      {
        case 0:
          this.GetPowerSwitch();
          FormMain.StructToBytes((object) this.sPowerSwitch, Marshal.SizeOf((object) this.sPowerSwitch)).CopyTo((Array) numArray2, 1);
          Length = 2;
          break;
        case 1:
          this.GetPowerSwitch();
          FormMain.StructToBytes((object) this.sPowerSwitch, Marshal.SizeOf((object) this.sPowerSwitch)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sPowerSwitch);
          break;
        case 2:
          this.GetSyncTime();
          FormMain.StructToBytes((object) this.sSyncTime, Marshal.SizeOf((object) this.sSyncTime)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sSyncTime);
          break;
        case 3:
          numArray1[0] = Convert.ToByte(this.numericUpDown4.Value);
          numArray2[1] = Convert.ToByte(this.numericUpDown4.Value);
          Length = 2;
          break;
        case 4:
          for (int index = 0; index < 24; ++index)
            numArray1[index] = Convert.ToByte(this.dataGridView1.Rows[0].Cells[index].Value);
          numArray1.CopyTo((Array) numArray2, 1);
          Length = 25;
          break;
        case 5:
          if (this.radioButton1.Checked)
            numArray1[0] = (byte) 1;
          else if (this.radioButton2.Checked)
            numArray1[0] = (byte) 2;
          else if (this.radioButton3.Checked)
            numArray1[0] = (byte) 3;
          numArray1[1] = Convert.ToByte(this.numericUpDown66.Value);
          numArray1.CopyTo((Array) numArray2, 1);
          Length = 3;
          break;
        case 6:
          numArray1[1] = this.comboBox21.SelectedIndex != 0 ? (this.comboBox21.SelectedIndex != 1 ? (byte) 3 : (byte) 0) : (byte) 1;
          numArray1[0] = Convert.ToByte(this.numericUpDown48.Value);
          numArray1.CopyTo((Array) numArray2, 1);
          Length = 3;
          break;
        case 7:
          numArray1[0] = Convert.ToByte(this.numericUpDown48.Value);
          numArray1.CopyTo((Array) numArray2, 1);
          Length = 2;
          break;
        case 9:
          if (this.comboBox35.SelectedIndex == 0)
          {
            this.sSyncCommu.Cmd = (byte) 1;
            this.sSyncCommu.Par = (byte) 0;
          }
          else
          {
            this.sSyncCommu.Cmd = (byte) 1;
            this.sSyncCommu.Par = (byte) 0;
          }
          this.sSyncCommu.Leng = Convert.ToUInt16(Encoding.Default.GetBytes(this.textBox12.Text).Length + 2);
          this.sSyncCommu.Leng = Convert.ToUInt16((int) this.sSyncCommu.Leng / 256 + (int) this.sSyncCommu.Leng % 256 * 256);
          FormMain.StructToBytes((object) this.sSyncCommu, Marshal.SizeOf((object) this.sSyncCommu)).CopyTo((Array) numArray2, 1);
          byte[] bytes1 = Encoding.Default.GetBytes(this.textBox12.Text);
          bytes1.CopyTo((Array) numArray2, 1 + Marshal.SizeOf((object) this.sSyncCommu));
          Length = 1 + Marshal.SizeOf((object) this.sSyncCommu) + bytes1.Length;
          break;
        case 16:
          Length = 1;
          break;
        case 17:
          numArray1[0] = Convert.ToByte(this.comboBox5.SelectedIndex);
          numArray1.CopyTo((Array) numArray2, 1);
          Length = 2;
          break;
        case 18:
          if (this.comboBox7.SelectedIndex == 0)
          {
            this.numericUpDown16.Value = this.numericUpDown14.Value;
            this.numericUpDown15.Value = this.numericUpDown13.Value;
          }
          this.sDotLine.Width = Convert.ToByte(this.numericUpDown1.Value);
          this.sDotLine.Color = Convert.ToByte(this.comboBox6.SelectedIndex);
          this.sDotLine.WinXPos0 = Convert.ToUInt16(this.numericUpDown14.Value);
          this.sDotLine.WinYPos0 = Convert.ToUInt16(this.numericUpDown13.Value);
          this.sDotLine.WinXPos1 = Convert.ToUInt16(this.numericUpDown16.Value);
          this.sDotLine.WinYPos1 = Convert.ToUInt16(this.numericUpDown15.Value);
          FormMain.StructToBytes((object) this.sDotLine, Marshal.SizeOf((object) this.sDotLine)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sDotLine);
          break;
        case 19:
          this.GetRecPar();
          FormMain.StructToBytes((object) this.sRecPar, Marshal.SizeOf((object) this.sRecPar)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sRecPar);
          break;
        case 20:
          this.GetPolygonPar();
          FormMain.StructToBytes((object) this.sPolygonPar, Marshal.SizeOf((object) this.sPolygonPar)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sPolygonPar);
          break;
        case 21:
          this.GetRoundPar();
          FormMain.StructToBytes((object) this.sRoundPar, Marshal.SizeOf((object) this.sRoundPar)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sRoundPar);
          break;
        case 22:
          this.GetArcPar();
          FormMain.StructToBytes((object) this.sArcPar, Marshal.SizeOf((object) this.sArcPar)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sArcPar);
          break;
        case 23:
          this.GetDispText();
          FormMain.StructToBytes((object) this.sDispText, Marshal.SizeOf((object) this.sDispText)).CopyTo((Array) numArray2, 1);
          int num1 = 1 + Marshal.SizeOf((object) this.sDispText);
          byte[] bytes2 = Encoding.Default.GetBytes(this.textBox9.Text);
          bytes2.CopyTo((Array) numArray2, 1 + Marshal.SizeOf((object) this.sDispText));
          Length = num1 + bytes2.Length;
          break;
        case 25:
          this.sPos2.WinXPos0 = Convert.ToUInt16(this.numericUpDown10.Value);
          this.sPos2.WinYPos0 = Convert.ToUInt16(this.numericUpDown9.Value);
          this.sPos2.WinXPos1 = Convert.ToUInt16(this.numericUpDown12.Value);
          this.sPos2.WinYPos1 = Convert.ToUInt16(this.numericUpDown11.Value);
          FormMain.StructToBytes((object) this.sPos2, Marshal.SizeOf((object) this.sPos2)).CopyTo((Array) numArray2, 1);
          Length = 1 + Marshal.SizeOf((object) this.sPos2);
          break;
        case 26:
          this.GetTextWinAtt();
          FormMain.StructToBytes((object) this.sTextWinAtt, Marshal.SizeOf((object) this.sTextWinAtt)).CopyTo((Array) numArray2, 1);
          int num2 = 1 + Marshal.SizeOf((object) this.sTextWinAtt);
          byte[] bytes3 = Encoding.Default.GetBytes(this.textBox10.Text);
          bytes3.CopyTo((Array) numArray2, 1 + Marshal.SizeOf((object) this.sTextWinAtt));
          Length = num2 + bytes3.Length;
          break;
        case 27:
          this.GetTimeWinAtt();
          FormMain.StructToBytes((object) this.sTimeWinAtt, Marshal.SizeOf((object) this.sTimeWinAtt)).CopyTo((Array) numArray2, 1);
          int num3 = 1 + Marshal.SizeOf((object) this.sTimeWinAtt);
          byte[] bytes4 = Encoding.Default.GetBytes(this.comboBox33.SelectedItem.ToString());
          bytes4.CopyTo((Array) numArray2, 1 + Marshal.SizeOf((object) this.sTimeWinAtt));
          Length = num3 + bytes4.Length;
          break;
        case 28:
          numArray1[0] = Convert.ToByte(this.numericUpDown70.Value);
          numArray1.CopyTo((Array) numArray2, 1);
          Length = 2;
          break;
        case 253:
          byte[] bytes5 = Encoding.Default.GetBytes(this.textBox19.Text);
          Length = this.BufCharToHex(bytes5, bytes5.Length, numArray2);
          break;
        case byte.MaxValue:
          Length = 1;
          break;
      }
      int commuPack = ProtocolDevIo.CreateCommuPack(numArray3, numArray2, FormMain.sCommuAtt.ScreenId, FormMain.sCommuAtt.ComNo, Convert.ToByte(Length));
      this.textBox2.Text = "";
      for (int index = 0; index < commuPack; ++index)
      {
        if (numArray3[index] > (byte) 15)
        {
          TextBox textBox2 = this.textBox2;
          textBox2.Text = textBox2.Text + "0x" + Convert.ToString(numArray3[index], 16) + (object) ',';
        }
        else
        {
          TextBox textBox2 = this.textBox2;
          textBox2.Text = textBox2.Text + "0x0" + Convert.ToString(numArray3[index], 16) + (object) ',';
        }
      }
      if (this.comboBox17.SelectedIndex == 0)
      {
        if (!this.serialPort1.IsOpen)
        {
          this.textBox3.Text = "0";
          this.textBox2.Text = "";
          this.textBox13.Text = "请先打开串口";
        }
        else
        {
          this.serialPort1.Write(numArray3, 0, commuPack);
          this.textBox3.Text = Convert.ToString(commuPack);
          FormMain.DelayMs(1000);
          if (this.cRxNumber > (byte) 7)
          {
            if (ProtocolDevIo.CheckCommuPack(this.pRxBuf, (int) this.cRxNumber))
            {
              if (this.pRxBuf[4] == (byte) 0)
                this.textBox13.Text = "发送成功";
              else
                this.textBox13.Text = "应用数据异常";
            }
            else
            {
              this.textBox13.Text = "终端无返回";
              this.textBox4.Text = "0";
              this.textBox5.Text = "";
            }
          }
          else
          {
            this.textBox13.Text = "终端无返回";
            this.textBox4.Text = "0";
            this.textBox5.Text = "";
          }
        }
      }
      else if (this.comboBox17.SelectedIndex == 1)
      {
        if (this.button8.Text == "断开")
        {
          this.textBox3.Text = Convert.ToString(commuPack);
          switch (CommuUdp.TxAppPack(numArray2, Length))
          {
            case -1:
              this.textBox13.Text = "应用数据异常";
              this.textBox4.Text = "8";
              this.cRxNumber = (byte) 8;
              break;
            case 0:
              this.textBox13.Text = "发送成功";
              this.textBox4.Text = "8";
              this.cRxNumber = (byte) 8;
              break;
            case 1:
              this.textBox13.Text = "终端未响应";
              this.textBox4.Text = "0";
              this.cRxNumber = (byte) 0;
              break;
          }
          this.textBox5.Text = "";
          for (int index = 0; index < (int) this.cRxNumber; ++index)
          {
            if (this.pRxBuf[index] > (byte) 15)
            {
              TextBox textBox5 = this.textBox5;
              textBox5.Text = textBox5.Text + "0x" + Convert.ToString(CommuUdp.EthentRxBuf[index], 16) + (object) ',';
            }
            else
            {
              TextBox textBox5 = this.textBox5;
              textBox5.Text = textBox5.Text + "0x0" + Convert.ToString(CommuUdp.EthentRxBuf[index], 16) + (object) ',';
            }
          }
        }
        else
        {
          this.textBox13.Text = "设备未连接";
          this.textBox3.Text = "0";
          this.textBox4.Text = "0";
          this.textBox5.Text = "";
        }
      }
      else if (this.button8.Text == "断开")
      {
        this.textBox3.Text = Convert.ToString(commuPack);
        switch (CommuTcp.TxAppPack(numArray2, Length))
        {
          case -1:
            this.textBox13.Text = "应用数据异常";
            this.textBox4.Text = "8";
            this.cRxNumber = (byte) 8;
            break;
          case 0:
            this.textBox13.Text = "发送成功";
            this.textBox4.Text = "8";
            this.cRxNumber = (byte) 8;
            break;
          case 1:
            this.textBox13.Text = "终端未响应";
            this.textBox4.Text = "0";
            this.cRxNumber = (byte) 8;
            break;
        }
        this.textBox5.Text = "";
        for (int index = 0; index < (int) this.cRxNumber; ++index)
        {
          if (this.pRxBuf[index] > (byte) 15)
          {
            TextBox textBox5 = this.textBox5;
            textBox5.Text = textBox5.Text + "0x" + Convert.ToString(CommuTcp.EthentRxBuf[index], 16) + (object) ',';
          }
          else
          {
            TextBox textBox5 = this.textBox5;
            textBox5.Text = textBox5.Text + "0x0" + Convert.ToString(CommuTcp.EthentRxBuf[index], 16) + (object) ',';
          }
        }
      }
      else
      {
        this.textBox13.Text = "设备未连接";
        this.textBox3.Text = "0";
        this.textBox4.Text = "0";
        this.textBox5.Text = "";
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      for (int index = 0; index < 24; ++index)
      {
        this.dataGridView1.Rows[0].Cells[index].Value = (object) (index / 2 + 1);
        this.dataGridView1.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
      this.comboBox2.Items.AddRange((object[]) SerialPort.GetPortNames());
      this.sSyncCommu.Head = (byte) 253;
      FormMain.sCommuAtt.ScreenId = Convert.ToByte(this.numericUpDown5.Value);
      FormMain.sCommuAtt.Port = Convert.ToInt32(this.textBox1.Text);
      FormMain.sCommuAtt.IP0 = Convert.ToInt32(this.textBox8.Text);
      FormMain.sCommuAtt.IP1 = Convert.ToInt32(this.textBox16.Text);
      FormMain.sCommuAtt.IP2 = Convert.ToInt32(this.textBox18.Text);
      FormMain.sCommuAtt.IP3 = Convert.ToInt32(this.textBox17.Text);
      FormMain.sCommuAtt.BaudRate = this.comboBox1.SelectedIndex != 0 ? (this.comboBox1.SelectedIndex != 1 ? 115200 : 38400) : 9600;
      FormMain.sCommuAtt.ComNo = (byte) 0;
      this.cRxNumber = (byte) 0;
    }

    private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox35.SelectedIndex == 0)
        this.textBox12.Visible = true;
      else if (this.comboBox35.SelectedIndex == 1)
      {
        this.textBox12.Visible = false;
      }
      else
      {
        int selectedIndex = this.comboBox35.SelectedIndex;
      }
    }

    private void textBox12_TextChanged(object sender, EventArgs e)
    {
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox3.SelectedIndex == 3)
      {
        this.panel3.Visible = false;
        this.label1.Visible = true;
        this.label11.Visible = true;
        this.textBox6.Visible = true;
        this.textBox7.Visible = true;
        this.textBox14.Visible = true;
        this.textBox15.Visible = true;
        this.label113.Visible = true;
        this.label79.Visible = true;
        this.textBox19.Visible = false;
      }
      else if (this.comboBox3.SelectedIndex == 4)
      {
        this.panel3.Visible = true;
        this.label1.Visible = false;
        this.label11.Visible = false;
        this.textBox6.Visible = false;
        this.textBox7.Visible = false;
        this.textBox14.Visible = false;
        this.textBox15.Visible = false;
        this.label113.Visible = false;
        this.label79.Visible = false;
        this.textBox19.Visible = false;
      }
      else if (this.comboBox3.SelectedIndex == 6)
      {
        this.panel3.Visible = false;
        this.label1.Visible = false;
        this.label11.Visible = false;
        this.textBox6.Visible = false;
        this.textBox7.Visible = false;
        this.textBox14.Visible = false;
        this.textBox15.Visible = false;
        this.label113.Visible = false;
        this.label79.Visible = false;
        this.textBox19.Visible = true;
      }
      else
      {
        this.panel3.Visible = false;
        this.label1.Visible = false;
        this.label11.Visible = false;
        this.textBox6.Visible = false;
        this.textBox7.Visible = false;
        this.textBox14.Visible = false;
        this.textBox15.Visible = false;
        this.label113.Visible = false;
        this.label79.Visible = false;
        this.textBox19.Visible = false;
      }
    }

    private void checkBox21_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox21.Checked)
      {
        this.dataGridView1.Visible = true;
        this.label2.Visible = false;
        this.numericUpDown4.Visible = false;
      }
      else
      {
        this.dataGridView1.Visible = false;
        this.label2.Visible = true;
        this.numericUpDown4.Visible = true;
      }
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox4.SelectedIndex == 0)
      {
        this.label20.Visible = false;
        this.comboBox5.Visible = false;
        this.groupBox4.Visible = false;
        this.groupBox6.Visible = false;
        this.label149.Visible = false;
        this.numericUpDown70.Visible = false;
      }
      else if (this.comboBox4.SelectedIndex == 1)
      {
        this.label20.Visible = true;
        this.comboBox5.Visible = true;
        this.groupBox4.Visible = false;
        this.groupBox6.Visible = false;
        this.label149.Visible = false;
        this.numericUpDown70.Visible = false;
      }
      else if (this.comboBox4.SelectedIndex == 2)
      {
        this.label20.Visible = false;
        this.comboBox5.Visible = false;
        this.groupBox4.Visible = true;
        this.groupBox6.Visible = true;
        this.label149.Visible = false;
        this.numericUpDown70.Visible = false;
      }
      else
      {
        this.label20.Visible = false;
        this.comboBox5.Visible = false;
        this.groupBox4.Visible = false;
        this.groupBox6.Visible = false;
        this.label149.Visible = true;
        this.numericUpDown70.Visible = true;
      }
    }

    private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox9.SelectedIndex == 0)
      {
        this.label30.Text = "坐标 X2";
        this.label29.Text = "坐标 Y2";
        this.label29.Visible = true;
        this.numericUpDown3.Visible = true;
        this.label36.Visible = false;
        this.label37.Visible = false;
        this.numericUpDown21.Visible = false;
        this.numericUpDown20.Visible = false;
      }
      else if (this.comboBox9.SelectedIndex == 1)
      {
        this.label30.Text = "坐标 X2";
        this.label29.Text = "坐标 Y2";
        this.label29.Visible = true;
        this.numericUpDown3.Visible = true;
        this.label36.Visible = true;
        this.label37.Visible = true;
        this.numericUpDown21.Visible = true;
        this.numericUpDown20.Visible = true;
      }
      else if (this.comboBox9.SelectedIndex == 2)
      {
        this.label30.Text = "半径(R)";
        this.label29.Visible = false;
        this.numericUpDown3.Visible = false;
        this.label36.Visible = false;
        this.label37.Visible = false;
        this.numericUpDown21.Visible = false;
        this.numericUpDown20.Visible = false;
      }
      else
      {
        this.label30.Text = "半径(R)";
        this.label29.Visible = false;
        this.numericUpDown3.Visible = false;
        this.label36.Text = "起始角度";
        this.label37.Text = "结束角度";
        this.label36.Visible = true;
        this.label37.Visible = true;
        this.numericUpDown21.Visible = true;
        this.numericUpDown20.Visible = true;
      }
    }

    private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox17.SelectedIndex == 0)
      {
        this.panel1.Visible = true;
        this.panel2.Visible = false;
      }
      else
      {
        this.panel2.Visible = true;
        this.panel1.Visible = false;
      }
      FormMain.sCommuAtt.Type = (int) Convert.ToByte(this.comboBox17.SelectedIndex);
    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox7.SelectedIndex == 0)
        this.groupBox8.Visible = false;
      else
        this.groupBox8.Visible = true;
    }

    private void tabPage6_Click(object sender, EventArgs e)
    {
    }

    private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      int i = (int) this.cRxNumber;
      for (this.cRxNumber += Convert.ToByte(this.serialPort1.BytesToRead); i < (int) this.cRxNumber; ++i)
        this.pRxBuf[i] = Convert.ToByte(this.serialPort1.ReadByte());
      this.textBox1.Invoke((Delegate) (() =>
      {
        this.textBox5.Text = "";
        for (i = 0; i < (int) this.cRxNumber; ++i)
        {
          if (this.pRxBuf[i] > (byte) 15)
          {
            TextBox textBox5 = this.textBox5;
            textBox5.Text = textBox5.Text + "0x" + Convert.ToString(this.pRxBuf[i], 16) + (object) ',';
          }
          else
          {
            TextBox textBox5 = this.textBox5;
            textBox5.Text = textBox5.Text + "0x0" + Convert.ToString(this.pRxBuf[i], 16) + (object) ',';
          }
        }
        this.textBox4.Text = Convert.ToString(this.cRxNumber);
      }));
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if (this.button7.Text == "打开")
      {
        this.serialPort1.Close();
        if (this.comboBox2.SelectedItem == null)
        {
          this.textBox13.Text = "无串口";
        }
        else
        {
          this.serialPort1.PortName = this.comboBox2.SelectedItem.ToString();
          this.serialPort1.BaudRate = this.comboBox1.SelectedIndex != 0 ? (this.comboBox1.SelectedIndex != 1 ? 115200 : 38400) : 9600;
          this.serialPort1.DataBits = 8;
          try
          {
            this.serialPort1.Open();
            this.textBox13.Text = "打开成功";
            this.button7.Text = "关闭";
          }
          catch
          {
            this.textBox13.Text = "该串口已被打开";
          }
        }
      }
      else
      {
        this.serialPort1.Close();
        this.textBox13.Text = "关闭完成";
        this.button7.Text = "打开";
      }
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void label114_Click(object sender, EventArgs e)
    {
    }

    private void label115_Click(object sender, EventArgs e)
    {
    }

    private void label116_Click(object sender, EventArgs e)
    {
    }

    private void label117_Click(object sender, EventArgs e)
    {
    }

    private void label118_Click(object sender, EventArgs e)
    {
    }

    private void label119_Click(object sender, EventArgs e)
    {
    }

    private void label120_Click(object sender, EventArgs e)
    {
    }

    private void label121_Click(object sender, EventArgs e)
    {
    }

    private void label122_Click(object sender, EventArgs e)
    {
    }

    private void label123_Click(object sender, EventArgs e)
    {
    }

    private void label132_Click(object sender, EventArgs e)
    {
    }

    private void label131_Click(object sender, EventArgs e)
    {
    }

    private void label130_Click(object sender, EventArgs e)
    {
    }

    private void label129_Click(object sender, EventArgs e)
    {
    }

    private void label128_Click(object sender, EventArgs e)
    {
    }

    private void label127_Click(object sender, EventArgs e)
    {
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (this.comboBox17.SelectedIndex == 1)
      {
        if (this.button8.Text == "连接")
          this.button8.Text = "断开";
        else
          this.button8.Text = "连接";
      }
      else
      {
        if (this.comboBox17.SelectedIndex != 2)
          return;
        if (this.button8.Text == "连接")
        {
          if (CommuTcp.NetConect())
            this.button8.Text = "断开";
          else
            this.textBox13.Text = "无法建立连接";
        }
        else
        {
          CommuTcp.NetDisconect();
          this.button8.Text = "连接";
          this.textBox13.Text = "断开完成";
        }
      }
    }

    private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void numericUpDown5_ValueChanged(object sender, EventArgs e)
    {
      FormMain.sCommuAtt.ScreenId = Convert.ToByte(this.numericUpDown5.Value);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      FormMain.sCommuAtt.Port = Convert.ToInt32(this.textBox1.Text);
    }

    private void textBox8_TextChanged_1(object sender, EventArgs e)
    {
      FormMain.sCommuAtt.IP0 = Convert.ToInt32(this.textBox8.Text);
    }

    private void textBox16_TextChanged(object sender, EventArgs e)
    {
      FormMain.sCommuAtt.IP1 = Convert.ToInt32(this.textBox16.Text);
    }

    private void textBox18_TextChanged(object sender, EventArgs e)
    {
      FormMain.sCommuAtt.IP2 = Convert.ToInt32(this.textBox18.Text);
    }

    private void textBox17_TextChanged(object sender, EventArgs e)
    {
      FormMain.sCommuAtt.IP3 = Convert.ToInt32(this.textBox17.Text);
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox1.SelectedIndex == 0)
        FormMain.sCommuAtt.BaudRate = 9600;
      else if (this.comboBox1.SelectedIndex == 1)
        FormMain.sCommuAtt.BaudRate = 38400;
      else
        FormMain.sCommuAtt.BaudRate = 115200;
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e)
    {
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
    {
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {
    }

    private void numericUpDown53_ValueChanged(object sender, EventArgs e)
    {
    }
  }
}
