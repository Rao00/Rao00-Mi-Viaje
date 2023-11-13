using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CalcularMCM(int num1, int num2)
        {
            int mcm = num1;
            if (num1<num2)
            {
                mcm = num2;
            }
            for (int i = mcm; mcm%num1 != 0 || mcm%num2 != 0; mcm++) ;
            return mcm;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            MessageBox.Show($"MCM de {num1} y {num2} = {CalcularMCM(num1, num2)}");
        }
    }
}
