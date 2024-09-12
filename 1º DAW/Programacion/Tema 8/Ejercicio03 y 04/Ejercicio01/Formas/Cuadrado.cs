using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Cuadrado : Figura
    {
        private double baseX;
        private double alturaY;

        public double Base
        { 
            get { return baseX; }
            set { baseX = value; }
        }

        public double Altura
        { 
            get { return alturaY; } 
            set { alturaY = value; } 
        }

        public override double Perimetro()
        {
            return baseX * 2 + alturaY * 2;
        }

        public override double Area()
        {
            return baseX * alturaY;
        }

        public override string GetType()
        {
            string nombre = "Cuadrado";
            return nombre;
        }

        public override string ToString()
        {
            string nombre = baseX == alturaY ? "Cuadrado" : "Rectangulo";
            string salida = $"{nombre}:\nCoordenadas = {X.ToString()}, {Y.ToString()}\nTamaño = {baseX} x {alturaY}\nPerimetro = {Perimetro()} cm\nArea = {Area()} cm2";
            return salida;
        }

        public Cuadrado(int coordX, int coordY, string color, double BaseX, double AlturaY, int numeroLados = 4) : base(coordX, coordY, numeroLados, color)
        {
            baseX = BaseX;
            alturaY = AlturaY;
        }
    }
}
