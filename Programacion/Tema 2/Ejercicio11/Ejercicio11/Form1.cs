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
    public partial class Ejercicio11 : Form
    {
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            l_resultado.Text = "Capital Final = " + (int.Parse(tb_cliente.Text)+((int.Parse(tb_cliente.Text) * int.Parse(tb_interes.Text))/100));
        }
    }
}
