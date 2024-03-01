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
    public class Profesor : IPersona
    {
        private string dni;
        private string nombre;
        private string telefono;
        private List<string> asignaturas;
        private string tutorCurso;

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
                else { throw new ArgumentException("El nombre no es valido"); }
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
                else { throw new ArgumentException("El telefono no es valido"); }
            }
        }

        public string TutorCurso
        {
            get { return tutorCurso; }
            set { tutorCurso = value; }
        }

        public Profesor()
        {
            asignaturas = new List<string>();
            tutorCurso = string.Empty;
        }

        public bool SetDNI(string dni) { DNI = this.dni; return true; }
        public bool SetNombre(string nombre) { Nombre = this.nombre; return true; }
        public bool SetTelefono(string telefono) { Telefono = this.telefono; return true; }
    }
}
