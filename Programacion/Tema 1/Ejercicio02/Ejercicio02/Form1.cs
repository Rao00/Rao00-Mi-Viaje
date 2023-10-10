using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class ejercicio02 : Form
    {
        public ejercicio02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_contenido_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_1.Text);
        }

        private void b_colorform_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void b_colortexto_Click(object sender, EventArgs e)
        {
            tb_1.ForeColor = Color.Red;
        }
    }
}
