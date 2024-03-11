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

        List<Figura<double>> ListaFormas = new List<Figura<double>>();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(Interaction.InputBox("Posicion X"));
                int y = int.Parse(Interaction.InputBox("Posicion Y"));
                double radio = double.Parse(Interaction.InputBox("Radio"));
                Circulo circulo = new Circulo(x, y, radio);
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
                int baseX = int.Parse(Interaction.InputBox("Introduce la base"));
                int alturaY = int.Parse(Interaction.InputBox("Introduce la altura"));
                Cuadrado cuadrado = new Cuadrado(x, y, baseX, alturaY);
                AddForma("cuadrado", cuadrado);
            }
            catch 
            {
                MessageBox.Show("Datos invalidos");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMostarCirc_Click(object sender, EventArgs e)
        {
            string salida = string.Empty;
            foreach(Figura<double> figura in ListaFormas)
            {
                if (figura.GetType() == "Circulo")
                {
                    salida += figura.ToString();
                    salida += "\n\n";
                }
            }
            MessageBox.Show(salida);
        }

        private void AddForma(string tipoForma, Figura<double> figura)
        {
            ListaFormas.Add(figura);
            MessageBox.Show($"El {figura.GetType()} se ha creado");
        }


    }
}
