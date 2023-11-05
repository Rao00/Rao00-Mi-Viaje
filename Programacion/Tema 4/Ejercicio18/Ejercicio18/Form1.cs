using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double fac(double n1)
        {
            double salida = 1;
            for(double i = n1; i > 0; i--)
            {
                salida *= i;
            }
            return salida;
        }

        double pot(double n1, double n2)
        {
            double salida = 1;
            for (double j = 1; j <= n2; j++)
            {
                salida *= n1;
            }
            return salida;
        }

        double calcular(double m, double n)
        {
            double suma = 0;
            for (double i = 1; i <= n; i++)
            {
                suma += pot(m, i)/fac(i);
            }
            return suma;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtM.Text);
            double num2 = double.Parse(txtN.Text);
            MessageBox.Show($"El resultado de m = {num1} y n = {num2} es igual a {calcular(num1, num2)}");
        }
    }
}
