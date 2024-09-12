using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double comparar(double num1, double num2)
        {
            double num3 = 0;
            if (num1 > num2)
            {
                num3 = num1;
            }
            else if (num2 > num1)
            {
                num3 = num2;
            }
            return num3;
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txt1.Text);
            double n2 = double.Parse(txt2.Text);
            double resultado = comparar(n1, n2);
            MessageBox.Show("El resultado es " + resultado);
        }
    }
}
