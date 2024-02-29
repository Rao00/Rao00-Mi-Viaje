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
        private string dni;
        private string nombre;
        private string telefono;
        private double? media;
        private List<double> notas;
        private string codigoCurso;

        public string DNI
        {
            get { return dni; }
            set 
            {
                if (Regex.IsMatch(value, @"^[0-9]{8}[a-zA-Z]$"))
                {
                    dni = value;
                }
                else { throw new ArgumentException("No es un DNI valido"); }
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
                else { throw new ArgumentException("No es un nombre valido"); }
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
                else { throw new ArgumentException("No es un telefono valido"); }
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
            salida += "Telefono: " + telefono + "\n";
            return salida;
        }
    }
}