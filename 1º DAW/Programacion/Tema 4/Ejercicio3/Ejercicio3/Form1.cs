using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        (int, int) cambiar(int num1, int num2)
        {
            return (num2, num1);
        }

        private void bCambiar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtValor1.Text);
            int num2 = int.Parse(txtValor2.Text);
            cambiar(num1, num2);
            MessageBox.Show("Los datos de valor1 y valor2, ahora son = " + num1 + ", " + num2);
        }
    }
}
