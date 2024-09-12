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
            int pot = int.Parse(txtExp.Text);
            int numBase = int.Parse(txtBase.Text);
            int salida = 1;

            for (int i = pot; i >= 1; i--)
            {
                salida *= numBase;
            }
            lSalida.Text = salida.ToString();
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            int pot = int.Parse(txtExp.Text);
            int numBase = int.Parse(txtBase.Text);
            int salida = 1;
            int i = pot;

            while (i >= 1)
            {
                salida *= numBase;
                i--;
            }
            lSalida.Text = salida.ToString();
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            int pot = int.Parse(txtExp.Text);
            int numBase = int.Parse(txtBase.Text);
            int salida = 1;
            int i = pot;

            do
            {
                salida *= numBase;
                i--;
            }
            while (i >= 1);
            lSalida.Text = salida.ToString();
        }
    }
}
