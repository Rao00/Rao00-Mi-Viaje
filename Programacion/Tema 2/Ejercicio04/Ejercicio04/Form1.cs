using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_resultado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tb_num1.Text);
            int num2 = int.Parse(tb_num2.Text);
            MessageBox.Show("El resultado es " + (num1+num2));
        }

        private void tb_num1_TextChanged(object sender, EventArgs e)
        {
        }

        private void b_up_1_Click(object sender, EventArgs e)
        {
        }

        private void b_down_1_Click(object sender, EventArgs e)
        {
        }

        private void b_up_2_Click(object sender, EventArgs e)
        {
        }

        private void b_down_2_Click(object sender, EventArgs e)
        {
        }
    }
}
