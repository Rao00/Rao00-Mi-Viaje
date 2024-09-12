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

        const int TAM = 20;

        (double max, double min, double media, int numMax, int numMin) tempData(double[] array)
        {
            double max = array[0];
            int numMax = 0;
            double min = array[0];
            int numMin = 0;
            double media = array[0];
            for (int i = 1; i < TAM; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
                media += array[i];
            }
            for (int j = 0; j < TAM; j++)
            {
                if (array[j] == max)
                    numMax++;
                if (array[j] == min)
                    numMin++;
            }
            //media = array.Average();
            //max = array.Max();
            //min = array.Min();
            media /= TAM;
            return (max, min, media, numMax, numMin);
        }

        void leerArray<T>(T[] array)
        {
            string salida = "";
            for (int i = 0; i < TAM; i++)
            {
                salida += $"Temp hora {i + 1} = {array[i]}º\n";
            }
            MessageBox.Show(salida);
        }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            double[] v1 = new double[TAM];
            var rand = new Random();
            for (int i = 0; i < TAM; i++)
            {
                v1[i] = rand.Next(0, TAM+1);
            }
            leerArray(v1);
            MessageBox.Show("Temperatura Maxima: " + tempData(v1).max.ToString() + " y se ha repetido " + tempData(v1).numMax);
            MessageBox.Show("Temperatura Minimo: " + tempData(v1).min.ToString() + " y se ha repetido " + tempData(v1).numMin);
            MessageBox.Show("Temperatura Media: " + tempData(v1).media.ToString());
        }
    }
}
