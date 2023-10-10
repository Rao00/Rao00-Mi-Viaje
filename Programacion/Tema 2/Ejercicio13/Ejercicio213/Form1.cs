using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int pago = int.Parse(tb_pago.Text);
            int pago_horas = int.Parse(tb_horas.Text)*pago;
            int pago_extras = int.Parse(tb_extra.Text)*pago*2;
            const double retencion = 0.18;
            try
            {
                l_resultado.Text = "Nomina = " + (pago_horas+pago_extras-((pago_horas+pago_extras)*retencion)) + " €";
            }
            catch
            {
                MessageBox.Show("Error");
            }
           
        }
    }
}
