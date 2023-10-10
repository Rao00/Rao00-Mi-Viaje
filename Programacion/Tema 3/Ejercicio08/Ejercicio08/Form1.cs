using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        string salida = "Texto: ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string entrada = txtNew.Text;
            salida += "\n" + entrada;
            label1.Text = salida;
        }
    }
}
