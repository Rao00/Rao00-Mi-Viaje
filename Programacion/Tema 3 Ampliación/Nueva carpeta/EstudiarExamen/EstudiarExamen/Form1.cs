using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudiarExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int mcd = num1;
            if (mcd < num2) { mcd = num2; }
            int mcm = mcd;
            for (int i = mcd; num1%mcd != 0 || num2%mcd != 0; mcd--) ;
            for (int i = mcm; mcm%num1 != 0 || mcm%num2 != 0; mcm++) ;
            MessageBox.Show($"Maximo comun divisor de {num1} y {num2} = {mcd}");
            MessageBox.Show($"Minimo comun multiplo de {num1} y {num2} = {mcm}");
        }
    }
}
