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
            data = txtDatos.Text.Split(',');
            string menor = data[0];
            int intLista = 0;
            int salida = int.Parse(menor);
            foreach(string num in data)
            {
                intLista = int.Parse(num);
                if(intLista < salida)
                {
                    salida = intLista;
                }
            }
            MessageBox.Show("Menor = " + salida);
        }
    }
}
