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
            const int NUM = 100;
            int saltoLinea = 1;
            int salida = 0;
            lSalida.Text = "";
            for (int i = 3; i <= NUM; i+=3)
            {
                if (saltoLinea == 7)
                {
                    lSalida.Text += i + ", \n";
                    saltoLinea=1;
                }
                else if (i < 99)
                {
                    saltoLinea++;
                    lSalida.Text += i + ", ";
                }
                else
                {
                    saltoLinea++;
                    lSalida.Text += i + ".";
                }
                salida+=i;
            }
            lSalida.Text += "\nEl resultado es "+salida;
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            const int NUM = 100;
            int i = 3;
            int saltoLinea = 1;
            int salida = 0;
            lSalida.Text = "";
            while (i <= NUM)
            {
                if (saltoLinea == 7)
                {
                    lSalida.Text += i + ", \n";
                    saltoLinea=1;
                }
                else if (i < 99)
                {
                    saltoLinea++;
                    lSalida.Text += i + ", ";
                }
                else
                {
                    saltoLinea++;
                    lSalida.Text += i + ".";
                }
                salida+=i;
                i+=3;
            }
            lSalida.Text += "\nEl resultado es "+salida;
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            const int NUM = 100;
            int i = 3;
            int saltoLinea = 1;
            int salida = 0;
            lSalida.Text = "";
            do
            {
                if (saltoLinea == 7)
                {
                    lSalida.Text += i + ", \n";
                    saltoLinea=1;
                }
                else if (i < 99)
                {
                    saltoLinea++;
                    lSalida.Text += i + ", ";
                }
                else
                {
                    saltoLinea++;
                    lSalida.Text += i + ".";
                }
                salida+=i;
                i+=3;
            }while (i <= NUM);
            lSalida.Text += "\nEl resultado es "+salida;
        }
    }
}
