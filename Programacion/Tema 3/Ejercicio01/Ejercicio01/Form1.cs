using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
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

        private void b_input_Click(object sender, EventArgs e)
        {
            
            try
            {
                int texto_entrada = int.Parse(tb_input.Text);
                switch (texto_entrada)
                {
                    case 2:
                        MessageBox.Show("Es el numero 2");
                        break;
                    default:
                        MessageBox.Show("No es el numero 2");
                        break;
                };
            }
            catch
            {
                MessageBox.Show("Introduce solo un numero");
            }
        }
    }
}
