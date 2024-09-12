using Ejercicio06.Alumnos;
using Ejercicio06.Cursos;
using Ejercicio06.Profesores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public static class UtilidadesListas
    {
        public static List<Persona> Sort(List<Persona> listaPrincipal,int Miguelito = 10)
        {
            int i = 0;
            int pivot;
            if (Miguelito <= 0)
            {
                return listaPrincipal;
            }
            while (i < listaPrincipal.Count())
            {
                pivot = i;
                int rightIndex;
                int k = 0;
                for (int j = 0; j < pivot; j++)
                {
                    rightIndex = pivot * 2 > listaPrincipal.Count() - 1 ? listaPrincipal.Count() - 1 : pivot * 2 - k;
                    if (String.Compare(listaPrincipal[j].Nombre, listaPrincipal[rightIndex].Nombre) == 1)
                    {
                        if (i >= 0 && i < listaPrincipal.Count() && j >= 0 && j < listaPrincipal.Count())
                        {
                            Persona temp = listaPrincipal[i];
                            listaPrincipal[i] = listaPrincipal[j];
                            listaPrincipal[j] = temp;
                        }
                        k++;
                        continue;
                    }
                    if (String.Compare(listaPrincipal[j].Nombre, listaPrincipal[pivot].Nombre) == 1)
                    {
                        Persona temp = listaPrincipal[j];
                        listaPrincipal.RemoveAt(j);
                        listaPrincipal.Insert(pivot, temp);
                        continue;
                    }
                    if (String.Compare(listaPrincipal[rightIndex].Nombre, listaPrincipal[pivot].Nombre) == -1)
                    {
                        Persona temp = listaPrincipal[rightIndex];
                        listaPrincipal.RemoveAt(rightIndex);
                        listaPrincipal.Insert(pivot - 1, temp);
                        k++;
                        continue;
                    }
                }
                i++;
            }
            return Sort(listaPrincipal, Miguelito - 1);
        }

        public static List<double> StringToDouble(List<string> list)
        {
            List<double> listDouble = new List<double>();
            for (int i = 0; i < list.Count(); i++)
            {
                listDouble.Add(double.Parse(list[i]));
            }
            return listDouble;
        }

        private static List<Persona> Move(List<Persona> lista, int i, int j)
        {
            var empleadoTemp = lista[j];
            lista[j] = lista[i];
            lista[i] = empleadoTemp;
            return lista;
        }
    }
}
