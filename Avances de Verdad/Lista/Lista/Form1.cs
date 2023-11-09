using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bLista_Click(object sender, EventArgs e)
        {
            MyList<string> Lista = new MyList<string>();
            string salida = Lista.add(txtInput.Text);
            MessageBox.Show("num = " + Lista);
        }
    }
}
