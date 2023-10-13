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
            int numElegido = int.Parse(txtEntrada.Text);
            lSalida.Text = "";
            for (int i = 0; i < numElegido; numElegido--)
            {
                lSalida.Text += numElegido + "\n";
            }
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            int numElegido = int.Parse(txtEntrada.Text);
            lSalida.Text = "";
            while (numElegido > 0)
            {
                lSalida.Text += numElegido + "\n";
                numElegido--;
            }
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            int numElegido = int.Parse(txtEntrada.Text);
            lSalida.Text = "";
            do
            {
                lSalida.Text += numElegido + "\n";
                numElegido--;
            } 
            while (numElegido > 0);
        }
    }
}
