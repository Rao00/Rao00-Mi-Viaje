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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_com_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tb_1.Text);
            int num2 = int.Parse(tb_2.Text);
            bool num_fin = num1 < num2;
            switch (num_fin)
            {
                case true:
                    MessageBox.Show($"El {num1} es menor que el {num2}");
                    break;
                default:
                    MessageBox.Show($"El {num1} es mayor o igual que el {num2}");
                    break;
            }
        }
    }
}
