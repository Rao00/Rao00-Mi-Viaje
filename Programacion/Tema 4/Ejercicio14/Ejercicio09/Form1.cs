using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calcularPesetas(int numPesetas)
        {
            int num10k = numPesetas/10000;
            numPesetas -= num10k*10000;
            int num5k = numPesetas/5000;
            numPesetas -= num5k*5000;
            int num2k = numPesetas/2000;
            numPesetas -= num2k*2000;
            int num1k = numPesetas/1000;
            numPesetas -= num1k*1000;
            int num100 = numPesetas/100;
            numPesetas -= num100*100;
            int num25 = numPesetas/25;
            string output = "Resultado";
            if (num10k > 0)
            {
                output += "\n" + num10k + " billetes de 10000";
            }
            if (num5k > 0)
            {
                output += "\n" + num5k + " billetes de 5000";
            }
            if (num2k > 0)
            {
                output += "\n" + num2k + " billetes de 2000";
            }
            if (num1k > 0)
            {
                output += "\n" + num1k + " billetes de 1000";
            }
            if (num100 > 0)
            {
                output += "\n" + num100 + " monedas de 100";
            }
            if (num25 > 0)
            {
                output += "\n" + num25 + " monedas de 25";
            }
            return output;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int numPesetas = int.Parse(txtPesetas.Text); 
            lResultado.Text = calcularPesetas(numPesetas);
        }
    }
}
