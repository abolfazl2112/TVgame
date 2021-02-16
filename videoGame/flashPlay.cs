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
    public partial class flashPlay : Form
    {
        string startFilePaths = "";
        public string lablePrice1, lablePrice2;
        public bool imagon1, imagon2, flagPrice = true;

        public string numberGame = "";

        public string sandoogh = "";

        public flashPlay()
        {
            InitializeComponent();
            startFilePaths = Application.StartupPath + "\\videoFiles";
        }

        private void flashPlay_Load(object sender, EventArgs e)
        {
            string B2path = "";
            timer1.Start();
            switch (sandoogh)
            {
                case "b1":
                    B2path = startFilePaths + "\\b1\\item\\";
                    playFlashFile(B2path);
                    break;

                case "b2":
                    B2path = startFilePaths + "\\b2\\item\\";
                    playFlashFile(B2path);
                    break;

                case "b3":
                    B2path = startFilePaths + "\\b3\\item\\";
                    playFlashFile(B2path);
                    break;

                case "b4":
                    B2path = startFilePaths + "\\b4\\item\\";
                    playFlashFile(B2path);
                    break;
            }
            time.Start();
            txtPrice.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity >= 1)
                timer1.Stop();
        }

        private void playFlashFile(string flashFilePath)
        {
            flashFilePath += numberGame + ".swf";
            f.FlashProperty_Movie = flashFilePath;
            f.FlashMethod_Play();
        }

        private void f_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    timerClose.Start();
                    break;
                case Keys.End:
                    Application.Exit();
                    break;
            }
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            txtPrice.Focus();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0.1)
                this.Close();
        }

        private int i = 60;
        private int j = 1;
        int counterAsli = 0;
        private void time_Tick(object sender, EventArgs e)
        {
            string s = System.Convert.ToString(i = i - 1);
            counterAsli++;
            if (counterAsli == 90)
                this.Close();
            if (i < 10)
                labelSec.Text = "0" + s;
            else
                labelSec.Text = s;

            if (i == 0)
            {
                i = 60;
                string m = System.Convert.ToString(j = j - 1);
                if (j < 10)
                    labelMin.Text = "0" + m;
                else
                    labelMin.Text = m;
            }
        }

    }
}
