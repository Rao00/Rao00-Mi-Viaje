using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double euros = 0;
            double pesetas = 0;
            try
            {
                euros = double.Parse(tb_e.Text);
            }
            catch
            {
                euros = 0;
            }
            try
            {
                pesetas = double.Parse(tb_p.Text);
            }
            catch
            {
                pesetas = 0;
            }
            if (pesetas == 0)
            {
                tb_p.Text = (euros*166.386).ToString();
            }
            else if (euros == 0)
            {
                tb_e.Text = (pesetas/166.386).ToString();
            }
            else
            {
                MessageBox.Show("Error, se esperaba un valor y dos fueron enviados");
            }
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            tb_p.Text = String.Empty;
            tb_e.Text = String.Empty;
        }
    }
}
