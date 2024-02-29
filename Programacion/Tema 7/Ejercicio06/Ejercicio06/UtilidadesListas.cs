using Ejercicio06.Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    static class UtilidadesListas
    {
        public static List<IFormatProvider> Sort(List<IFormatProvider> Lista)
        {
            bool cont = true;
            List<IFormatProvider> ListaPrincipal = Lista.List();
            for (int i = 0; i < ListaPrincipal.Count() - 1; i++)
            {
                for (int j = i + 1; j < ListaPrincipal.Count() && cont; j++)
                {
                    if (String.Compare(ListaPrincipal[j].Nombre, ListaPrincipal[i].Nombre) < 0)
                    {
                        ListaPrincipal = MoveEmpleado(ListaPrincipal, i, j);
                        cont = false;
                    }
                }
                cont = true;
            }
            return ListaPrincipal;
        }

        private List<IFormatProvider> MoveEmpleado(List<IFormatProvider> lista, int i, int j)
        {
            IFormatProvider empleadoTemp = new IFormatProvider();
            empleadoTemp = lista[j];
            lista[j] = lista[i];
            lista[i] = empleadoTemp;
            return lista;
        }
    }
}
