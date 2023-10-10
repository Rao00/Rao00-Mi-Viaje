using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCal_Click(object sender, EventArgs e)
        {
            try
            {
                double nota = double.Parse(tbNota.Text);
                if (nota >= 0 && nota <= 10)
                {
                    if (nota <= 3)
                    {
                        MessageBox.Show("Nota muy deficiente");
                    }
                    else if (nota < 5)
                    {
                        MessageBox.Show("Nota insuficiente");
                    }
                    else if (nota < 6)
                    {
                        MessageBox.Show("Nota suficiente");
                    }
                    else if (nota < 7)
                    {
                        MessageBox.Show("Nota bien");
                    }
                    else if (nota < 9)
                    {
                        MessageBox.Show("Nota notable");
                    }
                    else if (nota <= 10)
                    {
                        MessageBox.Show("Nota sobresaliente");
                    }
                }
                else
                {
                    MessageBox.Show("Nota no contemplada");
                }
            }
            catch
            {
                MessageBox.Show("Formato incorrecto");
            }
        }
    }
}
