using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio21__Ampliacion_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        (int fib1, int fib2, int iteracion) CalcularFib(int itMax, int iteracion = 2, int fib1 = 1, int fib2 = 1)
        {
            for (int i=0; iteracion<=itMax; iteracion++)
            {
                fib1 = fib1+fib2;
                fib2 = fib1-fib2;
            }
            return (fib1, fib2, iteracion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtInput.Text);
            MessageBox.Show($"La iteracion {num} es igual a {CalcularFib(itMax: num).fib1}");
        }
    }
}
