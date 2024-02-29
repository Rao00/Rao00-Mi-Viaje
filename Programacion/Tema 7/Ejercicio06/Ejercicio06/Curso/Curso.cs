using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio06.Alumnos;

namespace Ejercicio06.Cursos
{
    public class Curso
    {
        public string nombre;
        public string codigo;

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
        
        public string Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Curso() 
        { 
            codigo = string.Empty;
        }
    }
}
