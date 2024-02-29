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

        public int New(string dni, string nombre, string telefono)
        {
            Alumno alumno = new Alumno();
            alumno.DNI = dni;
            alumno.Nombre = nombre;
            alumno.Telefono = telefono;
            listaAlumnos.Add(alumno);
            return 1;
        }

        public int Delete(string dni)
        {
            foreach(Alumno alumno in listaAlumnos)
            {
                if (alumno.DNI == dni)
                {
                    listaAlumnos.Remove(alumno);
                    return 1;
                }
            }
            return 0;
        }

        public string Show()
        {
            string salida = string.Empty;
            if (listaAlumnos.Count > 0)
            {
                foreach (Alumno alumno in listaAlumnos)
                {
                    salida += alumno.ToString() + "\n\n";
                }
            }
            return salida;
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
