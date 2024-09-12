using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bPrimo_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtPrimo.Text);
            int num2 = int.Parse(txtPrimo2.Text);
            string salida = "";
            if (num < num2)
            {
                MessageBox.Show("El numero de la izquierda tiene que ser mayor que el de la derecha");
            }
            for (int i = num2; i < num; i++)
            {
                bool primo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i%j == 0 && primo == true)
                    {
                        primo = false;
                    }
                }
                if (primo == true)
                {
                    salida += i + ", ";
                }
            }
            MessageBox.Show(salida);
        }
    }
}
