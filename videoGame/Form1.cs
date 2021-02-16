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
    
    public partial class Form1 : Form
    {
        publicItem pi = new publicItem();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            person p = new person();
            this.Hide();
            p.Data(dataGridViewX1);
            p.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Add(10);
            for (int i = 0; i < dataGridViewX1.RowCount; i++)
            {
                dataGridViewX1.Rows[i].Cells[0].Value = "صندوق شماره " + (i + 1);
                dataGridViewX1.Rows[i].Cells[1].Value = "پوچ";
            }
        }

        private void dataGridViewX1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }
        }

        private void dataGridViewX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridViewX1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double d = double.Parse(dataGridViewX1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            catch
            {
                MessageBox.Show("مبلغ جایزه را به عدد وارد کنید");
                dataGridViewX1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            dataGridViewX1.CurrentRow.Cells[1].Value = "پوچ";
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            dataGridViewX1.CurrentRow.Cells[1].Value = "نقره";
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridViewX1.CurrentRow.Cells[1].Value = "طلا";
        }

    }
}
