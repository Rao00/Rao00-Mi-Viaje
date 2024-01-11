using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagenes
{
    public partial class Form2 : Form
    {

        private Form1 FormPrincipal;

        public Form2(Form1 formPrincipal)
        {
            InitializeComponent();
            TimerBarra.Start();
            FormPrincipal = formPrincipal;
        }

        private void TextoProgreso(int progreso)
        {
            if (progreso == 20) { lTexto.Text = "Analizando los Astros..."; }
            if (progreso == 40) { lTexto.Text = "Realizando conexion nuerocuantica..."; }
            if (progreso == 60) { lTexto.Text = "Analizando tu lado neurodivergente..."; }
            if (progreso == 80) { lTexto.Text = "Hablando con tu subconsciente..."; }
            if (progreso == 100) { lTexto.Text = "Numero Adivinado!"; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbProgreso.Value < 100)
            {
                pbProgreso.Value++;
                TextoProgreso(pbProgreso.Value);
            }
            else
            {
                TimerBarra.Stop();
                MessageBox.Show("Has pensado en el numero: " + FormPrincipal.num);
                this.Close();
            }
        }
    }
}
