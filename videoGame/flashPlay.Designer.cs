namespace videoGame
{
    partial class flashPlay
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.f = new f_in_box__lib.f_in_box__control();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.groupTime = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label1 = new DevComponents.DotNetBar.LabelX();
            this.labelSec = new DevComponents.DotNetBar.LabelX();
            this.labelMin = new DevComponents.DotNetBar.LabelX();
            this.groupTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.White;
            this.f.Context = null;
            this.f.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f.FlashProperty_AlignMode = 0;
            this.f.FlashProperty_AllowFullscreen = false;
            this.f.FlashProperty_AllowScriptAccess = "";
            this.f.FlashProperty_BackgroundColor = -1;
            this.f.FlashProperty_Base = "";
            this.f.FlashProperty_BGColor = "";
            this.f.FlashProperty_DeviceFont = false;
            this.f.FlashProperty_EmbedMovie = false;
            this.f.FlashProperty_FlashVars = "";
            this.f.FlashProperty_FrameNum = -1;
            this.f.FlashProperty_Loop = true;
            this.f.FlashProperty_Menu = true;
            this.f.FlashProperty_Movie = "";
            this.f.FlashProperty_MovieData = "";
            this.f.FlashProperty_Playing = true;
            this.f.FlashProperty_Quality = 1;
            this.f.FlashProperty_Quality2 = "High";
            this.f.FlashProperty_SAlign = "";
            this.f.FlashProperty_Scale = "ShowAll";
            this.f.FlashProperty_ScaleMode = 0;
            this.f.FlashProperty_Stacking = "";
            this.f.FlashProperty_SWRemote = "";
            this.f.FlashProperty_WMode = "Window";
            this.f.Location = new System.Drawing.Point(0, 0);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(800, 600);
            this.f.StandardMenu = false;
            this.f.TabIndex = 1;
            this.f.Text = "0";
            this.f.TransparentMode = false;
            this.f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_KeyDown);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(349, 457);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_KeyDown);
            this.txtPrice.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
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
            this.groupTime.Location = new System.Drawing.Point(12, 533);
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
            this.groupTime.TabIndex = 71;
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
            this.labelSec.Size = new System.Drawing.Size(24, 41);
            this.labelSec.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelSec.TabIndex = 65;
            this.labelSec.Text = "60";
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
            this.labelMin.Size = new System.Drawing.Size(21, 41);
            this.labelMin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelMin.TabIndex = 66;
            this.labelMin.Text = "01";
            // 
            // flashPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupTime);
            this.Controls.Add(this.f);
            this.Controls.Add(this.txtPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "flashPlay";
            this.Opacity = 0.05D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flashPlay";
            this.Load += new System.EventHandler(this.flashPlay_Load);
            this.groupTime.ResumeLayout(false);
            this.groupTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private f_in_box__lib.f_in_box__control f;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Timer time;
        private DevComponents.DotNetBar.Controls.GroupPanel groupTime;
        private DevComponents.DotNetBar.LabelX label1;
        private DevComponents.DotNetBar.LabelX labelSec;
        private DevComponents.DotNetBar.LabelX labelMin;
    }
}