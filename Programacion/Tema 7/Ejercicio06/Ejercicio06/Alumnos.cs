using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Text.RegularExpressions;

namespace Ejercicio06
{
    internal class Alumnos
    {
        public string dni;
        public string nombre;
        public string apellido1;
        public string apellido2;
        public string telefono;
        public List<double> notas;

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
                if (Regex.IsMatch(value, @"^[0-9]{}"))
                {
                    nombre = value;
                }
            }
        }

        public Alumnos()
        {
            DNI = string.Empty;
            nombre = string.Empty;
            apellido1 = string.Empty;
            apellido2 = string.Empty;
            telefono = string.Empty;
            notas = new List<double>();
        }
    }
}


pito