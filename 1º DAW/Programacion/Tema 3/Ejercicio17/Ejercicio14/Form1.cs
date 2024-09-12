using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Ejercicio12 : Form
    {
        public Ejercicio12()
        {
            InitializeComponent();
            
        }
        private void bInput_Click(object sender, EventArgs e)
        {
            int NUM = 100;
            lSalida.Text = "";
            for (int i = 0; i <= NUM; i+=3)
            {
                lSalida.Text += i + "\n";
            }
        }

        private void bCalcularWhile_Click(object sender, EventArgs e)
        {
            int NUM = 100;
            int i = 0;
            lSalida.Text = "";
            while (i <= NUM)
            {
                lSalida.Text += i + "\n";
                i+=3;
            }
        }

        private void bCalcularDOWHILE_Click(object sender, EventArgs e)
        {
            int NUM = 100;
            int i = 0;
            lSalida.Text = "";
            do
            {
                lSalida.Text += i + "\n";
                i+=3;
            }
            while (i <= NUM);
        }
    }
}
