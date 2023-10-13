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
    public partial class Ejercicio12 : Form
    {
        public Ejercicio12()
        {
            InitializeComponent();
            
        }
        private void bInput_Click(object sender, EventArgs e)
        {
            int fac = int.Parse(txtFac.Text);
            int salida = 1;

            for (int i = fac; i >= 1; i--)
            { 
                salida *= i;
            }
            lSalida.Text = salida.ToString();
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            int fac = int.Parse(txtFac.Text);
            int salida = 1;
            int i = fac;

            while (i >= 1)
            {
                salida *= i;
                i--;
            }
            lSalida.Text = salida.ToString();
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            int fac = int.Parse(txtFac.Text);
            int salida = 1;
            int i = fac;

            do
            {
                salida *= i;
                i--;
            }
            while (i >= 1);
            lSalida.Text = salida.ToString();
        }
    }
}
