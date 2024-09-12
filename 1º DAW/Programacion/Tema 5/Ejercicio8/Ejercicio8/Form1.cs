using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 5;

        void invertirArray(int[] array)
        {
            int[] vTemp = new int[TAM];
            int j = 0;
            for(int i = TAM-1; i >= 0; i--)
            {
                vTemp[i] = array[j];
                j++;
            }
            leerArray(vTemp);
        }

        void leerArray(int[] array)
        {
            string salida = "";
            foreach (int valor in array)
            {
                salida += valor.ToString();
            }
            MessageBox.Show(salida);
        }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            int[] v1 = new int[TAM];
            for(int i = 0; i < TAM; i++)
                v1[i] = i+1;
            invertirArray(v1);
            leerArray(v1);
        }
    }
}
