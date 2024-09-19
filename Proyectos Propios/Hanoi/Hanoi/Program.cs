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
        bool victoria = false;
        const int tamTorres = 10;
        List<Disco[]> torres = new List<Disco[]>();

        public static void Main(string[] args)
        {
            Program programa = new Program();

            int i = 1;

            while (!programa.victoria)
            {
                i = i > tamTorres ? 1 : i;

                programa.Resolver(i);

                if (i == tamTorres)
                { 
                    Console.Clear();
                    programa.Render();
                    programa.victoria = programa.ComprobarVictoria();
                }

                Thread.Sleep(100);
                
                i++;
            }

            Console.ReadLine();
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
            int indexOrigen = FindTallestDiscIndex(torreOrigen, out Disco discoOrigen);
            if (discoOrigen.Tamaño == 0)
                return;

            int indexDestino = FindTallestEmptyIndex(torreDestino);
            if (indexDestino > 0)
                if (torres[torreDestino][indexDestino - 1].Tamaño < discoOrigen.Tamaño)
                    return;

            discoOrigen.Altura = indexDestino;
            torres[torreDestino][indexDestino] = discoOrigen;
            torres[torreOrigen][indexOrigen] = new Disco(0, indexOrigen);
        }

        public int FindTallestEmptyIndex(int torre)
        {
            for (int i = 0; i < tamTorres; i++)
            {
                if (torres[torre][i].Tamaño == 0)
                    return i;
            }
            return 0;
        }

        public int FindTallestDiscIndex(int torre, out Disco _)
        {
            for (int i = tamTorres - 1; i >= 0; i--)
            { 
                if (torres[torre][i].Tamaño != 0)
                {
                    _ = torres[torre][i];
                    return i;
                }
            }
            _ = new Disco();
            return 0;
        }

        public void Resolver(int tamDisco)
        {
            int destinoIndex;
            int torreDestino;
            int torreOrigen = TorreWhereDisco(tamDisco).torre;
            Disco disco = TorreWhereDisco(tamDisco).disco;

            //comprobar si el disco se puede mover
            destinoIndex = FindTallestDiscIndex(torreOrigen, out Disco tmpDisco);

            if (tmpDisco.Tamaño != tamDisco)
                return;

            // mover disco a torre donde este tamDisco + 1
            if (tamDisco > tamTorres - 1)
                goto regla2;

            torreDestino = TorreWhereDisco(tamDisco + 1).torre;

            if (torreDestino == torreOrigen)
                goto regla2;

            FindTallestDiscIndex(torreDestino, out tmpDisco);

            if (tmpDisco.Tamaño > disco.Tamaño)
            {
                Mover(torreOrigen, torreDestino);
                return;
            }

            // mover disco a torre + 1

            regla2:

            for (int i = 1; i <= 2; i++)
            {
                torreDestino = torreOrigen + i > 2 ? (torreOrigen + i) - 3 : torreOrigen + i;

                int tmp = FindTallestDiscIndex(torreDestino, out Disco discoTmp);

                if (discoTmp.Tamaño > disco.Tamaño || discoTmp.Tamaño == 0)
                {
                    Mover(torreOrigen, torreDestino);
                    return;
                }
            }
        }

        public bool ComprobarVictoria()
        {
            bool victoria = true;

            Disco[] listaVictoria = new Disco[tamTorres];

            for (int i = 0; i < tamTorres; i++)
            {
                if (torres[2][i].Tamaño == 0)
                {
                    victoria = false;
                    break;
                }
            }

            return victoria;
        }
    }
}