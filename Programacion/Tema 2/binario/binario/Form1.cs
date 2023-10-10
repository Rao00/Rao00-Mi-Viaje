using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            int dato_entero = int.Parse(tb_entrada.Text);
            int binario = int.Parse(tb_entrada.Text);
            List<int> binario_lista_salida = new List<int>{ };
            while (dato_entero > 0)
            {
                dato_entero = dato_entero/2;
                binario = dato_entero%2;
                binario_lista_salida.Add(binario);
            }
            binario_lista_salida.Reverse();
            l_salida.Text = "Binario = " + string.Join("",binario_lista_salida);
        }
    }
}
