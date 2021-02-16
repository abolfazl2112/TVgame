namespace videoGame
{
    partial class jayezeOpen
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
            this.f = new f_in_box__lib.f_in_box__control();
            this.timerstart = new System.Windows.Forms.Timer(this.components);
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.f.TabIndex = 3;
            this.f.Text = "0";
            this.f.TransparentMode = false;
            this.f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_KeyDown);
            // 
            // timerstart
            // 
            this.timerstart.Tick += new System.EventHandler(this.timerstart_Tick);
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // jayezeOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jayezeOpen";
            this.Opacity = 0.05D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.jayezeOpen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private f_in_box__lib.f_in_box__control f;
        private System.Windows.Forms.Timer timerstart;
        private System.Windows.Forms.Timer timerLoad;
    }
}