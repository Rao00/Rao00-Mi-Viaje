using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio06.Cursos;

namespace Ejercicio06
{
    public class Alumno : Persona
    {
        string codigoCurso;
        List<double> listaNotas;

        public Alumno()
        {
            
        }

        public string CodigoCurso
        {
            get { return codigoCurso; }
            set { codigoCurso = value; }
        }

        public List<double> ListaNotas
        {
            get { return listaNotas; }
            set { listaNotas = value; }
        }

        public double Media
        {
            get { return listaNotas.Average(); }
        }

        
        public override string ToString()
        {
            string salida = string.Empty;
            salida += "DNI: " + DNI + "\n";
            salida += "Nombre: " + Nombre + "\n";
            salida += "Telefono: " + Telefono + "\n";
            salida += "Codigo curso: " + CodigoCurso;
            return salida;
        }

        public override string GetType()
        {
            return "Alumno";
        }
    }
}