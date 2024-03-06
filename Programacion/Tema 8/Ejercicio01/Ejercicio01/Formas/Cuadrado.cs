using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Cuadrado : Figura
    {
        private int baseX;
        private int alturaY;

        public int Base
        { 
            get { return baseX; }
            set { baseX = value; }
        }

        public int AlturaY
        { 
            get { return alturaY; } 
            set { alturaY = value; } 
        }

        public override int Perimetro()
        {
            return baseX * 2 + alturaY * 2;
        }

        public override int Area()
        {
            return baseX * alturaY;
        }
    }
}
