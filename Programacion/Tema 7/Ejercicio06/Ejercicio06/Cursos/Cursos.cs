using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio06.Cursos
{
    public class Cursos
    {
        public string nombre;
        public int codigo;

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

        public Cursos() 
        { 
            nombre = string.Empty;
            codigo = 0;
        }
    }
}
