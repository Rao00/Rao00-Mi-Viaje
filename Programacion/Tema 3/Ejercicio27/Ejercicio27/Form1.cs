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
            bool primo = true;
            for (int i = 2; i<num; i++)
            {
                if (num%i == 0 && primo == true)
                {
                    primo = false;
                }
            }
            if (primo == false || num == 1)
            {
                MessageBox.Show("No es primo");
            }
            else
            {
                MessageBox.Show("Es primo");
            }
        }
    }
}
