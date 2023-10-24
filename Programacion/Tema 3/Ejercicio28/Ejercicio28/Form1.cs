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
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int salida = 0;
            if (num1 < 0)
            {
                for (int i = num1; i < 0; i++)
                {
                    salida -= num2;
                }
            }
            else if (num1 > 0)
            {
                for (int i = num1; i > 0; i--)
                {
                    salida +=num2;
                }
            }
            MessageBox.Show(""+salida);
        }
    }
}
