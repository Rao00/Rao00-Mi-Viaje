using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Poligono : Figura
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
            double alfa = (360 / lados) / 2;
            double radianes = (Math.PI / 180) * alfa;
            return Math.Round((lados * (tamLado * tamLado)) / (4 * Math.Tan(radianes)),2);
        }

        public override string GetType()
        {
            return "Poligono";
        }

        public override string ToString()
        {
            string salida = $"Poligono de {lados} lados:\nCoordenadas = {X.ToString()}, {Y.ToString()}\nCantidad de lados = {lados}\nTamaño = {tamLado} cm\nPerimetro = {Perimetro()} cm\nArea = {Area()} cm2";
            return salida;
        }

        public Poligono(int coordX, int coordY, string color, int numLados, double tamañoLados) : base(coordX, coordY, numLados, color)
        {
            tamLado = tamañoLados;
            lados = numLados;
        }
    }
}
