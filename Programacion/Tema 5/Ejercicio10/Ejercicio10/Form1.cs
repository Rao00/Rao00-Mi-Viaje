using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 10;

        void leerArray<T>(T[] array)
        {
            string salida = "";
            foreach(T data in array)
            {
                salida += data + " ";
            }
            MessageBox.Show(salida);
        }

        void shiftRight<T>(T[] array)
        {
            T aux = array[TAM-1];
            for(int i = TAM-1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = aux;
            leerArray(array);
        }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            string[] v1 = new string[TAM];
            for (int i = 0; i < TAM; i++)
            {
                v1[i] = "a" + i;
            }
            leerArray(v1);
            shiftRight(v1);
        }
    }
}
