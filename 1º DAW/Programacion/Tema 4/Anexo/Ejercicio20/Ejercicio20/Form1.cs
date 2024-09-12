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

namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int calcularExp(int numbase, int exp)
        {
            if(exp == 1)
            {
                return numbase;
            }
            int salida = numbase;
            salida *= calcularExp(numbase, exp-1);
            return salida;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int numbase = int.Parse(txtBase.Text);
            int numexp = int.Parse(txtExponente.Text);
            MessageBox.Show("Resultado = " + calcularExp(numbase, numexp));
        }
    }
}
