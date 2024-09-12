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
            const int NUM = 50;
            int salida = 0;

            for (int i = 0; i <= NUM; i+=2)
            { 
                salida += i;
            }
            lSalida.Text = salida.ToString();
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            const int NUM = 50;
            int salida = 0;
            int i = 0;

            while (i <= NUM)
            {
                salida += i;
                i+=2;
            }
            lSalida.Text = salida.ToString();
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            const int NUM = 50;
            int salida = 0;
            int i = 0;

            do
            {
                salida += i;
                i+=2;
            }
            while (i <= NUM);
            lSalida.Text = salida.ToString();
        }
    }
}
