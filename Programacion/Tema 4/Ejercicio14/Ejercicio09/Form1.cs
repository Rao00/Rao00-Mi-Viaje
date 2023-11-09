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

        (int dinero, int cantidad, string salida) CalcularBilletes(int dinero, int tamaño, string salida, string type, int billeteMinimo)
        {
            int num = dinero/tamaño;

            if (dinero > 0)
            {
                if(tamaño <= billeteMinimo)
                {
                    salida = "\n" + num + " monedas de " + tamaño + " " + type;
                }
                else
                {
                    salida = "\n" + num + " billetes de " + tamaño + " " + type;
                }
                dinero -= num*tamaño;
            }
            return (dinero, num, salida);
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string salida = "";
            string type = txtType.Text;
            int billeteMin = int.Parse(txtBilleteMin.Text);
            int numPesetas = int.Parse(txtPesetas.Text);
            List<int> billetes = new List<int> {5000, 1000, 500, 200, 100, 50, 25, 10, 5, 2, 1};
            foreach (int tamaño in billetes)
            {
                if (CalcularBilletes(numPesetas, tamaño, salida, type, billeteMin).cantidad > 0)
                {
                    salida += CalcularBilletes(numPesetas, tamaño, salida, type, billeteMin).salida;
                    numPesetas = CalcularBilletes(numPesetas, tamaño, salida, type, billeteMin).dinero;
                }
            }
            lResultado.Text = salida;
        }
    }
}
