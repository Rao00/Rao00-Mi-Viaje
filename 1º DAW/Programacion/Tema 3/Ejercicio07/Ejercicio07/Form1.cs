using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bNum_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tb1.Text);
            switch (num)
            {
                case 0:
                    MessageBox.Show("Numero cero");
                    break;
                case 1:
                    MessageBox.Show("Numero uno");
                    break;
                case 2:
                    MessageBox.Show("Numero dos");
                    break;
                case 3:
                    MessageBox.Show("Numero tres");
                    break;
                case 4:
                    MessageBox.Show("Numero cuatro");
                    break;
                case 5:
                    MessageBox.Show("Numero cinco");
                    break;
                case 6:
                    MessageBox.Show("Numero seis");
                    break;
            }
        }
    }
}
