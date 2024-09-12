using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        String error = "Error de calculo";
        public Form1()
        {
            InitializeComponent();
        }

        private void b_sum_Click(object sender, EventArgs e)
        {
            try 
            {
                tb_out.Text = (int.Parse(tb_1.Text)+int.Parse(tb_2.Text)).ToString();
            }
            catch
            {
                tb_out.Text = error;
            }   
        }
        private void b_res_Click(object sender, EventArgs e)
        {
            try
            {
                tb_out.Text = (int.Parse(tb_1.Text)-int.Parse(tb_2.Text)).ToString();
            }
            catch
            {
                tb_out.Text = error;
            }
        }
    }
}
