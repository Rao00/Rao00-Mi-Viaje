using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int elevar(int num1, int num2)
        {
            if(num2 == 1)
            {
                return num1;
            }
            int salida = num1;
            salida += elevar(num1, num2-1);
            return salida;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            MessageBox.Show("Resultado = " + elevar(num1, num2));
        }
    }
}
