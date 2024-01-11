using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Imagenes
{
    public partial class Form1 : Form
    {

        private Form2 LoadingBar;

        public Form1()
        {
            InitializeComponent();
        }

        public int num { get; set; }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                num = random.Next(0, num);
                LoadingBar = new Form2(this);
                LoadingBar.Show();
            }
            catch 
            {
                MessageBox.Show("Introduce un numero entero por favor");
            }
            

        }
    }
}
