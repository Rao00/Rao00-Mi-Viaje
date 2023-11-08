using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ResEntero(int num1, int num2, out int entero, out int resto)
        {
            entero = num1/num2;
            resto = num1%num2;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);
            int entero, resto;
            ResEntero(num1, num2, out entero, out resto);
            MessageBox.Show("Entero = " + entero + "\nResto = " + resto);
        }
    }
}
