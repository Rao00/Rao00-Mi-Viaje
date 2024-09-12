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

        private void b_sum_Click(object sender, EventArgs e)
        {
            {
                tb_out.Text = ("Mides " + (int.Parse(tb_1.Text)/100).ToString() + " m con " + (int.Parse(tb_1.Text)%100).ToString() + " cm");
            }
        }
        private void b_res_Click(object sender, EventArgs e)
        {
        }
    }
}
