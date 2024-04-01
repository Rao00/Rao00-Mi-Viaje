using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_de_Gestion_de_Camas
{
    public partial class pruebas : Form
    {
        public pruebas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Control panel = Paneles.General(0, 0, 50, 200, "Principal", Color.AliceBlue);
            this.Controls.Add(panel);
            this.Refresh();
        }
    }
}
