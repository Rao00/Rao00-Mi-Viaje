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

        const int TAM = 10;
        string[] data = new string[TAM];

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string salida = "";
            data = txtDatos.Text.Split(',');
            foreach(string num in data)
            {
                salida += num + ", ";
            }
            MessageBox.Show(salida);
        }
    }
}
