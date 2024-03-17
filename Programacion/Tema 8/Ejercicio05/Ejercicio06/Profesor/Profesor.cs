using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio06.Cursos;

namespace Ejercicio06.Profesores
{
    public class Profesor : Persona
    {
        public Profesor(string dni, string nombre, string telefono, string codigoCurso, List<string> notas) : base(dni, nombre, telefono, codigoCurso, notas) { }


        public override string ToString()
        {
            string salida = string.Empty;
            salida += "DNI: " + DNI + "\n";
            salida += "Nombre: " + Nombre + "\n";
            salida += "Telefono: " + Telefono + "\n";
            salida += "Codigo curso: " + CodigoCurso;
            return salida;
        }

        public override string GetType()
        {
            return "Profesor";
        }
    }
}
