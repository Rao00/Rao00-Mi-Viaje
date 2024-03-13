using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public abstract class Figura<T>
    {
        private int x;
        private int y;
        private int nLados;
        private string mcolor;
        public int X 
        {
            get { return x; } 
            set { x = value; } 
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int NumeroLados
        {
            get { return nLados; }
            set { nLados = value; }
        }
        public string Color
        {
            get { return mcolor; }
            set { mcolor = value; }
        }

        public abstract T Perimetro();
        public abstract T Area();
        new public abstract string GetType();
        public abstract override string ToString();

        public Figura(int coordX, int coordY, int numeroLados , string color) 
        {
            x = coordX;
            y = coordY;
            mcolor = color;
            nLados = numeroLados;
        }
    }
}
