using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Circulo : Figura
    {
        private double mRadio;

        public double Radio
        {
            get { return mRadio; }
            set { mRadio = value; }
        }

        public override double Perimetro()
        {
            return Math.Round(2*Math.PI*mRadio,2);
        }

        public override double Area()
        {
            return Math.Round(Math.PI * (Math.Pow(mRadio, 2)),2);
        }

        public override string GetType()
        {
            return "Circulo";
        }

        public override string ToString()
        {
            string salida = $"Circulo:\nCoordenadas = {X.ToString()}, {Y.ToString()}\nTamaño = {mRadio} cm\nPerimetro = {Perimetro()} cm\nArea = {Area()} cm2";
            return salida;
        }

        public Circulo(int coordX, int coordY, string color, double radio, int numeroLados = 0) : base(coordX, coordY, numeroLados, color)
        {
            mRadio = radio;
        }
    }
}
