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
        string CalcularBilletes(int dinero, List<int> tamaño, string salida, string type, int billeteMinimo, int tempLista = 0)
        {
            if (dinero % tamaño.Last() == 0)
            {
                if (dinero > 0)
                {
                    int num = dinero/tamaño[tempLista];
                    if(num > 0)
                    {
                        if (tamaño[tempLista] <= billeteMinimo)
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
                }
                else
                {
                    string salidaTemp = "";
                    salidaTemp += "\n"+salida;
                    return salidaTemp;
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar el calculo con los digitos disponibles, agrega más monedas en la lista para solucionar el error");
                return "error";
            }
        }

        private void bCalcular_Click_1(object sender, EventArgs e)
        {
            string salida = "";
            string type = txtType.Text;
            int billeteMin = int.Parse(txtBilleteMin.Text);
            int numPesetas = int.Parse(txtPesetas.Text);
            List<int> billetes = new List<int> { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            lResultado.Text = CalcularBilletes(numPesetas, billetes, salida, type, billeteMin);
        }
    }
}
