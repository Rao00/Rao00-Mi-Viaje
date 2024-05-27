using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }

        private void Run()
        {
            Load();
            MostrarPantalla();
        }


        Tuple<int[], int[], int[]> torres;
        List<int> ListaInicio = new List<int>() { 5, 4, 3, 2, 1 };
        const string alturaVacia = "|";
        const int alturas = 5;
        private void Load()
        {
            int[] torre1 = new int[alturas];
            Add(torre1, ListaInicio);
            int[] torre2 = new int[alturas];
            int[] torre3 = new int[alturas];
            torres = new Tuple<int[], int[], int[]>(torre1, torre2, torre3);
        }

        private void Add(int[] array, List<int> list)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list[i];
            }
        }

        private void MostrarPantalla()
        {
            string fotograma = "";
            for (int i = alturas - 1; i >= 0; i--)
            {
                if (torres.Item1[i] > 0)
                    fotograma += $"  {torres.Item1[i]}";
                else
                    fotograma += $"  {alturaVacia}";
                if (torres.Item2[i] > 0)
                    fotograma += $"  {torres.Item2[i]}";
                else
                    fotograma += $"  {alturaVacia}";
                if (torres.Item3[i] > 0)
                    fotograma += $"  {torres.Item3[i]}\n";
                else
                    fotograma += $"  {alturaVacia}\n";
            }
            Console.WriteLine(fotograma);
        }

        private void Move()
        {

        }
    }
}
