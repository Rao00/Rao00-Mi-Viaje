using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public abstract class Figura<T>
    {
        private int x;
        private int y;
        private string color;
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
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public abstract T Perimetro();
        public abstract T Area();
        new public abstract string GetType();
        public abstract override string ToString();

        public Figura(int coordX, int coordY) 
        {
            x = coordX;
            y = coordY;
        }
    }
}
