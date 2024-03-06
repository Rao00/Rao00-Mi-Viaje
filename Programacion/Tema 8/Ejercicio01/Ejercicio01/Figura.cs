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

        public abstract T Perimetro();
        public abstract T Area();

        public Figura(int x, int y) 
        {
            X = x;
            Y = y;
        }
    }
}
