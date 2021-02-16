namespace videoGame
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnMin = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialogFlashFile = new System.Windows.Forms.OpenFileDialog();
            this.f1 = new f_in_box__lib.f_in_box__control();
            this.f2 = new f_in_box__lib.f_in_box__control();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.timerShowPic = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.timerAsli = new System.Windows.Forms.Timer(this.components);
            this.labelSec = new DevComponents.DotNetBar.LabelX();
            this.labelMin = new DevComponents.DotNetBar.LabelX();
            this.label1 = new DevComponents.DotNetBar.LabelX();
            this.groupTime = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPrice1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelPrice1 = new DevComponents.DotNetBar.LabelX();
            this.labelCity1 = new DevComponents.DotNetBar.LabelX();
            this.labelName1 = new DevComponents.DotNetBar.LabelX();
            this.labelCity2 = new DevComponents.DotNetBar.LabelX();
            this.labelName2 = new DevComponents.DotNetBar.LabelX();
            this.groupPrice2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelPrice2 = new DevComponents.DotNetBar.LabelX();
            this.groupCity1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupName1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            //this.ImagOn1 = new GreenBuddy.GreenBoddy();
            //this.ImagOn2 = new BlueBaddy.BlueBaddy();
            this.groupCity2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupName2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.timerB2 = new System.Windows.Forms.Timer(this.components);
            this.Not1 = new WinCircu.UserControl1();
            this.Not2 = new WinCircu.UserControl1();
            this.Not4 = new WinCircu.UserControl1();
            this.Not3 = new WinCircu.UserControl1();
            this.panel1.SuspendLayout();
            this.groupTime.SuspendLayout();
            this.groupPrice1.SuspendLayout();
            this.groupPrice2.SuspendLayout();
            this.groupCity1.SuspendLayout();
            this.groupName1.SuspendLayout();
            this.groupCity2.SuspendLayout();
            this.groupName2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMin.Location = new System.Drawing.Point(38, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(29, 18);
            this.btnMin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // openFileDialogFlashFile
            // 
            this.openFileDialogFlashFile.Filter = "Flash files (*.swf;*.flv)|*.swf;*.flv|Flash movies (*.swf)|*.swf|Flash video file" +
                "s (*.flv)|*.flv|All files (*.*)|*.*||";
            this.openFileDialogFlashFile.RestoreDirectory = true;
            this.openFileDialogFlashFile.ShowReadOnly = true;
            // 
            // f1
            // 
            this.f1.Context = null;
            this.f1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f1.FlashProperty_AlignMode = 0;
            this.f1.FlashProperty_AllowFullscreen = false;
            this.f1.FlashProperty_AllowScriptAccess = "";
            this.f1.FlashProperty_BackgroundColor = -1;
            this.f1.FlashProperty_Base = "";
            this.f1.FlashProperty_BGColor = "";
            this.f1.FlashProperty_DeviceFont = false;
            this.f1.FlashProperty_EmbedMovie = false;
            this.f1.FlashProperty_FlashVars = "";
            this.f1.FlashProperty_FrameNum = -1;
            this.f1.FlashProperty_Loop = true;
            this.f1.FlashProperty_Menu = true;
            this.f1.FlashProperty_Movie = "";
            this.f1.FlashProperty_MovieData = "";
            this.f1.FlashProperty_Playing = true;
            this.f1.FlashProperty_Quality = 1;
            this.f1.FlashProperty_Quality2 = "High";
            this.f1.FlashProperty_SAlign = "";
            this.f1.FlashProperty_Scale = "ShowAll";
            this.f1.FlashProperty_ScaleMode = 0;
            this.f1.FlashProperty_Stacking = "";
            this.f1.FlashProperty_SWRemote = "";
            this.f1.FlashProperty_WMode = "Window";
            this.f1.Location = new System.Drawing.Point(0, 0);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(800, 510);
            this.f1.StandardMenu = false;
            this.f1.TabIndex = 0;
            this.f1.Text = "0";
            this.f1.TransparentMode = false;
            this.f1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_in_box__control1_KeyDown);
            // 
            // f2
            // 
            this.f2.Context = null;
            this.f2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f2.FlashProperty_AlignMode = 0;
            this.f2.FlashProperty_AllowFullscreen = false;
            this.f2.FlashProperty_AllowScriptAccess = "";
            this.f2.FlashProperty_BackgroundColor = -1;
            this.f2.FlashProperty_Base = "";
            this.f2.FlashProperty_BGColor = "";
            this.f2.FlashProperty_DeviceFont = false;
            this.f2.FlashProperty_EmbedMovie = false;
            this.f2.FlashProperty_FlashVars = "";
            this.f2.FlashProperty_FrameNum = -1;
            this.f2.FlashProperty_Loop = true;
            this.f2.FlashProperty_Menu = true;
            this.f2.FlashProperty_Movie = "";
            this.f2.FlashProperty_MovieData = "";
            this.f2.FlashProperty_Playing = true;
            this.f2.FlashProperty_Quality = 1;
            this.f2.FlashProperty_Quality2 = "High";
            this.f2.FlashProperty_SAlign = "";
            this.f2.FlashProperty_Scale = "ShowAll";
            this.f2.FlashProperty_ScaleMode = 0;
            this.f2.FlashProperty_Stacking = "";
            this.f2.FlashProperty_SWRemote = "";
            this.f2.FlashProperty_WMode = "Window";
            this.f2.Location = new System.Drawing.Point(0, 0);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(800, 510);
            this.f2.StandardMenu = false;
            this.f2.TabIndex = 1;
            this.f2.Text = "0";
            this.f2.TransparentMode = false;
            this.f2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_in_box__control1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 125;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(3, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 18);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerShowPic
            // 
            this.timerShowPic.Interval = 600;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.f1);
            this.panel1.Controls.Add(this.f2);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 510);
            this.panel1.TabIndex = 2;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.Border.Class = "TextBoxBorder";
            this.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrice.Location = new System.Drawing.Point(426, 506);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(92, 27);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Visible = false;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_in_box__control1_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // timerAsli
            // 
            this.timerAsli.Interval = 1000;
            this.timerAsli.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelSec
            // 
            this.labelSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSec.AutoSize = true;
            this.labelSec.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelSec.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelSec.ForeColor = System.Drawing.Color.Blue;
            this.labelSec.Location = new System.Drawing.Point(55, 3);
            this.labelSec.Name = "labelSec";
            this.labelSec.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSec.Size = new System.Drawing.Size(23, 41);
            this.labelSec.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelSec.TabIndex = 65;
            this.labelSec.Text = "99";
            // 
            // labelMin
            // 
            this.labelMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMin.ForeColor = System.Drawing.Color.Blue;
            this.labelMin.Location = new System.Drawing.Point(10, 3);
            this.labelMin.Name = "labelMin";
            this.labelMin.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMin.Size = new System.Drawing.Size(23, 41);
            this.labelMin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelMin.TabIndex = 66;
            this.labelMin.Text = "99";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(40, 4);
            this.label1.Name = "label1";
            this.label1.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Size = new System.Drawing.Size(7, 41);
            this.label1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.label1.TabIndex = 69;
            this.label1.Text = "<b>:</b>";
            // 
            // groupTime
            // 
            this.groupTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupTime.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupTime.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupTime.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange;
            this.groupTime.Controls.Add(this.label1);
            this.groupTime.Controls.Add(this.labelSec);
            this.groupTime.Controls.Add(this.labelMin);
            this.groupTime.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupTime.Location = new System.Drawing.Point(358, 533);
            this.groupTime.Name = "groupTime";
            this.groupTime.Size = new System.Drawing.Size(92, 55);
            // 
            // 
            // 
            this.groupTime.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(143)))));
            this.groupTime.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.groupTime.Style.BackColorGradientAngle = 90;
            this.groupTime.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTime.Style.BorderBottomWidth = 1;
            this.groupTime.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.groupTime.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTime.Style.BorderLeftWidth = 1;
            this.groupTime.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTime.Style.BorderRightWidth = 1;
            this.groupTime.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTime.Style.BorderTopWidth = 1;
            this.groupTime.Style.CornerDiameter = 4;
            this.groupTime.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupTime.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupTime.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(61)))), ((int)(((byte)(6)))));
            this.groupTime.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupTime.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupTime.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupTime.TabIndex = 70;
            // 
            // groupPrice1
            // 
            this.groupPrice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPrice1.BackColor = System.Drawing.Color.Transparent;
            this.groupPrice1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPrice1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPrice1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Yellow;
            this.groupPrice1.Controls.Add(this.labelPrice1);
            this.groupPrice1.Location = new System.Drawing.Point(627, 488);
            this.groupPrice1.Name = "groupPrice1";
            this.groupPrice1.Size = new System.Drawing.Size(64, 35);
            // 
            // 
            // 
            this.groupPrice1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.groupPrice1.Style.BackColor2 = System.Drawing.Color.Lime;
            this.groupPrice1.Style.BackColorGradientAngle = 90;
            this.groupPrice1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice1.Style.BorderBottomWidth = 1;
            this.groupPrice1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(147)))), ((int)(((byte)(17)))));
            this.groupPrice1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice1.Style.BorderLeftWidth = 1;
            this.groupPrice1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice1.Style.BorderRightWidth = 1;
            this.groupPrice1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice1.Style.BorderTopWidth = 1;
            this.groupPrice1.Style.CornerDiameter = 4;
            this.groupPrice1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPrice1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPrice1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.groupPrice1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPrice1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPrice1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPrice1.TabIndex = 77;
            // 
            // labelPrice1
            // 
            this.labelPrice1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPrice1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice1.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.labelPrice1.ForeColor = System.Drawing.Color.Red;
            this.labelPrice1.Location = new System.Drawing.Point(3, -1);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPrice1.Size = new System.Drawing.Size(52, 27);
            this.labelPrice1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelPrice1.TabIndex = 79;
            this.labelPrice1.Text = "امتیاز";
            this.labelPrice1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelCity1
            // 
            this.labelCity1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCity1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelCity1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelCity1.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.labelCity1.ForeColor = System.Drawing.Color.Red;
            this.labelCity1.Location = new System.Drawing.Point(3, 1);
            this.labelCity1.Name = "labelCity1";
            this.labelCity1.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCity1.Size = new System.Drawing.Size(94, 26);
            this.labelCity1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelCity1.TabIndex = 78;
            this.labelCity1.Text = "شهرستان";
            // 
            // labelName1
            // 
            this.labelName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelName1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelName1.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.labelName1.ForeColor = System.Drawing.Color.Red;
            this.labelName1.Location = new System.Drawing.Point(3, -3);
            this.labelName1.Name = "labelName1";
            this.labelName1.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName1.Size = new System.Drawing.Size(168, 36);
            this.labelName1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelName1.TabIndex = 66;
            this.labelName1.Text = "نام و نام خانوادگی";
            // 
            // labelCity2
            // 
            this.labelCity2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCity2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelCity2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelCity2.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.labelCity2.ForeColor = System.Drawing.Color.Red;
            this.labelCity2.Location = new System.Drawing.Point(3, -2);
            this.labelCity2.Name = "labelCity2";
            this.labelCity2.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCity2.Size = new System.Drawing.Size(98, 29);
            this.labelCity2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelCity2.TabIndex = 78;
            this.labelCity2.Text = "شهرستان";
            // 
            // labelName2
            // 
            this.labelName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelName2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelName2.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.labelName2.ForeColor = System.Drawing.Color.Red;
            this.labelName2.Location = new System.Drawing.Point(8, 1);
            this.labelName2.Name = "labelName2";
            this.labelName2.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName2.Size = new System.Drawing.Size(163, 29);
            this.labelName2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelName2.TabIndex = 66;
            this.labelName2.Text = "نام و نام خانوادگی";
            // 
            // groupPrice2
            // 
            this.groupPrice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPrice2.BackColor = System.Drawing.Color.Transparent;
            this.groupPrice2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPrice2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPrice2.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Yellow;
            this.groupPrice2.Controls.Add(this.labelPrice2);
            this.groupPrice2.Location = new System.Drawing.Point(627, 488);
            this.groupPrice2.Name = "groupPrice2";
            this.groupPrice2.Size = new System.Drawing.Size(64, 35);
            // 
            // 
            // 
            this.groupPrice2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.groupPrice2.Style.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.groupPrice2.Style.BackColorGradientAngle = 90;
            this.groupPrice2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice2.Style.BorderBottomWidth = 1;
            this.groupPrice2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(147)))), ((int)(((byte)(17)))));
            this.groupPrice2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice2.Style.BorderLeftWidth = 1;
            this.groupPrice2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice2.Style.BorderRightWidth = 1;
            this.groupPrice2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPrice2.Style.BorderTopWidth = 1;
            this.groupPrice2.Style.CornerDiameter = 4;
            this.groupPrice2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPrice2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPrice2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.groupPrice2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPrice2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPrice2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPrice2.TabIndex = 77;
            // 
            // labelPrice2
            // 
            this.labelPrice2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPrice2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice2.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.labelPrice2.ForeColor = System.Drawing.Color.Red;
            this.labelPrice2.Location = new System.Drawing.Point(3, 0);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPrice2.Size = new System.Drawing.Size(52, 25);
            this.labelPrice2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelPrice2.TabIndex = 79;
            this.labelPrice2.Text = "امتیاز";
            this.labelPrice2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupCity1
            // 
            this.groupCity1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCity1.BackColor = System.Drawing.Color.Transparent;
            this.groupCity1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupCity1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupCity1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange;
            this.groupCity1.Controls.Add(this.labelCity1);
            this.groupCity1.Location = new System.Drawing.Point(598, 554);
            this.groupCity1.Name = "groupCity1";
            this.groupCity1.Size = new System.Drawing.Size(110, 35);
            // 
            // 
            // 
            this.groupCity1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.groupCity1.Style.BackColor2 = System.Drawing.Color.Lime;
            this.groupCity1.Style.BackColorGradientAngle = 90;
            this.groupCity1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity1.Style.BorderBottomWidth = 1;
            this.groupCity1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.groupCity1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity1.Style.BorderLeftWidth = 1;
            this.groupCity1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity1.Style.BorderRightWidth = 1;
            this.groupCity1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity1.Style.BorderTopWidth = 1;
            this.groupCity1.Style.CornerDiameter = 4;
            this.groupCity1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupCity1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupCity1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(61)))), ((int)(((byte)(6)))));
            this.groupCity1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupCity1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupCity1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupCity1.TabIndex = 83;
            this.groupCity1.Click += new System.EventHandler(this.groupCity1_Click);
            // 
            // groupName1
            // 
            this.groupName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupName1.BackColor = System.Drawing.Color.Transparent;
            this.groupName1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupName1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupName1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange;
            this.groupName1.Controls.Add(this.labelName1);
            this.groupName1.Location = new System.Drawing.Point(507, 521);
            this.groupName1.Name = "groupName1";
            this.groupName1.Size = new System.Drawing.Size(180, 35);
            // 
            // 
            // 
            this.groupName1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.groupName1.Style.BackColor2 = System.Drawing.Color.Lime;
            this.groupName1.Style.BackColorGradientAngle = 90;
            this.groupName1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName1.Style.BorderBottomWidth = 1;
            this.groupName1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.groupName1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName1.Style.BorderLeftWidth = 1;
            this.groupName1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName1.Style.BorderRightWidth = 1;
            this.groupName1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName1.Style.BorderTopWidth = 1;
            this.groupName1.Style.CornerDiameter = 4;
            this.groupName1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupName1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupName1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(61)))), ((int)(((byte)(6)))));
            this.groupName1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupName1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupName1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupName1.TabIndex = 84;
            // 
            // ImagOn1
            // 
            this.ImagOn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagOn1.BackColor = System.Drawing.Color.Coral;
            this.ImagOn1.Location = new System.Drawing.Point(676, 478);
            this.ImagOn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImagOn1.Name = "ImagOn1";
            this.ImagOn1.Size = new System.Drawing.Size(110, 109);
            this.ImagOn1.TabIndex = 85;
            // 
            // ImagOn2
            // 
            this.ImagOn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagOn2.Location = new System.Drawing.Point(676, 478);
            this.ImagOn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImagOn2.Name = "ImagOn2";
            this.ImagOn2.Size = new System.Drawing.Size(110, 109);
            this.ImagOn2.TabIndex = 86;
            // 
            // groupCity2
            // 
            this.groupCity2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCity2.BackColor = System.Drawing.Color.Transparent;
            this.groupCity2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupCity2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupCity2.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange;
            this.groupCity2.Controls.Add(this.labelCity2);
            this.groupCity2.Location = new System.Drawing.Point(598, 554);
            this.groupCity2.Name = "groupCity2";
            this.groupCity2.Size = new System.Drawing.Size(110, 35);
            // 
            // 
            // 
            this.groupCity2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.groupCity2.Style.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.groupCity2.Style.BackColorGradientAngle = 90;
            this.groupCity2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity2.Style.BorderBottomWidth = 1;
            this.groupCity2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.groupCity2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity2.Style.BorderLeftWidth = 1;
            this.groupCity2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity2.Style.BorderRightWidth = 1;
            this.groupCity2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCity2.Style.BorderTopWidth = 1;
            this.groupCity2.Style.CornerDiameter = 4;
            this.groupCity2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupCity2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupCity2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(61)))), ((int)(((byte)(6)))));
            this.groupCity2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupCity2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupCity2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupCity2.TabIndex = 89;
            // 
            // groupName2
            // 
            this.groupName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupName2.BackColor = System.Drawing.Color.Transparent;
            this.groupName2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupName2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupName2.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange;
            this.groupName2.Controls.Add(this.labelName2);
            this.groupName2.Location = new System.Drawing.Point(507, 521);
            this.groupName2.Name = "groupName2";
            this.groupName2.Size = new System.Drawing.Size(180, 35);
            // 
            // 
            // 
            this.groupName2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.groupName2.Style.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.groupName2.Style.BackColorGradientAngle = 90;
            this.groupName2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName2.Style.BorderBottomWidth = 1;
            this.groupName2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.groupName2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName2.Style.BorderLeftWidth = 1;
            this.groupName2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName2.Style.BorderRightWidth = 1;
            this.groupName2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupName2.Style.BorderTopWidth = 1;
            this.groupName2.Style.CornerDiameter = 4;
            this.groupName2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupName2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupName2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(61)))), ((int)(((byte)(6)))));
            this.groupName2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupName2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupName2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupName2.TabIndex = 90;
            // 
            // timerB2
            // 
            this.timerB2.Interval = 1000;
            this.timerB2.Tick += new System.EventHandler(this.timerB2_Tick);
            // 
            // Not1
            // 
            this.Not1.Location = new System.Drawing.Point(135, 300);
            this.Not1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Not1.Name = "Not1";
            this.Not1.Size = new System.Drawing.Size(65, 65);
            this.Not1.TabIndex = 91;
            this.Not1.Visible = false;
            // 
            // Not2
            // 
            this.Not2.Location = new System.Drawing.Point(302, 297);
            this.Not2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Not2.Name = "Not2";
            this.Not2.Size = new System.Drawing.Size(65, 65);
            this.Not2.TabIndex = 92;
            this.Not2.Visible = false;
            // 
            // Not4
            // 
            this.Not4.Location = new System.Drawing.Point(586, 297);
            this.Not4.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Not4.Name = "Not4";
            this.Not4.Size = new System.Drawing.Size(65, 65);
            this.Not4.TabIndex = 94;
            this.Not4.Visible = false;
            // 
            // Not3
            // 
            this.Not3.Location = new System.Drawing.Point(429, 297);
            this.Not3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Not3.Name = "Not3";
            this.Not3.Size = new System.Drawing.Size(65, 65);
            this.Not3.TabIndex = 93;
            this.Not3.Visible = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Not4);
            this.Controls.Add(this.Not3);
            this.Controls.Add(this.Not2);
            this.Controls.Add(this.Not1);
            this.Controls.Add(this.groupCity1);
            this.Controls.Add(this.groupCity2);
            this.Controls.Add(this.groupPrice1);
            this.Controls.Add(this.groupPrice2);
            this.Controls.Add(this.groupName1);
            this.Controls.Add(this.groupName2);
            this.Controls.Add(this.ImagOn1);
            this.Controls.Add(this.ImagOn2);
            this.Controls.Add(this.groupTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.groupTime.ResumeLayout(false);
            this.groupTime.PerformLayout();
            this.groupPrice1.ResumeLayout(false);
            this.groupPrice2.ResumeLayout(false);
            this.groupCity1.ResumeLayout(false);
            this.groupName1.ResumeLayout(false);
            this.groupCity2.ResumeLayout(false);
            this.groupName2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnMin;
        internal System.Windows.Forms.OpenFileDialog openFileDialogFlashFile;
        private f_in_box__lib.f_in_box__control f1;
        private f_in_box__lib.f_in_box__control f2;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Timer timerShowPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerAsli;
        private DevComponents.DotNetBar.LabelX labelSec;
        private DevComponents.DotNetBar.LabelX labelMin;
        private DevComponents.DotNetBar.LabelX label1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupTime;
        private DevComponents.DotNetBar.LabelX labelCity1;
        private DevComponents.DotNetBar.LabelX labelName1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPrice1;
        private DevComponents.DotNetBar.LabelX labelPrice1;
        private DevComponents.DotNetBar.LabelX labelCity2;
        private DevComponents.DotNetBar.LabelX labelName2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPrice2;
        private DevComponents.DotNetBar.LabelX labelPrice2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
        private DevComponents.DotNetBar.Controls.GroupPanel groupCity1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupName1;
        private GreenBuddy.GreenBoddy ImagOn1;
        private BlueBaddy.BlueBaddy ImagOn2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupCity2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupName2;
        private System.Windows.Forms.Timer timerB2;
        private WinCircu.UserControl1 Not1;
        private WinCircu.UserControl1 Not2;
        private WinCircu.UserControl1 Not4;
        private WinCircu.UserControl1 Not3;
    }
}