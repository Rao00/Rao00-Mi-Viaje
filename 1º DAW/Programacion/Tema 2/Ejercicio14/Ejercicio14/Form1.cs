using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_mayor_Click(object sender, EventArgs e)
        {
            try
            {
                l_1.Text = (int.Parse(tb_1.Text) > int.Parse(tb_2.Text)).ToString();
            }
            catch
            {
                l_1.Text = "Error";
            }
        }

        private void b_menor_Click(object sender, EventArgs e)
        {
            try
            {
                l_1.Text = (int.Parse(tb_1.Text) < int.Parse(tb_2.Text)).ToString();
            }
            catch
            {
                l_1.Text = "Error";
            }
        }

        private void b_igual_Click(object sender, EventArgs e)
        {
            try
            {
                l_1.Text = (int.Parse(tb_1.Text) == int.Parse(tb_2.Text)).ToString();
            }
            catch
            {
                l_1.Text = "Error";
            }
        }

        private void b_noigual_Click(object sender, EventArgs e)
        {
            try
            {
                l_1.Text = (int.Parse(tb_1.Text) != int.Parse(tb_2.Text)).ToString();
            }
            catch
            {
                l_1.Text = "Error";
            }
        }
    }
}
