using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public abstract class Persona
    {

        private string dni;
        private string nombre;
        private string telefono;
        private string codigoCurso;
        private List<string> listaGenerica;

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

        public string CodigoCurso
        {
            get { return codigoCurso; }
            set { codigoCurso = value; }
        }

        public List<string> Lista
        {
            get { return listaGenerica; }
            set { listaGenerica = value; }
        }

        public Persona(string Dni, string Nombre, string Telefono, string CodigoCurso, List<string> Lista)
        {
            dni = Dni;
            nombre = Nombre;
            telefono = Telefono;
            codigoCurso = CodigoCurso;
            listaGenerica = Lista;
        }

        public abstract override string ToString();
        
        new public abstract string GetType();
    }
}

