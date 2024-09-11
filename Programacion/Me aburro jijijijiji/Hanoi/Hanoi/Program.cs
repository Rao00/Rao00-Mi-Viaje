using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using OpenTK.Graphics.OpenGL;

namespace Hanoi
{
    class Program
    {
        const int tamTorres = 5;
        List<Disco[]> torres = new List<Disco[]>();

        public static void Main(string[] args)
        {
            Program programa = new Program();

            int i = 0;

            while (true)
            {
                programa.Render();
                
                programa.TorreWhereDisco()

                programa.Resolver(º);

                i++;

                Thread.Sleep(500);
            }
        }

        public Program()
        {
            for (int i = 0; i < 3; i++)
            {
                Disco[] torre = new Disco[tamTorres];
                torres.Add(torre);
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < tamTorres; i++)
                {
                    int valorTorre = j != 0 ? 0 : (tamTorres - i);

                    torres[j][i] = new Disco(valorTorre, i);
                }
            }
        }

        public void Render()
        {
            StringBuilder salida = new StringBuilder();

            string prueba = string.Empty;

            for (int i = tamTorres - 1; i >= 0; i--)
            {
                foreach (Disco[] torre in torres)
                {
                    salida.Append(torre[i].Tamaño + " ");
                }

                salida.Append("\n");
            }

            Console.WriteLine(salida);
        }

        public void Resolver(Disco disco, bool cont = true)
        {
            // torre pasa disco a torre con tamDisco + 1
            // torre pasa disco a torre + 1
            // torre pasa disco a donde sea

            if (!cont)
                return;

            int indexTorre = TorreWhereDisco(disco);

            for (int i = 0; i < torres[indexTorre].Length; i++)
            {
                if (torres[indexTorre][i].Tamaño != torres[indexTorre][disco.Altura].Tamaño)
                {
                    return;
                }
            }

            for (int i = 2; i > 0; i--)
            {
                int torreAComprobar = indexTorre + 1 < torres.Count ? indexTorre + 1 : 0;

                torres[torreAComprobar].Last();
            }
        }

        public int TorreWhereDisco(Disco disco)
        {
            for (int i = 0; i < torres.Count; i++)
            {
                if (torres[i].Contains(disco))
                    return i;
            }

            return -1;
        }
    }
}