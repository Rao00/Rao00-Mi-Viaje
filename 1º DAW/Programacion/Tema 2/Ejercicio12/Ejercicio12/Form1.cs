using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            l_total.Text = "Total Sin IVA = " + (int.Parse(tb_p1.Text) + int.Parse(tb_p2.Text) + int.Parse(tb_p3.Text)) + " €";
            l_iva.Text = "Total Con IVA = " + ((int.Parse(tb_p1.Text) + int.Parse(tb_p2.Text) + int.Parse(tb_p3.Text)+((int.Parse(tb_p1.Text) + int.Parse(tb_p2.Text) + int.Parse(tb_p3.Text))*0.21))) + " €";
        }
    }
}
