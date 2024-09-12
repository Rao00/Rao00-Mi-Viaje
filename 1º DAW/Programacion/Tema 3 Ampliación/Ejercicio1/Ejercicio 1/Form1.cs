using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bIzq_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtEntrada.Text);
            string salida = "";
            for (int i = num; i > 0; i--)
            {
                int j = i;
                while (j <= num)
                {
                    salida += "* ";
                    j++;
                }
                salida += "\n";
            }
            lSalida.Text = salida;
        }
        private void bDer_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtEntrada.Text);
            string salida = "";
            int k = 0;
            for (int i = num; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    salida += "  ";
                }
                k++;
                for (int l = k; l > 0; l--)
                {
                    salida +="* ";
                }
                salida += "\n";
            }
            lSalida.Text = salida;
        }
    }
}
