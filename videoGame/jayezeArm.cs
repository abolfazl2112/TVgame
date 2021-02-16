using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace videoGame
{
    public partial class jayezeArm : Form
    {
        string jayezeFilePath = Application.StartupPath + "\\videoFiles\\";
        public string Arm = "";

        public jayezeArm()
        {
            InitializeComponent();
        }

        private void playFlashFile(string FLVFileName)
        {
            FLVFileName = jayezeFilePath + FLVFileName;

            f.FlashProperty_FlashVars = "FLVPath=" + System.Web.HttpUtility.HtmlEncode("file://" + FLVFileName);
            f.PutMovieFromStream(this.GetType().Assembly.GetManifestResourceStream("videoGame.Embedded_Movies.FLVPlayer.swf"));
            f.FlashMethod_Play();
        }

        private void jayezeArm_Load(object sender, EventArgs e)
        {
            timerStart.Start();
            if (Arm == "طلا")
                playFlashFile("armTala.flv");
            else
                playFlashFile("Armnoghe.flv");
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity >= 1)
                timerStart.Stop();
        }

        private void f_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.End) Application.Exit();

        }


    }
}
