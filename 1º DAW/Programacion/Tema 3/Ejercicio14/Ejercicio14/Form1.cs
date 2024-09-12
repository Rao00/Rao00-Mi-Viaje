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
            for (int i = numElegido; i <= numElegido+10; i++)
            {
                lSalida.Text += i + "\n";
            }
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            int numElegido = int.Parse(txtEntrada.Text);
            int i = numElegido;
            lSalida.Text = "";
            while (i <= numElegido+10)
            {
                lSalida.Text += i + "\n";
                i ++;
            }
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            int numElegido = int.Parse(txtEntrada.Text);
            int i = numElegido;
            lSalida.Text = "";
            do
            {
                lSalida.Text += i + "\n";
                i ++;
            }
            while (i <= numElegido+10);
        }
    }
}
