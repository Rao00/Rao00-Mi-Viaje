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
            int[] v1 = new int[TAM];
            var rand = new Random();
            int i = 0;
            int j = 0;
            while (i < TAM)
            {
                v1[i] = rand.Next(0, TAM);
                j = i - 1;
                while(j >= 0)
                {
                    if(v1[i] == v1[j])
                    {
                        j = -1;
                        i--;
                    }
                    j--;
                }
                i++;
            }
            leerArray(v1);
        }
    }
}
