using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace videoGame
{
    public partial class jayezeSelect : Form
    {
        public int x, y;
        public jayezeSelect()
        {
            InitializeComponent();
        }

        private void jayezeSelect_Load(object sender, EventArgs e)
        {
            button1.Text = str;
            this.Location = new Point(this.Location.X + 100, this.Location.Y);
            timer1.Start();
        }

        public string str = "";

        private void jayezeSelect_Paint(object sender, PaintEventArgs e)
        {
            //str = "ما ز یاران چشم یاری داشتیم ... خود غلط بود آنچه ما پنداشتیم";
            GraphicsPath p = new GraphicsPath();
            Point po = new Point(0, 0);

            p.AddString(str, new FontFamily("B Titr"), 1, 100, po, new StringFormat());
            Region = new Region(p);
            po = new Point(0, 0);
            Point po1 = PointToScreen(po);
            e.Graphics.TranslateTransform(((float)Left - po1.X), ((float)Top - po1.Y));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(Brushes.Black, p);
            e.Graphics.DrawPath(new Pen(Color.Red, 5f), p);
        }

        private void jayezeSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode== Keys.End)
                    Application.Exit();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity == 100)
                timer1.Stop();
        }
    }
}
