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
            for (int i = 0; i <= numElegido; i+=2)
            {
                lSalida.Text += i + "\n";
            }
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            int numElegido = int.Parse(txtEntrada.Text);
            int i = 0;
            lSalida.Text = "";
            while (i < numElegido)
            {
                lSalida.Text += i + "\n";
                i += 2;
            }
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            int numElegido = int.Parse(txtEntrada.Text);
            int i = 0;
            lSalida.Text = "";
            do
            {
                lSalida.Text += i + "\n";
                i += 2;
            }
            while (i < numElegido);
        }
    }
}
