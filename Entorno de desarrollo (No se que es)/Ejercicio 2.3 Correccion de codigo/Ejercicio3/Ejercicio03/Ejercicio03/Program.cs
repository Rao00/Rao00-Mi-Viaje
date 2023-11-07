using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char minLetra = 'A';
            char maxLetra = 'z';
            int numMayusculas = 0;
            bool salir = false;
            while (!salir) {
                //Leo una letra
                Console.WriteLine("Introduce una letra. Pulsa 0 si quieres salir: ");
    
                char letraAux = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                Console.WriteLine("-------");
                if (letraAux == '0')
                {
                    salir = true;
                }
                else
                {
                    if (letraAux>minLetra)
                    {
                        minLetra = letraAux;
                    }
                    if (letraAux<maxLetra)
                    {
                        maxLetra = letraAux;
                    }
                    if ((letraAux >= 'A') && (letraAux <= 'Z'))
                    {
                        numMayusculas++;
                    }
                }
            }
            //Escribe el resultado
            Console.WriteLine("el Char menor es : " + maxLetra);
            Console.WriteLine("el Char mayor es : " + minLetra);
            Console.WriteLine("Hay " + numMayusculas + " letras mayusculas ");
            Console.ReadKey();
        }
    }
}