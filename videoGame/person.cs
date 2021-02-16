using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace videoGame
{
    public partial class person : Form
    {
        string Name1 = "نام", Name2 = "نام", Price1 = "0", Price2 = "0", City1 = "شهرستان", City2 = "شهرستان";
        main m = new main();

        public person()
        {
            InitializeComponent();
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
            m.Name1 = Name1;
            m.Name2 = Name2;
            m.City1 = City1;
            m.City2 = City2;
            m.Price1 = Price1;
            m.Price2 = Price2;

            m.setSanBorj(setRand(1), setRand(2), setRand(3), setRand(4));

            m.ShowDialog(this);
            
        }

        int s1 = 0, s2 = 0, s3 = 0, s4 = 0;
        string setRand(int num)
        {
            Random rand = new Random();
            if (s1 == 0)
            {
                s1 = rand.Next(1, 5);
                return s1.ToString();
            }
            else if (s2 == 0)
            {
                for (s2 = rand.Next(1, 5); true; s2 = rand.Next(1, 5))
                    if (s2 != s1)
                        return s2.ToString();
            }
            else if (s3 == 0)
            {
                for (s3 = rand.Next(1, 5); true; s3 = rand.Next(1, 5))
                    if (s3 != s1 && s3 != s2)
                        return s3.ToString();
            }
            else
            {
                for (s4 = rand.Next(1, 5); true; s4 = rand.Next(1, 5))
                    if (s4 != s1 && s4 != s2 && s4 != s3)
                        return s4.ToString();
            }

            int result = 0;
            return result.ToString();
        }

        private void person_Load(object sender, EventArgs e)
        {
            City2 = "شهرستان";
            City1 = "شهرستان";
            Price2 = "0";
            Name1 = "نام"; Name2 = "نام"; Price1 = "0";
        }

        private void txtName1_Leave(object sender, EventArgs e)
        {
            Name1 = txtName1.Text;
        }

        private void txtCity1_Leave(object sender, EventArgs e)
        {
            City1 = txtCity1.Text;
        }

        private void txtName2_Leave(object sender, EventArgs e)
        {
            Name2 = txtName2.Text;
        }

        private void txtCity2_Leave(object sender, EventArgs e)
        {
            City2 = txtCity2.Text;
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            new flashPlay().ShowDialog(this);
        }

        internal void Data(DataGridViewX dt)
        {
            m.SetDataGridJayeze(dt);
        }
    }
}
