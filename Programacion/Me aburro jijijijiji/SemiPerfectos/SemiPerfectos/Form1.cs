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

        int[] CalcularDivisores(int num)
        {
            int[] array = new int[num / 2];
            int a = 0;
            for (int i = 1; i < num; i++)
            {
                if(num % i == 0) { array[a] = i; a++ ; }
            }
            return array;
        }

        bool NumSemiPerfecto(int[] divisores, int num)
        {
            bool salida = false;
            int total = 0;
            for(int i = 0; i < divisores.Length; i++)
            {
                total = divisores[i];
                for (int j = 0; j < divisores.Length; j++)
                {
                    for (int k = 0; k <= j; k++)
                    {
                        if(divisores[i] != divisores[k])
                            total += divisores[k];
                        if(total == num) { salida = true; break; }
                    }
                    if (total == num) { salida = true; break; }
                    total = 0;
                }
                if (total == num) { break; }
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
