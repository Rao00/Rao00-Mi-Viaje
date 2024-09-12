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
        double sumar(double num1, double num2)
        {
            double output = num1 + num2;
            return output;
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(txt1.Text);
            double n2 = int.Parse(txt2.Text);
            double resultado = sumar(n1, n2);
            MessageBox.Show("El resultado es " + resultado);
        }
    }
}
