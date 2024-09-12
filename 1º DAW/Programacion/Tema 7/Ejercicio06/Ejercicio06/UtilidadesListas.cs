using Ejercicio06.Alumnos;
using Ejercicio06.Cursos;
using Ejercicio06.Profesores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public static class UtilidadesListas
    {
        public static List<T> Sort<T>(List<T> ListaPrincipal) where T : IPersona
        {
            bool cont = true;
            for (int i = 0; i < ListaPrincipal.Count() - 1; i++)
            {
                for (int j = i + 1; j < ListaPrincipal.Count() && cont; j++)
                {
                    if (String.Compare(ListaPrincipal[j].Nombre, ListaPrincipal[i].Nombre) < 0)
                    {
                        ListaPrincipal = Move(ListaPrincipal, i, j);
                        cont = false;
                    }
                }
                cont = true;
            }
            return ListaPrincipal;
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

        private static List<T> Move<T>(List<T> lista, int i, int j) where T : IPersona
        {
            var empleadoTemp = lista[j];
            lista[j] = lista[i];
            lista[i] = empleadoTemp;
            return lista;
        }
    }
}
