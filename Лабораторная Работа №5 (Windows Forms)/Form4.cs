using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_Работа__5__Windows_Forms_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int strings = 4, columns = 3;
            int[,] table = new int[strings, columns];

            dataGridView1.RowCount = strings;
            dataGridView1.ColumnCount = columns;
            int i, j;
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    table[i, j] = rnd.Next(1, 10);
                    dataGridView1[j, i].Value = table[i, j];

                }
            }
        }
    }
}
