using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jirafa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] blanco = { 255, 255, 255 };
            int[,,] PantallaPrincipal = new int[64, 64, 64];
            foreach (int pixel in PantallaPrincipal)
            {
                pixel = blanco;
            }
        }
    }
}
