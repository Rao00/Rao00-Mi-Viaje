using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio06.Cursos;

namespace Ejercicio06.Profesores
{
    public class Profesores
    {
        public string dni;
        public string nombre;
        public string telefono;
        public List<string> asignaturas;
        public Cursos.Cursos tutorCurso;

        public string DNI
        {
            get { return dni; }
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]{8}[a-zA-Z]{1}"))
                {
                    dni = value;
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-ZñÑ]+"))
                {
                    nombre = value;
                }
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]{9}"))
                {
                    telefono = value;
                }
            }
        }

        public Cursos.Cursos TutorCurso
        {
            get { return tutorCurso; }
            set { tutorCurso = value; }
        }

        public Profesores()
        {
            dni = string.Empty;
            nombre = string.Empty;
            telefono = string.Empty;
            asignaturas = new List<string>();
            tutorCurso = new Cursos.Cursos();
        }
    }
}
