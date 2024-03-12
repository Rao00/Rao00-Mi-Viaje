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

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(3, 3, this.btnCrearCircl.Width-10, this.btnCrearCircl.Height-10);
            this.btnCrearCircl.Region = new System.Drawing.Region(path);
        }

        public List<Figura<double>> ListaFormas = new List<Figura<double>>();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(Interaction.InputBox("Posicion X"));
                int y = int.Parse(Interaction.InputBox("Posicion Y"));
                string color = Interaction.InputBox("Color");
                double radio = double.Parse(Interaction.InputBox("Radio"));
                Circulo circulo = new Circulo(x, y, color, radio);
                AddForma("circulo", circulo);
            }
            catch 
            {
                MessageBox.Show("Datos invalidos");
            }
            
        }

        private void btnCrearCuadr_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(Interaction.InputBox("Posicion X"));
                int y = int.Parse(Interaction.InputBox("Posicion Y"));
                string color = Interaction.InputBox("Color");
                int baseX = int.Parse(Interaction.InputBox("Introduce la base"));
                int alturaY = int.Parse(Interaction.InputBox("Introduce la altura"));
                Cuadrado cuadrado = new Cuadrado(x, y, color, baseX, alturaY);
                AddForma("cuadrado", cuadrado);
            }
            catch 
            {
                MessageBox.Show("Datos invalidos");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string salida = MostarFormas("Cuadrado");
            if (salida == string.Empty)
            {
                MessageBox.Show($"No hay cuadrados que mostrar");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }

        private void btnMostarCirc_Click(object sender, EventArgs e)
        {
            string salida = MostarFormas("Circulo");
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
            string salida = MostarFormas();
            if (salida == string.Empty)
            {
                MessageBox.Show($"No hay formas que mostrar");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }

        private string MostarFormas(string forma)
        {
            string salida = string.Empty;
            foreach (Figura<double> figura in ListaFormas)
            {
                if (figura.GetType() == forma)
                {
                    salida += figura.ToString();
                    salida += "\n\n";
                }
            }
            return salida;
        }

        private string MostarFormas()
        {
            string salida = string.Empty;
            foreach (Figura<double> figura in ListaFormas)
            {
                salida += figura.ToString();
                salida += "\n\n";
            }
            return salida;
        }

        private void AddForma(string tipoForma, Figura<double> figura)
        {
            ListaFormas.Add(figura);
            MessageBox.Show($"El {figura.GetType()} se ha creado");
        }

        private void btnCrearPoli_Click(object sender, EventArgs e)
        {
            fPoligono form = new fPoligono(ListaFormas);
            form.ShowDialog();
        }
    }
}
