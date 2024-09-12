using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSerie_Click(object sender, EventArgs e)
        {
            int inputUser = int.Parse(txtSerie.Text);
            int lon_cadena = 10;
            string cadena = "";
            string salida = "";
            while (inputUser >= 1 && inputUser <= 15)
            {
                while (lon_cadena > 0)
                {
                    cadena = lon_cadena+", " + cadena;
                    lon_cadena--;
                }
                inputUser--;
                salida += cadena + "\n";
            }
            MessageBox.Show(salida);
        }

        private void bSerieFor_Click(object sender, EventArgs e)
        {
            int inputUser = int.Parse(txtSerie.Text);
            int lon_cadena = 10;
            string cadena = "";
            string salida = "";
            for(int i = 1; i <= inputUser; i++)
            {
                if (cadena == "")
                    for (int j = 1; j <= lon_cadena; j++)
                    {
                        cadena += j + ", ";
                    }
                salida += cadena + "\n";
            }
            MessageBox.Show(salida);
        }

        private void bSerieDoWhile_Click(object sender, EventArgs e)
        {
            int inputUser = int.Parse(txtSerie.Text);
            int lon_cadena = 10;
            string cadena = "";
            string salida = "";
            do {
                if (lon_cadena > 0)
                {
                    do{
                        cadena = lon_cadena+", " + cadena;
                        lon_cadena--;
                    } while (lon_cadena > 0);
                }
                inputUser--;
                salida += cadena + "\n";
            } while (inputUser >= 1 && inputUser <= 15);
            MessageBox.Show(salida);
        }
    }
}
