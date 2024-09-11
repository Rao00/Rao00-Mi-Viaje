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
        int altura;

        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Disco(int _tamaño = 0, int _altura = 0)
        {
            tamaño = _tamaño;
            altura = _altura;
        }
    }
}
