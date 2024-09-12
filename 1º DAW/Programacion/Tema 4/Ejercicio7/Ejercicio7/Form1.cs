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
        int CalcularMCD(int num1, int num2)
        {
            int mcd = num1;
            if (num1>num2)
            {
                mcd = num2;
            }
            for (int i = mcd; num1%mcd != 0 || num2%mcd != 0; mcd--) ;
            return mcd;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            MessageBox.Show($"MCD de {num1} y {num2} = {CalcularMCD(num1, num2)}");
        }
    }
}
