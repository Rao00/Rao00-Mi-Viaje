using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Figura> ListaFormas = new List<Figura>();

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string salida = MostrarFormas("Poligono");
            salida += MostrarFormas("Cuadrado");
            if (salida == string.Empty)
            {
                MessageBox.Show($"No hay poligonos que mostrar");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }

        private void btnMostarCirc_Click(object sender, EventArgs e)
        {
            string salida = MostrarFormas("Circulo");
            if (salida == string.Empty)
            {
                MessageBox.Show($"No hay circulos que mostrar");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            string salida = MostrarFormas();
            if (salida == string.Empty)
            {
                MessageBox.Show($"No hay formas que mostrar");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }

        private void btnMostrarLados_Click(object sender, EventArgs e)
        {
            try
            {
                int nlados = int.Parse(Interaction.InputBox("Cantidad de lados del poligono"));
                string salida = MostrarFormas(nlados);
                if (salida == string.Empty)
                {
                    MessageBox.Show($"No hay poligonos de {nlados} lados que mostrar");
                }
                else
                {
                    MessageBox.Show(salida);
                }
            }
            catch { MessageBox.Show("Introduce un valor valido"); }
        }

        private string MostrarFormas(int numLados)
        {
            string salida = string.Empty;
            foreach (Figura figura in ListaFormas)
            {
                if (figura.NumeroLados == numLados)
                {
                    salida += figura.ToString();
                    salida += "\n\n";
                }
            }
            return salida;
        }

        private string MostrarFormas(string forma)
        {
            string salida = string.Empty;
            foreach (Figura figura in ListaFormas)
            {
                if (figura.GetType() == forma)
                {
                    salida += figura.ToString();
                    salida += "\n\n";
                }
            }
            return salida;
        }

        private string MostrarFormas()
        {
            string salida = string.Empty;
            foreach (Figura figura in ListaFormas)
            {
                salida += figura.ToString();
                salida += "\n\n";
            }
            return salida;
        }

        private void btnCrearPoli_Click(object sender, EventArgs e)
        {
            fPoligono form = new fPoligono(ListaFormas);
            form.ShowDialog();
        }
    }
}
