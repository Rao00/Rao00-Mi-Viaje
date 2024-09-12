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

        double calcularMedia(double num)
        {
            double total = num/(double)TAM;
            return total;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double salida = 0;
            int tempNum = 0;
            data = txtDatos.Text.Split(',');
            foreach(string num in data)
            {
                tempNum = int.Parse(num);
                salida += tempNum;
            }
            MessageBox.Show("Media = " + calcularMedia(salida));
        }
    }
}
