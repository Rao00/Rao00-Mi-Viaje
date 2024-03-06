using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
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
            return 2*Math.PI*mRadio;
        }

        public Circulo(int coordX, int coordY, double radio) : base(coordX, coordY)
        {
            mRadio = radio;
        }
    }
}
