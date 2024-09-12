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

        (double max, double min, double media)tempData(double[] array)
        {
            double max = array[0];
            double min = array[0];
            double media = array[0];
            for(int i = 1; i < TAM; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
                media += array[i];
            }
            //media = array.Average();
            //max = array.Max();
            //min = array.Min();
            media /= TAM;
            return (max, min, media);
        }

        void leerArray<T>(T[] array)
        {
            string salida = "";
            for(int i = 0; i < TAM; i++)
            {
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
            MessageBox.Show("Temperatura Maxima: " + tempData(v1).max.ToString());
            MessageBox.Show("Temperatura Minimo: " + tempData(v1).min.ToString());
            MessageBox.Show("Temperatura Media: " + tempData(v1).media.ToString());
        }
    }
}
