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

            int i = 1;

            while (true)
            {
                i = i > 5 ? 1 : i;

                programa.Render();

                var discoActual = programa.TorreWhereDisco(i);

                programa.Resolver(i);

                Console.WriteLine("Disco = " + i + " Torre = " + discoActual.torre + " Altura = " + discoActual.disco.Altura);

                Thread.Sleep(500);
                Console.Clear();

                i++;
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
                    int valorDisco = j != 0 ? 0 : (tamTorres - i);

                    torres[j][i] = new Disco(valorDisco, i);
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

        public (int torre, Disco disco) TorreWhereDisco(int tamDisco)
        {
            for (int i = 0; i < torres.Count; i++)
            {
                for (int j = 0; j < tamTorres; j++)
                {
                    if (torres[i][j].Tamaño == tamDisco)
                    {
                        return (i, torres[i][j]);
                    }
                }
            }
            return (-1, new Disco(-1,-1));
        }

        public void Mover(int torreOrigen, int torreDestino)
        {
            int indexOrigen = FindTallestEmptyIndex(torreOrigen);
            int indexDestino = FindTallestEmptyIndex(torreDestino);

            if (indexOrigen == -1 || indexDestino == -1)
                return;

            if (indexDestino > 0)
                if (torres[torreDestino][indexDestino - 1].Tamaño < torres[torreOrigen][indexOrigen].Tamaño)
                    return;

            Disco tmp = torres[torreOrigen][indexOrigen];
            tmp.Altura = indexDestino;
            torres[torreDestino][indexDestino] = tmp;
            torres[torreOrigen][indexOrigen] = new Disco(0, indexOrigen);
        }

        public int FindTallestEmptyIndex(int torre)
        {
            for (int i = 0; i < tamTorres; i++)
            {
                if (torres[torre][i].Tamaño == 0)
                {
                    return i;
                }
            }
            return 0;
        }

        public void Resolver(int tamDisco)
        {
            int destinoIndex;
            int torreDestino;
            int torreOrigen = TorreWhereDisco(tamDisco).torre;
            Disco disco = TorreWhereDisco(tamDisco).disco;

            //comprobar si el disco se puede mover
            destinoIndex = FindTallestEmptyIndex(torreOrigen);

            destinoIndex = destinoIndex - 1 >= 0 ? destinoIndex - 1 : 0;

            // mover disco a torre donde este tamDisco + 1
            if (tamDisco > tamTorres - 1)
                goto regla2;

            torreDestino = TorreWhereDisco(tamDisco + 1).torre;
            destinoIndex = FindTallestEmptyIndex(torreDestino);

            destinoIndex = destinoIndex - 1 >= 0 ? destinoIndex - 1 : 0;

            if (torres[torreDestino][destinoIndex].Tamaño < disco.Tamaño)
            {
                Mover(torreOrigen, torreDestino);
                return;
            }

            goto regla2;

            // mover disco a torre + 1

            regla2:

            torreDestino = torreOrigen + 1 > 2 ? 0 : torreOrigen + 1;
            destinoIndex = FindTallestEmptyIndex(torreDestino);

            destinoIndex = destinoIndex - 1 >= 0 ? destinoIndex - 1 : 0;

            if (torres[torreDestino][destinoIndex].Tamaño > tamDisco || torres[torreDestino][destinoIndex].Tamaño == 0)
            {
                Mover(torreOrigen, torreDestino);
                return;
            }

            // mover disco a donde sea

            for (int i = 0; i < 2; i++)
            {
                torreDestino = torreOrigen + 1 > 2 ? 0 : torreOrigen++;
                destinoIndex = FindTallestEmptyIndex(torreDestino);

                destinoIndex = destinoIndex - 1 >= 0 ? destinoIndex - 1 : 0;

                if (torres[torreDestino][destinoIndex].Tamaño > tamDisco || destinoIndex == 0)
                {
                    Mover(torreOrigen, torreDestino);
                    break;
                }
            }
            
        }
    }
}