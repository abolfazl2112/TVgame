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
    public partial class jayezeOpen : Form
    {
        string jayezeFilePath = Application.StartupPath + "\\videoFiles\\";
        public string jayeze = "";

        public jayezeOpen()
        {
            InitializeComponent();
        }

        private void jayezeOpen_Load(object sender, EventArgs e)
        {
            timerstart.Start();
            playFlashFile("jaz-sandogh-baz.flv");
            timerLoad.Start();
        }

        private void playFlashFile(string FLVFileName)
        {
            FLVFileName = jayezeFilePath + FLVFileName;

            f.FlashProperty_FlashVars = "FLVPath=" + System.Web.HttpUtility.HtmlEncode("file://" + FLVFileName);
            f.PutMovieFromStream(this.GetType().Assembly.GetManifestResourceStream("videoGame.Embedded_Movies.FLVPlayer.swf"));
            f.FlashMethod_Play();
        }

        private void timerstart_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity >= 1)
                timerstart.Stop();
        }


        int counter = 0;
        private void timerLoad_Tick(object sender, EventArgs e)
        {

            counter++;
            if (counter >= 80)
            {
                timerLoad.Stop();
                if (jayeze == "نقره" || jayeze == "طلا")
                {
                    jayezeArm ja = new jayezeArm();
                    ja.Arm = jayeze;
                    ja.ShowDialog(this);
                }
                else
                {
                    jayezeSelect js = new jayezeSelect();
                    js.str = jayeze;
                    js.Location = new Point(this.Height + 300, this.Width + 400);
                    js.ShowDialog(this);
                }

                this.Close();
                counter = 0;
                this.Close();
            }
        }

        private void f_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End) Application.Exit();
        }
    }
}
