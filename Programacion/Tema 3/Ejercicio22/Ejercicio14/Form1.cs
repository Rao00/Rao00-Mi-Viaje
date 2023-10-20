using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Ejercicio22 : Form
    {
        public Ejercicio22()
        {
            InitializeComponent();
            
        }
        private void bInput_Click(object sender, EventArgs e)
        {
            int serie = int.Parse(txtSerie.Text);
            if (serie > 14681 && serie < 15681 || serie > 70001 && serie < 79999 || serie > 88888 && serie < 111111) MessageBox.Show("Esta defectuoso"); else MessageBox.Show("No esta defectuoso");
        }
    }
}
