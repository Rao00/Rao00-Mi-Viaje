using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioAyudaPorFavor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalcularBilletes(double dinero, List<double> tamaño, string salida, string type, int billeteMinimo, int tempLista = 0)
        {
            if (dinero > 0 && tempLista <= tamaño.Count()-1)
            {
                double num = dinero/tamaño[tempLista];
                if(num >= 1)
                {
                    num = Math.Floor(num);
                    if (tamaño[tempLista] < billeteMinimo)
                    {
                        salida += "\n" + num + " monedas de " + tamaño[tempLista] + " " + type;
                    }
                    else
                    {
                        salida += "\n" + num + " billetes de " + tamaño[tempLista] + " " + type;
                    }
                    dinero -= num*tamaño[tempLista];
                    return CalcularBilletes(dinero, tamaño, salida, type, billeteMinimo, tempLista+=1);
                }
                else return CalcularBilletes(dinero, tamaño, salida, type, billeteMinimo, tempLista+=1);
            }
            else
            {
                string salidaTemp = "\n"+salida;
                return salidaTemp;
            }
        }

        private void bCalcular_Click_1(object sender, EventArgs e)
        {
            string salida = "";
            string type = txtType.Text;
            int billeteMin = int.Parse(txtBilleteMin.Text);
            double numPesetas = double.Parse(txtPesetas.Text);
            List<double> billetes = new List<double> { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
            lResultado.Text = CalcularBilletes(numPesetas, billetes, salida, type, billeteMin);
        }
    }
}
