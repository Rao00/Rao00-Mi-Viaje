using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class Disco
    {
        int tamaño;

        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public Disco(int _tamaño = 0)
        {
            Tamaño = _tamaño;
        }
    }
}
