using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            int inputUser = 1;
            int multiplicador = 1;
            string salida = "";
            while(inputUser < 11)
            {
                while (multiplicador < 11)
                {
                    salida += inputUser + " * " + multiplicador + " = " + (inputUser*multiplicador) + ";\n";
                    multiplicador++;
                }
                inputUser++;
                multiplicador = 1;
                MessageBox.Show(salida);
                salida = "";
            }
            
        }

        private void bSerieFor_Click(object sender, EventArgs e)
        {
            int inputUser = 1;
            string salida = "";
            for (int i = 0; inputUser < 11; inputUser++)
            {
                for (int j = 1; j < 11; j++)
                {
                    salida += inputUser + " * " + j + " = " + (inputUser*j) + ";\n";
                }
                MessageBox.Show(salida);
                salida = "";
            }
            
        }

        private void bSerieDoWhile_Click(object sender, EventArgs e)
        {
            int inputUser = 1;
            int multiplicador = 1;
            string salida = "";
            do
            {
                do
                {
                    salida += inputUser + " * " + multiplicador + " = " + (inputUser*multiplicador) + ";\n";
                    multiplicador++;
                } while (multiplicador < 11);
                inputUser++;
                MessageBox.Show(salida);
                salida = "";
                multiplicador = 1;
            } while (inputUser < 11);
        }
    }
}
