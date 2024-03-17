using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class ListaPersonas
    {
        List<Persona> listaGlobal;
        public ListaPersonas()
        {
            listaGlobal = new List<Persona>();
        }

        public override string ToString()
        {
            string salida = string.Empty;

            foreach (Persona persona in listaGlobal)
            {
                salida += persona.ToString() + "\n";
            }

            if (salida == string.Empty)
            {
                throw new ArgumentNullException("No hay datos en la lista");
            }
            else
            {
                return salida;
            }
        }
        public string ToString(string TipoDeDato)
        {
            string salida = string.Empty;

            foreach (Persona persona in listaGlobal)
            {
                if (persona.GetType() == TipoDeDato)
                {
                    salida += persona.ToString() + "\n";
                }
            }

            if(salida == string.Empty)
            {
                throw new ArgumentNullException($"No hay datos de {TipoDeDato} en la lista");
            }
            else
            {
                return salida;
            }
        }
        
        public int Count()
        {
            return listaGlobal.Count;
        }

        public List<Alumno>
    }
}
