using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lHora_Click(object sender, EventArgs e)
        {

        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int hora = int.Parse(txtHora.Text);
            int min = int.Parse(txtMinuto.Text);
            int seg = int.Parse(txtSegundo.Text);
            if (hora < 0 || hora > 23)
            {
                MessageBox.Show("Hora no valida");
                return;
            }
            if (min < 0 || min > 59)
            {
                MessageBox.Show("Minuto no valido");
                return;
            }
            if (seg < 0 || seg > 59)
            {
                MessageBox.Show("Hora no valida");
                return;
            }

            seg += 1;

            if (seg == 60)
            {
                seg = 0;
                min += 1;
            }
            if (min == 60)
            {
                min = 0;
                hora += 1;
            }
            if (hora == 24)
            {
                hora = 00;
            }
            MessageBox.Show($"La hora siguiente sera {hora} : {min} : {seg}");
        }
    }
}
