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
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }
        Form1 form1;
        private void button1_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();

            Hide();
        }
    }
}
