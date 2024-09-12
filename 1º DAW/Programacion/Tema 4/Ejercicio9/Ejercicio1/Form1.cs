using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int elevar(int num1, int num2)
        {
            for (int i = 1; i < num2; i++)
            {
                num1 += num1;
            }
            return num1;
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);
            int resultado = elevar(n1, n2);
            MessageBox.Show("El resultado es " + resultado);
        }
    }
}
