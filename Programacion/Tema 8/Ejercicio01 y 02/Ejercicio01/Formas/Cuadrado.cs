using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Cuadrado : Figura<double>
    {
        private int baseX;
        private int alturaY;

        public int Base
        { 
            get { return baseX; }
            set { baseX = value; }
        }

        public int Altura
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
            return "Cuadrado";
        }

        public override string ToString()
        {
            string salida = $"Coordenadas = {X.ToString()}, {Y.ToString()}\nTamaño = {baseX} x {alturaY}\nPerimetro = {Perimetro()} cm\nArea = {Area()} cm2";
            return salida;
        }

        public Cuadrado(int coordX, int coordY, int BaseX, int AlturaY) : base(coordX, coordY)
        {
            baseX = BaseX;
            alturaY = AlturaY;
        }
    }
}
