using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anio = int.Parse(txtAnio.Text);
            if (anio%4 == 0)
            {
                if (anio%100 != 0 && anio%400 != 0)
                {
                    MessageBox.Show("Es Bisiesto");
                }
                else
                {
                    MessageBox.Show("No es Bisiesto");
                }
            }
            else
            {
                MessageBox.Show("No es Bisiesto");
            }
        }
    }
}
