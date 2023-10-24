using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(txtNum1.Text);
            double num2 = int.Parse(txtNum2.Text);
            double salida = 0;
            if (num1 > 0)
            {
                for (int i = 1; i <= num2; i++)
                {
                    if (i%2 == 0)
                    {
                        salida -= num1/i;
                    }
                    else
                    {
                        salida += num1/i;
                    }
                    
                }
            }
            MessageBox.Show(""+salida);
        }
    }
}
