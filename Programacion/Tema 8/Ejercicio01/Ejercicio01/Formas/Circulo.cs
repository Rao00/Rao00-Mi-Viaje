using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Circulo : Figura<double>
    {
        private double mRadio;

        public double Radio
        {
            get { return mRadio; }
            set { mRadio = value; }
        }

        public override double Perimetro()
        {
            return 2*Math.PI*mRadio;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(mRadio, 2));
        }

        public override string GetType()
        {
            return "Circulo";
        }

        public override string ToString()
        {
            string salida = $"Coordenadas = {X.ToString()}, {Y.ToString()}\nTamaño = {mRadio} cm\nPerimetro = {Perimetro()}\nArea = {Area()}";
            return salida;
        }

        public Circulo(int coordX, int coordY, double radio) : base(coordX, coordY)
        {
            mRadio = radio;
        }
    }
}
