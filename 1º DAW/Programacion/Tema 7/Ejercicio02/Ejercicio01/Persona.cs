using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Persona
    {
        private string name;
        private int edad;
        private string telefono = " ";
        private char sexo;
        private bool casado;

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        public int Edad
        {
            get { return edad; }
            set 
            { 
                if (edad < 120)
                    edad = value; 
            }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public bool Casado
        {
            get { return casado; }
            set { casado = value; }
        }
    }
}
