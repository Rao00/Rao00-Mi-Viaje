using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Ejercicio03 : Form
    {
        public Ejercicio03()
        {
            InitializeComponent();
        }

        private void b_01_Click(object sender, EventArgs e)
        {
            tb_01.Text = "Este es el boton numero 1";
        }

        private void b_02_Click(object sender, EventArgs e)
        {
            tb_01.Text = "Este es el boton numero 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           tb_01.Clear();
        }
    }
}
