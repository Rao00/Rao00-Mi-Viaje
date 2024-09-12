using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 10;
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];
        bool[] resultado = new bool[TAM];

        void sumarVectores(int[] vectorA, int[] vectorB)
        {
            for (int i = 0; i < TAM; i++)
            {
                if(vectorA[i] == vectorB[i])
                {
                    resultado[i] = true;
                }
            }
        }

        string leerVector(bool[] vector)
        {
            string salida = "";
            for(int i = 0; i < TAM; i++)
            {
                if(resultado[i] == false)
                {
                    salida = "No es igual";
                    i = TAM;
                }
                else
                {
                    salida = "Es igual";
                }
            }
            return salida;
        }

        private void bPrin_Click(object sender, EventArgs e)
        {
            int num = 0;
            for(int i = 0; i < TAM; i++)
            {
                num = int.Parse(Interaction.InputBox("Introduce datos del vector 1", $"Introduce el dato {i+1} del vector 1", "Introduce datos"));
                vector1[i] = num;
            }
            for (int i = 0; i < TAM; i++)
            {
                num = int.Parse(Interaction.InputBox($"Introduce datos del vector 2", $"Introduce el dato {i+1} del vector 2", "Introduce datos"));
                vector2[i] = num;
            }
            sumarVectores(vector1, vector2);
            MessageBox.Show("Resultado = " + leerVector(resultado));
        }
    }
}
