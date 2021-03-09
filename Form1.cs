using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1lab
{
    public partial class Form1 : Form
    {

        int n = 0;
        int[] mas;
        int i = 0;
        int j = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i > n - 1)
        {
            j++;
            i = 0;
        }
        dataGridView1[i, j].Value = textBox1.Text;
        // int i, j;
        i++;
       
       
            //for (i = 0; i < n; ++i)
            //  for (j = 0; j < n; ++j)
            //    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dataGridView1.RowCount = n;
           // dataGridView1.ColumnCount = m;
           // int i, j;
          //  for (i = 0; i < n; ++i)
           //     for (j = 0; j < m; ++j)
             //       dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = n + 1;
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = n - 1;
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;

        }
    }
}
