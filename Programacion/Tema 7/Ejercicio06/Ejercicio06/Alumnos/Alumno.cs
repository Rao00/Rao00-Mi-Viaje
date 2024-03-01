using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio06.Cursos;

namespace Ejercicio06.Alumnos
{
    public class Alumno : IPersona
    {
        private string dni;
        private string nombre;
        private string telefono;
        private List<double> notas;
        private string codigoCurso;

        public Alumno()
        {
            notas = new List<double>();
            codigoCurso = string.Empty;
        }

        public string DNI
        {
            get { return dni; }
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]{8}[a-zA-Z]{1}"))
                {
                    dni = value;
                }
                else { throw new ArgumentException("El DNI no es valido"); }
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

        public List<double> Notas
        {
            get { return notas; }
            set { notas = value; }
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

        override
        public string ToString()
        {
            string salida = string.Empty;
            salida += "DNI: " + dni + "\n";
            salida += "Nombre: " + nombre + "\n";
            salida += "Telefono: " + telefono + "\n";
            salida += "Codigo curso: " + codigoCurso;
            return salida;
        }

        public bool SetDNI(string dni) { DNI = this.dni; return true; }
        public bool SetNombre(string nombre) { Nombre = this.nombre; return true; }
        public bool SetTelefono(string telefono) { Telefono = this.telefono; return true; }
    }
}