using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dividir_while(int n1, int n2)
        {
            int salida = 0;
            while(n1-n2 >= 0)
            {
                n1 -= n2;
                salida++;
            }
            return salida;
        }

        int dividir_for(int n1, int n2)
        {
            int i = 0;
            for(i = 0; n1-n2>=0; i++)
            {
                n1 -= n2;
            }
            return i;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);
            MessageBox.Show("El resultado con while es: " + dividir_while(num1, num2));
            MessageBox.Show("El resultado con for es: " + dividir_for(num1, num2));
        }
    }
}
