using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class fPoligono : Form
    {
        List<Figura> lista;

        public fPoligono(List<Figura> list)
        {
            InitializeComponent();
            GenerarForma();
            this.lista = list;
        }

        private void btnAceptarForma_Click(object sender, EventArgs e)
        {
            try
            {
                int posX = int.Parse(txtX.Text);
                int posY = int.Parse(txtY.Text);
                string color = txtColor.Text;
                double tamLados = double.Parse(txtTamañoLados.Text);
                if (cbCiruclo.Checked == true)
                {
                    Circulo circulo = new Circulo(posX, posY, color, tamLados);
                    lista.Add(circulo);
                }
                if (cbCiruclo.Checked == false && int.Parse(txtCantidadLados.Text) != 4) 
                {
                    int numLados = int.Parse(txtCantidadLados.Text);
                    Poligono poligono = new Poligono(posX, posY, color, numLados, tamLados);
                    lista.Add(poligono);
                }
                if (cbCiruclo.Checked == false && int.Parse(txtCantidadLados.Text) == 4)
                {
                    double baseX = double.Parse(txtBase.Text);
                    Cuadrado cuadrado = new Cuadrado(posX, posY, color, tamLados, baseX);
                    lista.Add(cuadrado);
                }
            }
            catch { MessageBox.Show("Falta algun valor o alguno es invalido"); }
        }

        private void txtCantidadLados_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int numLados = int.Parse(txtCantidadLados.Text);
                GenerarForma(numLados);
                if(numLados == 4)
                {
                    txtBase.Enabled = true;
                }
            }
            catch
            {
                GenerarForma();
            }
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            try
            {
                string color = txtColor.Text;
                Color colorAsignar = System.Drawing.Color.FromName(color);
                if (Regex.Match(color, @"^[a-zA-Z]").Success)
                {
                    btnForma.BackColor = colorAsignar;
                }
                else { throw new Exception(); }
            }
            catch (Exception) { btnForma.BackColor = System.Drawing.Color.FromName("ControlDarkDark"); }
        }

        private void cbCiruclo_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCiruclo.Checked) 
            {
                txtCantidadLados.Enabled = false;
                lblTam.Text = "Radio";
                GenerarCirculo();
            }
            else 
            {
                lblTam.Text = "Tamaño de los Lados";
                txtCantidadLados.Enabled = true;
                try
                {
                    int numLados = int.Parse(txtCantidadLados.Text);
                    GenerarForma(numLados);
                }
                catch
                {
                    GenerarForma();
                }
            }
        }

        private Point[] GetRotatedBro(Point[] array, int grados)
        {
            double radianes = grados * Math.PI / 180;
            for (int i = 0; i < array.Length; i++)
            {
                array[i].X -= 115;
                array[i].Y -= 115;
                int rotatedX = (int)(array[i].X * Math.Cos(radianes) - array[i].Y * Math.Sin(radianes));
                int rotatedY = (int)(array[i].X * Math.Sin(radianes) + array[i].Y * Math.Cos(radianes));
                array[i].X = rotatedX + 115;
                array[i].Y = rotatedY + 115;
            }
            return array;
        }

        private void GenerarForma(int numLados = 3)
        {
            Point[] Lados = new Point[numLados];
            for (int i = 0; i < Lados.Length; i++)
            {
                Point punto = new Point();
                punto.X = (int)(115 + (4 * (20 * Math.Cos((2 * Math.PI * i) / numLados))));
                punto.Y = (int)(115 + (4 * (20 * Math.Sin((2 * Math.PI * i) / numLados))));
                Lados[i] = punto;
            }
            Lados = GetRotatedBro(Lados, 270);
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(Lados);
            this.btnForma.Region = new System.Drawing.Region(path);
        }

        private void GenerarCirculo()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(25, 25, btnForma.Width - 50, btnForma.Height - 50);
            this.btnForma.Region = new System.Drawing.Region(path);
        }
    }
}
