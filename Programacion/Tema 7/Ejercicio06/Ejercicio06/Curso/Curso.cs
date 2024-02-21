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
        public int codigo;
        public Alumno alumno;

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
        
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Curso() 
        { 
            nombre = string.Empty;
            codigo = 0;
        }
    }
}
