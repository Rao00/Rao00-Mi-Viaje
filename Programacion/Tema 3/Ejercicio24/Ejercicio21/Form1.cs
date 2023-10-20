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
            int multiplicador = 1;
            string salida = "";
            if (inputUser > 0 && inputUser <= 100)
            {
                while (multiplicador < 11)
                {
                    salida += inputUser + " * " + multiplicador + " = " + (inputUser*multiplicador) + ";\n";
                    multiplicador++;
                }
                MessageBox.Show(salida);
            }
            
        }

        private void bSerieFor_Click(object sender, EventArgs e)
        {
            int inputUser = int.Parse(txtSerie.Text);
            string salida = "";
            if (inputUser > 0 && inputUser <= 100)
            {
                for (int i = 1; i < 11; i++)
                {
                    salida += inputUser + " * " + i + " = " + (inputUser*i) + ";\n";
                }
                MessageBox.Show(salida);
            }
        }

        private void bSerieDoWhile_Click(object sender, EventArgs e)
        {
            int inputUser = int.Parse(txtSerie.Text);
            int multiplicador = 1;
            string salida = "";
            if (inputUser > 0 && inputUser <= 100)
            {
                do
                {
                    salida += inputUser + " * " + multiplicador + " = " + (inputUser*multiplicador) + ";\n";
                    multiplicador++;
                } while (multiplicador < 11);
                MessageBox.Show(salida);
            }
        }
    }
}
