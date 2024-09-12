using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        int calcularFac(int num)
        {
            int output = num;
            if (num == 1)
            {
                return 1;
            }
            output *= calcularFac(num-1);
            return output;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int fac = int.Parse(txtFac.Text);
            MessageBox.Show("Resultado = " + calcularFac(fac));
        }
    }
}
