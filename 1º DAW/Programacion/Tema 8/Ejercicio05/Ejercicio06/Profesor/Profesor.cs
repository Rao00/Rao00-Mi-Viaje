using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio06.Cursos;

namespace Ejercicio06
{
    public class Profesor : Persona
    {
        private List<string> asignaturas;
        private string tutorCurso;

        public string TutorCurso
        {
            get { return tutorCurso; }
            set { tutorCurso = value; }
        }

        public List<string> Asignaturas
        {
            get { return asignaturas; }
            set { asignaturas = value; }
        }

        public Profesor()
        {
            asignaturas = new List<string>();
            tutorCurso = string.Empty;
        }

        public override string ToString()
        {
            string salida = string.Empty;
            salida += "DNI: " + DNI + "\n";
            salida += "Nombre: " + Nombre + "\n";
            salida += "Telefono: " + Telefono + "\n";
            salida += "Codigo curso: " + TutorCurso;
            return salida;
        }

        public override string GetType()
        {
            return "Profesor";
        }
    }
}
