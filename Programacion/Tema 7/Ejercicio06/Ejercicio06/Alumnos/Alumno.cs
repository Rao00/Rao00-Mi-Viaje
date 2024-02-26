using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio06.Cursos;

namespace Ejercicio06.Alumnos
{
    public class Alumno
    {
        public string dni;
        public string nombre;
        public string apellido1;
        public string apellido2;
        public string telefono;
        public double? media;
        public List<double> notas;
        public string codigoCurso;

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
        public string Apellido1
        {
            get { return apellido1; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-ZñÑ]+"))
                {
                    apellido1 = value;
                }
            }
        }
        public string Apellido2
        {
            get { return apellido2; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-ZñÑ]+"))
                {
                    apellido2 = value;
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

        public double Media
        {
            get { return notas.Average(); }
        }

        public string CodigoCurso
        {
            get { return codigoCurso; }
            set { codigoCurso = value; }
        }

        public Alumno()
        {
            DNI = string.Empty;
            nombre = string.Empty;
            apellido1 = string.Empty;
            apellido2 = string.Empty;
            telefono = string.Empty;
            media = null;
            notas = new List<double>();
            codigoCurso = string.Empty;
        }

        override
        public string ToString()
        {
            string salida = string.Empty;
            salida += "DNI: " + dni + "\n";
            salida += "Nombre: " + nombre + "\n";
            salida += "Apellidos: " + apellido1 + " " + apellido2 + "\n";
            salida += "Telefono: " + telefono + "\n";
            return salida;
        }
    }
}