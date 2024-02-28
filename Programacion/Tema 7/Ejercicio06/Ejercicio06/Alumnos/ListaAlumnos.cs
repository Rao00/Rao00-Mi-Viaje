using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Ejercicio06.Alumnos
{
    public class ListaAlumnos
    {

        List<Alumno> listaAlumnos;

        public ListaAlumnos()
        {
            listaAlumnos = new List<Alumno>();
        }

        public int New(string dni, string nombre, string apellidos, string telefono)
        {
            Alumno alumno = new Alumno();
            alumno.DNI = dni;
            alumno.Nombre = nombre;
            var apellidosSplit = apellidos.Split(' ');
            if(apellidosSplit.Length == 1)
            {
                alumno.Apellido1 = apellidosSplit[0];
            }
            else if(apellidosSplit.Length == 2)
            {
                alumno.Apellido1 = apellidosSplit[0];
                alumno.Apellido2 = apellidosSplit[1];
            }
            else { throw new ArgumentException("Minimo un apellido, maximo dos"); }
            alumno.telefono = telefono;
            listaAlumnos.Add(alumno);
            return 1;
        }

        public int Count()
        {
            return listaAlumnos.Count;
        }

        public List<Alumno> List()
        {
            return listaAlumnos;
        }
    }
}
