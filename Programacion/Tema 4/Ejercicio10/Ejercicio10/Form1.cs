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

        List<int> numElevar(int num, List<int> expoTotal)
        {
            List<int> salida = new List<int> { };
            foreach (int expo in expoTotal)
            {
                int resultado = num;
                for(int i = 1; i < expo; i++)
                {
                    resultado *= num;
                }
                salida.Add(resultado);
            }
            return salida;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            List<int> exponentes = new List<int> {2,5,7};
            string salida = "El resultado es: ";
            foreach(int numElevado in numElevar(num, exponentes))
            {
                salida += numElevado + " ";
            }
            MessageBox.Show(salida);
        }
    }
}
