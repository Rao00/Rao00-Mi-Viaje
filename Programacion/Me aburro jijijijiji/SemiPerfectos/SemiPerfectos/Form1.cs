using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemiPerfectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> CalcularDivisores(int num)
        {
            List<int> lista = new List<int>();
            for (int i = 1; i < num; i++)
            {
                if(num % i == 0) { lista.Add(i); }
            }
            return lista;
        }

        bool NumSemiPerfecto(List<int> divisores, int num)
        {
            int total;
            for(int i = 0; i < divisores.Count(); i++) //Numero principal
            {
                total = divisores[i];
                for(int j = i; j < divisores.Count(); j++) //Tamaño suma
                {
                    for(int k = 0; k < divisores.Count(); k++) //Num a saltar
                    {
                        for(int l = k; l <= j; l++) //Suma principal
                        {
                            if (divisores[i] != divisores[l]) { total += divisores[l]; }
                            if (total == num) { return true; }
                        }
                        total = divisores[i];
                    }
                    total = divisores[i];
                }
            }
            return false;
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            MessageBox.Show(NumSemiPerfecto(CalcularDivisores(num), num).ToString());
        }
    }
}
