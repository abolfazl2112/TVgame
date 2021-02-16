using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Web;

namespace videoGame
{
    public partial class jayeze : Form
    {
        public DataGridViewX dg = null;
        string jayezeFilePath = Application.StartupPath + "\\videoFiles\\";
        public jayeze()
        {
            InitializeComponent();
        }

        private void jayeze_Load(object sender, EventArgs e)
        {
            timerStart.Start();
            playFlashFile("jaz-sandogh.flv");
            j1.BringToFront();
        }

        private void playFlashFile(string FLVFileName)
        {
            FLVFileName = jayezeFilePath + FLVFileName;
            f.FlashProperty_FlashVars = "FLVPath=" + System.Web.HttpUtility.HtmlEncode("file://" + FLVFileName);
            f.PutMovieFromStream(this.GetType().Assembly.GetManifestResourceStream("videoGame.Embedded_Movies.FLVPlayer.swf"));
            f.FlashMethod_Play();
        }

        private void f_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                case Keys.D1:
                    SetFormToString(dg.Rows[0].Cells[1].Value.ToString());
                    j1.Visible = true;
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    SetFormToString(dg.Rows[1].Cells[1].Value.ToString());
                    j2.Visible = true;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    SetFormToString(dg.Rows[2].Cells[1].Value.ToString());
                    j3.Visible = true;
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    SetFormToString(dg.Rows[3].Cells[1].Value.ToString());
                    j4.Visible = true;
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    SetFormToString(dg.Rows[4].Cells[1].Value.ToString());
                    j5.Visible = true;
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    SetFormToString(dg.Rows[5].Cells[1].Value.ToString());
                    j6.Visible = true;
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    SetFormToString(dg.Rows[6].Cells[1].Value.ToString());
                    j7.Visible = true;
                    break;
                case Keys.D8:
                case Keys.NumPad8 :
                    SetFormToString(dg.Rows[7].Cells[1].Value.ToString());
                    j8.Visible = true;
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    SetFormToString(dg.Rows[8].Cells[1].Value.ToString());
                    j9.Visible = true;
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    SetFormToString(dg.Rows[9].Cells[1].Value.ToString());
                    j0.Visible = true;
                    break;
            }
            if (e.KeyCode == Keys.End) Application.Exit();

        }

        private void SetFormToString(string jayeze)
        {
            jayezeOpen jo = new jayezeOpen();
            jo.jayeze = jayeze;
            jo.ShowDialog(this);

        }

        internal void setDataGrid(DataGridViewX dgv)
        {
            dg = dgv;
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity == 100)
                timerStart.Stop();
        }
    }
}
