using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 24;

        (double media, double[] valores)tempData(double[] array)
        {
            double[] vMayores = new double[TAM];
            double media = array[0];
            int j = 0;
            int k = 0;
            for(int i = 1; i < TAM; i++)
            {
                media += array[i];
            }
            media /= TAM;
            //media = array.Average();
            //max = array.Max();
            //min = array.Min();
            while(j<TAM)
            {
                if (array[j] >= media)
                {
                    vMayores[k] = array[j];
                    j++;
                    k++;
                }
                else
                    j++;  
            }
            return (Math.Round(media,2), vMayores);
        }

        void leerArray(double[] array)
        {
            string salida = "";
            for(int i = 0; i < TAM; i++)
            {
                if(array[i] != 0)
                    salida += $"Temp hora {i+1} = {array[i]}º\n";
            }
            MessageBox.Show(salida);
        }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            double[] v1 = new double[TAM];
            var rand = new Random();
            for (int i = 0; i < TAM; i++)
            {
                v1[i] = Math.Round((rand.NextDouble() * 40), 2);
            }
            leerArray(v1);
            leerArray(tempData(v1).valores);
            MessageBox.Show("Temperatura Media: " + tempData(v1).media.ToString() + "º");
        }
    }
}
