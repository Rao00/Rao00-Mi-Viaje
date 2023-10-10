using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton_smr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo SMR");
        }

        private void boton_bach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo Bach");
        }

        private void boton_otro_Click(object sender, EventArgs e)
        {
            tb_otro.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            l_otro.Text = tb_otro.Text;
        }
    }
}
