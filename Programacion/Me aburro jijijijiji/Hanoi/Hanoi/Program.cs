using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace Hanoi
{
    class Program
    {
        const int tamTorres = 5;
        const int cantidadTorres = 3;
        //int indiceDisco = numDisco + (cantidadTorres * tamTorres);
        Disco[] torres = new Disco[tamTorres * cantidadTorres];
        static void Main(string[] args)
        {
            int torreOrigen = 0;
            int torreDestino = 0;
            Program programa = new Program();
            while(true)
            {
                programa.Draw();
                programa.Mover(torreOrigen, torreDestino);
                programa.Dibujar();
                Console.WriteLine("Selecciona torre origen");
                torreOrigen = int.TryParse(Console.ReadLine(), out int origen) ? origen-1 : -1;
                if(torreOrigen < 0 || torreOrigen > cantidadTorres) { Console.WriteLine("Introduce una torre valida"); continue;}
                Console.WriteLine("Selecciona torre destino");
                torreDestino = int.TryParse(Console.ReadLine(), out int destino) ? destino-1: -1;
                if (torreDestino < 0 || torreDestino > cantidadTorres) { Console.WriteLine("Introduce una torre valida"); continue; }
                if (programa.ComprobarVictoria()) { Console.WriteLine("Has ganado"); Console.ReadLine(); break; }
            }
        }

        public Program()
        {
            for (int i = 0; i < tamTorres; i++) 
            {
                Disco disco = new Disco(i + 1);
                torres[i] = disco;
            }
            for( int i = 0 + (tamTorres); i < tamTorres * cantidadTorres; i++)
            {
                Disco disco = new Disco();
                torres[i] = disco;
            }
        }

        private void Dibujar()
        {
            for (int i = 0; i < tamTorres; i++)
            {
                string salida = string.Empty;
                for (int j = 0; j < cantidadTorres; j++)
                {
                    int indiceDisco = i + (j * tamTorres);
                    switch (torres[indiceDisco].Tamaño > 0)
                    {
                        case true:
                            salida += $"{torres[indiceDisco].Tamaño} ";
                            break;
                        default:
                            salida += "| ";
                            break;
                    }
                }
                Console.WriteLine(salida);
            }
        }

        private int Mover(int indiceTorreOrigen, int indiceTorreDestino)
        {
            try
            {
                int indiceDisco;
                for (int i = 0; i < tamTorres; i++)
                {
                    indiceDisco = i + (indiceTorreOrigen * 5);
                    if (torres[indiceDisco].Tamaño > 0)
                    {
                        for (int j = 1; j < tamTorres + 1; j++)
                        {
                            int discoMasAlto = (j - 1) + (indiceTorreDestino * tamTorres);
                            if (torres[discoMasAlto].Tamaño <= torres[indiceDisco].Tamaño && torres[discoMasAlto].Tamaño != 0)
                            {
                                return -1;
                            }
                            else if (torres[discoMasAlto].Tamaño > torres[indiceDisco].Tamaño)
                            {
                                torres[(discoMasAlto - 1)].Tamaño = torres[indiceDisco].Tamaño;
                                torres[indiceDisco].Tamaño = 0;
                                return 1;
                            }
                            else if (j == tamTorres)
                            {
                                torres[(discoMasAlto)].Tamaño = torres[indiceDisco].Tamaño;
                                torres[indiceDisco].Tamaño = 0;
                                return 1;
                            }
                        }
                        break;
                    }
                }
                return 0;
            }
            catch { return -1; }
        }
        
        private bool ComprobarVictoria()
        {
            if (torres[(tamTorres * (cantidadTorres-1)) + 1].Tamaño > 0)
            {
                return true;
            }
            return false;
        }
    }
}