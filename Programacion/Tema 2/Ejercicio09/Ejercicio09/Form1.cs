using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        public void b_sum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tb_01.Text);
            int num2 = int.Parse(tb_02.Text);
            string error = "Error de calculo";
            try
            {
                tb_out.Text = (num1+num2).ToString();
            }
            catch
            {
                tb_out.Text = error;
            }
        }

        private void b_res_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tb_01.Text);
            int num2 = int.Parse(tb_02.Text);
            string error = "Error de calculo";
            try
            {
                tb_out.Text = (num1-num2).ToString();
            }
            catch
            {
                tb_out.Text = error;
            }
        }

        private void b_mult_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tb_01.Text);
            int num2 = int.Parse(tb_02.Text);
            string error = "Error de calculo";
            try
            {
                tb_out.Text = (num1*num2).ToString();
            }
            catch
            {
                tb_out.Text = error;
            }
        }

        private void b_div_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tb_01.Text);
            int num2 = int.Parse(tb_02.Text);
            string error = "Error de calculo";
            try
            {
                tb_out.Text = (num1/num2) + "," + (num1%num2);
            }
            catch
            {
                tb_out.Text = error;
            }
        }
    }
}
