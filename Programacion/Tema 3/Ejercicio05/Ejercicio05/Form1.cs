using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bFinal_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tb1.Text);
            int num2 = int.Parse(tb2.Text);
            int num3 = int.Parse(tb3.Text);
            if (num1 < num3 && num2 < num3)
            {
                MessageBox.Show($"{num3} es el mayor");
            }
            else if (num2 < num1 && num3 < num1)
            {
                MessageBox.Show($"{num1} es el mayor");
            }
            else
            {
                MessageBox.Show($"{num2} es el mayor");
            }
        }
    }
}
