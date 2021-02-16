using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Threading;
using DevComponents.DotNetBar.Controls;

namespace videoGame
{
    public partial class main : Form
    {
        Point pNot1 = new Point(135, 300);
        Point pNot2 = new Point(302, 297);
        Point pNot3 = new Point(429, 297);
        Point pNot4 = new Point(586, 297);
        string[] sanborj = new string[4];
        string s1, s2, s3, s4;
        string selectedBorj = "0";
        double counter = 0;
        bool Endb1 = true, Endb2 = true, Endb3 = true, Endb4 = true;
        bool flag = true, flagPrice = true;
        int randBorj, counterB1 = 0,counterB2 = 0,counterB3 = 0,counterB4 = 0,numberGame = 10,counterGame = 1;
        string marhale = "-1", startFilePaths = "";
        

        public string Name1 = "", Name2 = "", Price1 = "", Price2 = "", City1 = "", City2 = "";


        Random random = new Random();

        public main()
        {
            try
            {
                InitializeComponent();
            }
            catch { }
            startFilePaths = Application.StartupPath + "\\videoFiles";
        }

        public void setSanBorj(string s1, string s2, string s3, string s4)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
        }

        private void playVideoFlash(string flashFilePath)
        {
            if (flag)
            {
                flag = false;
                f2.FlashProperty_FlashVars = "FLVPath=" + System.Web.HttpUtility.HtmlEncode("file://" + flashFilePath);
                f2.PutMovieFromStream(this.GetType().Assembly.GetManifestResourceStream("videoGame.Embedded_Movies.FLVPlayer.swf"));
                f2.FlashMethod_Play();
            }
            else
            {
                flag = true;
                f1.FlashProperty_FlashVars = "FLVPath=" + System.Web.HttpUtility.HtmlEncode("file://" + flashFilePath);
                f1.PutMovieFromStream(this.GetType().Assembly.GetManifestResourceStream("videoGame.Embedded_Movies.FLVPlayer.swf"));
                f1.FlashMethod_Play();
            }
            timer1.Enabled = true;

        }

        

        private void swicher()
        {
            if (!flag)
            {
                f1.SendToBack();
                f2.BringToFront();
                f2.Focus();
            }
            else
            {
                f2.SendToBack();
                f1.BringToFront();
                f1.Focus();
            }
        }
        
        private string SetRandPoint(string numberSandoogh)
        {
            switch (int.Parse(numberSandoogh))
            {
                case 1:
                    randBorj = int.Parse(s1);
                    break;
                case 2:
                    randBorj = int.Parse(s2);
                    break;
                case 3:
                    randBorj = int.Parse(s3);
                    break;
                case 4:
                    randBorj = int.Parse(s4);
                    break;
            }
            string filePath = startFilePaths + "\\1" + numberSandoogh + "\\" + randBorj.ToString() +".flv";
            return filePath;
        }

        private string SetBoxBorg(string numberSandoogh)
        {
            string filePath = startFilePaths + "\\" + marhale +"\\" + numberSandoogh + ".flv";
            return filePath;
        }

        private void f_in_box__control1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.End:
                    Application.Exit();
                    break;
                case Keys.Escape:
                    this.WindowState = FormWindowState.Normal;
                    break;

                case Keys.NumPad1:
                    flagPrice = true;
                    MoveKeysNumPad1();
                    break;
                case Keys.NumPad2:
                    flagPrice = true;
                    MoveKeysNumPad2();
                    break;
                case Keys.NumPad3:
                    flagPrice = true;
                    MoveKeysNumPad3();
                    break;
                case Keys.NumPad4:
                    flagPrice = true;
                    MoveKeysNumPad4();
                    break;

                case Keys.Space:
                    flagPrice = true;
                    MoveKeySpace();
                    break;

                case Keys.Enter:
                    flagPrice = true;
                    switchPic();
                    break;

                case Keys.Down:
                    priceDown();
                    flagPrice = true;
                    break;
                case Keys.Up:
                    priceUp();
                    flagPrice = true;
                    break;

                case Keys.D0:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "0";
                    }
                    else
                    {
                        txtPrice.Text += "0";
                    }
                    break;
                case Keys.D1:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "1";
                    }
                    else
                    {
                        txtPrice.Text += "1";
                    }
                    break;
                case Keys.D2:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "2";
                    }
                    else
                    {
                        txtPrice.Text += "2";
                    }
                    break;
                case Keys.D3:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "3";
                    }
                    else
                    {
                        txtPrice.Text += "3";
                    }
                    break;
                case Keys.D4:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "4";
                    }
                    else
                    {
                        txtPrice.Text += "4";
                    }
                    break;
                case Keys.D5:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "5";
                    }
                    else
                    {
                        txtPrice.Text += "5";
                    }
                    break;
                case Keys.D6:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "6";
                    }
                    else
                    {
                        txtPrice.Text += "6";
                    }
                    break;
                case Keys.D7:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "7";
                    }
                    else
                    {
                        txtPrice.Text += "7";
                    }
                    break;
                case Keys.D8:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "8";
                    }
                    else
                    {
                        txtPrice.Text += "8";
                    }
                    break;
                case Keys.D9:
                    if (flagPrice)
                    {
                        flagPrice = false;
                        txtPrice.Text = "9";
                    }
                    else
                    {
                        txtPrice.Text += "9";
                    }
                    break;
                    
                case Keys.Q:
                    jayeze j = new jayeze();
                    j.setDataGrid(dgv);
                    j.ShowDialog(this);
                    break;

                case Keys.A:
                    playVideoFlash(startFilePaths + "\\s10.flv");
                    
                    if (!Endb1)
                        showNotB1();
                    if (!Endb2)
                        showNotB2();
                    if (!Endb3)
                        showNotB3();
                    if (!Endb4)
                        showNotB4();

                    if (selectedBorj == "1" && Endb1)
                    {
                        showNotB1();
                        Endb1 = false;
                    }
                    else if (selectedBorj == "2" && Endb2)
                    {
                        showNotB2();
                        Endb2 = false;
                    }
                    else if (selectedBorj == "3" && Endb3)
                    {
                        showNotB3();
                        Endb3 = false;
                    }
                    else if (selectedBorj == "4" && Endb4)
                    {
                        showNotB4();
                        Endb4 = false;
                    }

                    marhale = "1";
                    counterGame = 1;
                    counterB4 = counterB3 = counterB2 = counterB1 = 1;
                    break;
            }
        }

        private void showNotB4()
        {
            timerB2.Start();
        }

        private void showNotB3()
        {
            timerB2.Start();
        }

        private void showNotB2()
        {
            timerB2.Start();
        }

        private void showNotB1()
        {
            timerB2.Start();
        }

        private void priceUp()
        {
            int x = 0, y = 0;
            if (ImagOn1.Visible)
            {
                x = int.Parse(labelPrice1.Text);
                y = int.Parse(((txtPrice.Text == "") ? "1" : txtPrice.Text));
                labelPrice1.Text = (x + y).ToString();
            }
            else
            {
                x = int.Parse(labelPrice2.Text);
                y = int.Parse(((txtPrice.Text == "") ? "1" : txtPrice.Text));
                labelPrice2.Text = (x + y).ToString();
            }
        }

        private void priceDown()
        {
            int x = 0, y = 0;
            if (ImagOn1.Visible)
            {
                x = int.Parse(labelPrice1.Text);
                y = int.Parse(((txtPrice.Text == "") ? "1" : txtPrice.Text));
                labelPrice1.Text = (x - y).ToString();
            }
            else
            {
                x = int.Parse(labelPrice2.Text);
                y = int.Parse(((txtPrice.Text == "") ? "1" : txtPrice.Text));
                labelPrice2.Text = (x - y).ToString();
            }
        }

        private void MoveKeySpace()
        {
            switch(marhale)
            {
                case "-1":
                    playVideoFlash(startFilePaths + "\\001.flv");
                    marhale = "0";
                    break;

                case "0":
                    playVideoFlash(startFilePaths + "\\a10.flv");
                    marhale = "1";
                    break;

                case"1":
                    playVideoFlash(startFilePaths + "\\b" + randBorj + ".flv");
                    marhale = "b" + randBorj.ToString();
                    numberGame = 1;
                    break;

                case "b1":
                    counterB1++;
                    GoNextB1();
                    counterGame++;
                    break;

                case "b2":
                    counterB2++;
                    GoNextB2();
                    counterGame++;

                    break;

                case "b3":
                    counterB3++;
                    GoNextB3();
                    counterGame++;
                    break;

                case "b4":
                    counterB4++;
                    GoNextB4();
                    counterGame++;
                    break;
                
            }
        }

        private void MoveKeysNumPad1()
        {
            int rand;

            switch(marhale)
            {
                case "0":
                    rand = random.Next(1, 4);
                    playVideoFlash(startFilePaths + "\\1\\" + rand.ToString() + ".flv");
                    break;
                case "1":
                    if (!Endb1) return;

                    Not2.Visible = Not3.Visible = Not4.Visible = false;
                    string sandoogh = "1";
                    selectedBorj = sandoogh;
                    playVideoFlash(SetRandPoint(sandoogh));
                    break;
                

            }
        }

        private void MoveKeysNumPad2()
        {
            int rand;

            switch (marhale)
            {
                case "0":
                    rand = random.Next(1, 4);
                    playVideoFlash(startFilePaths + "\\2\\" + rand.ToString() + ".flv");
                    break;
                case "1":
                    if (!Endb2) return;
                    Not1.Visible = Not3.Visible = Not4.Visible = false;
                    string sandoogh = "2";
                    selectedBorj = sandoogh;
                    playVideoFlash(SetRandPoint(sandoogh));
                    break;

            }
        }

        private void MoveKeysNumPad3()
        {
            int rand;

            switch (marhale)
            {
                case "0":
                    rand = random.Next(1, 4);
                    playVideoFlash(startFilePaths + "\\3\\" + rand.ToString() + ".flv");
                    break;
                case "1":
                    if (!Endb3) return;
                    Not2.Visible = Not1.Visible = Not4.Visible = false;
                    string sandoogh = "3";
                    selectedBorj = sandoogh;
                    playVideoFlash(SetRandPoint(sandoogh));
                    break;

            }
        }

        private void MoveKeysNumPad4()
        {
            int rand;

            switch (marhale)
            {
                case "1":
                    if (!Endb4) return;
                    Not2.Visible = Not3.Visible = Not1.Visible = false;
                    string sandoogh = "4";
                    selectedBorj = sandoogh;
                    playVideoFlash(SetRandPoint(sandoogh));
                    break;
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFullScrean_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
            labelMin.Text = "22";
            labelSec.Text = "59";

            

            panel1.Dock = DockStyle.Fill;
            
            string sandoogh = "1";
            SetRandPoint(sandoogh);

            labelName1.Text = Name1;
            labelName2.Text = Name2;
            labelPrice1.Text = Price1;
            labelPrice2.Text = Price2;
            labelCity1.Text = City1;
            labelCity2.Text = City2;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 4)
            {
                timer1.Enabled = false;
                counter = 0;
                swicher();
                timer1.Stop();
                if (!timerAsli.Enabled)
                    timerAsli.Enabled = true;
            }
            counter++;
        }

        private int i = 60;
        private int j = 21;

        private void timer2_Tick(object sender, EventArgs e)
        {
            string s = System.Convert.ToString(i = i - 1);
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

        private void switchPic()
        {
            if (ImagOn1.Visible)
            {
                ImagOn2.Visible = groupCity2.Visible = groupName2.Visible = groupPrice2.Visible = true;
                ImagOn1.Visible = groupCity1.Visible = groupName1.Visible = groupPrice1.Visible = false;
                
            }
            else
            {
                ImagOn2.Visible = groupCity2.Visible = groupName2.Visible = groupPrice2.Visible = false;
                ImagOn1.Visible = groupCity1.Visible = groupName1.Visible = groupPrice1.Visible = true;
            }
        }

        private void stop_timerAsli()
        {
            timer1.Stop();
            i = 0;
            j = 0;
            labelMin.Text = "    ";
            labelSec.Text = "    ";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.Focus();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupCity1_Click(object sender, EventArgs e)
        {

        }

        private void GoNextB1()
        {
            string B1path = startFilePaths + "\\b1\\";

            flashPlay fla = new flashPlay();
            fla.lablePrice1 = labelPrice1.Text;
            fla.lablePrice2 = labelPrice2.Text;
            
            fla.sandoogh = marhale;
            if (counterGame == 11) counterGame = 1;
            fla.numberGame = counterGame.ToString();

            fla.imagon1 = ImagOn1.Visible;
            fla.imagon2 = ImagOn2.Visible;

            fla.ShowDialog(this);

            labelPrice1.Text = fla.lablePrice1;
            labelPrice2.Text = fla.lablePrice2;

            B1path += counterB1.ToString() + ".flv";
            playVideoFlash(B1path);
            if (counterB1 == 6)
            {
                counterB1 = 1;
            }

        }

        private void GoNextB2()
        {
            string B2path = startFilePaths + "\\b2\\";

            flashPlay fla = new flashPlay();
            fla.lablePrice1 = labelPrice1.Text;
            fla.lablePrice2 = labelPrice2.Text;

            fla.sandoogh = marhale;
            if (counterGame == 11) counterGame = 1;
            fla.numberGame = counterGame.ToString();

            fla.imagon1 = ImagOn1.Visible;
            fla.imagon2 = ImagOn2.Visible;

            fla.ShowDialog(this);

            labelPrice1.Text = fla.lablePrice1;
            labelPrice2.Text = fla.lablePrice2;

            B2path += counterB2.ToString() + ".flv";
            playVideoFlash(B2path);
            if (counterB2 == 4)
            {
                counterB2 = 1;
            }

        }

        private void GoNextB3()
        {
            string B3path = startFilePaths + "\\b3\\";

            flashPlay fla = new flashPlay();
            fla.lablePrice1 = labelPrice1.Text;
            fla.lablePrice2 = labelPrice2.Text;
            
            fla.sandoogh = marhale;
            if (counterGame == 11) counterGame = 1;
            fla.numberGame = counterGame.ToString();

            fla.imagon1 = ImagOn1.Visible;
            fla.imagon2 = ImagOn2.Visible;

            fla.ShowDialog(this);

            labelPrice1.Text = fla.lablePrice1;
            labelPrice2.Text = fla.lablePrice2;

            B3path += counterB3.ToString() + ".flv";
            playVideoFlash(B3path);
            if (counterB3 == 4)
            {
                counterB3 = 1;
            }
        }

        private void GoNextB4()
        {
            string B4path = startFilePaths + "\\b4\\";

            flashPlay fla = new flashPlay();
            fla.lablePrice1 = labelPrice1.Text;
            fla.lablePrice2 = labelPrice2.Text;

            fla.sandoogh = marhale;
            if (counterGame == 11) counterGame = 1;
            fla.numberGame = counterGame.ToString();

            fla.imagon1 = ImagOn1.Visible;
            fla.imagon2 = ImagOn2.Visible;
            fla.numberGame = counterGame.ToString();
            fla.ShowDialog(this);

            labelPrice1.Text = fla.lablePrice1;
            labelPrice2.Text = fla.lablePrice2;

            B4path += random.Next(1, 4).ToString() + ".flv";
            playVideoFlash(B4path);

        }

        DataGridViewX dgv;
        internal void SetDataGridJayeze(DataGridViewX dt)
        {
            dgv = dt;
        }

        int counterNot = 0;
        private void timerB2_Tick(object sender, EventArgs e)
        {
            counterNot++;
            if (counterNot != 5) return;
            counterNot = 0;
            timerB2.Stop();
            if (!Endb4)
                Not4.Visible = true;

            if (!Endb3)
                Not3.Visible = true;

            if (!Endb2)
                Not2.Visible = true;

            if (!Endb1)
                Not1.Visible = true;
        }
    }

}
