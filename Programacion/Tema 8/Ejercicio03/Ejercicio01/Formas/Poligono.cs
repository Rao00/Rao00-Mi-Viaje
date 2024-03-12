using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Poligono : Figura<double>
    {
        private double tamLado;
        private int lados;

        public double TamañoLados
        { 
            get { return tamLado; }
            set { tamLado = value; }
        }

        public int Lados
        {
            get { return lados; }
            set { lados = value; }
        }

        public override double Perimetro()
        {
            return tamLado * lados;
        }

        public override double Area()
        {
            return (lados * Math.Pow(tamLado,2)) / 4 * Math.Tan(Math.PI/lados);
        }

        public override string GetType()
        {
            return "Cuadrado";
        }

        public override string ToString()
        {
            string salida = $"Coordenadas = {X.ToString()}, {Y.ToString()}\nCantidad de lados = {lados}\nTamaño = tamLado cm\nPerimetro = {Perimetro()} cm\nArea = {Area()} cm2";
            return salida;
        }

        public Poligono(int coordX, int coordY, string color, double tamañoLados, int numLados) : base(coordX, coordY, color)
        {
            tamLado = tamañoLados;
            lados = numLados;
        }
    }
}
