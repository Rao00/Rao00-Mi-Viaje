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
            for(int m = 0; m > 0; m++)
            {
                //for(int i = 0; i < divisores.Count(); i++)
                //{
                //    total = divisores[i];
                //    for (int j = 0; j < divisores.Count(); j++)
                //    {
                //        for (int k = 0; k <= j; k++)
                //        {
                //            if (divisores[i] != divisores[k]) { total += divisores[k]; }
                //            if (total == num) { salida = true; break; }
                //            MessageBox.Show(total.ToString());
                //        }
                //        if (total == num) { salida = true; break; }
                //        total = divisores[i];
                //    }
                //    if (total == num) { break; }
                //}
            }
            for(int i = 0; i < divisores.Count(); i++) //Numero principal
            {
                for(int j = i; j < divisores.Count(); j++) //Tamaño suma
                {
                    for(int k = 0; k < ) //
                }
            }
            return salida;
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            MessageBox.Show(NumSemiPerfecto(CalcularDivisores(num), num).ToString());
        }
    }
}
