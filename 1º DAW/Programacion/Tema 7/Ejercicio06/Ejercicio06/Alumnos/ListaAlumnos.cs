using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio06.Cursos;
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

        public int New(string dni)
        {
            Alumno alumno = new Alumno();
            alumno.DNI = dni;
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

        public string LookFor(string dni)
        {
            foreach(Alumno alumno in listaAlumnos)
            {
                if (alumno.DNI == dni)
                {
                    return alumno.ToString();
                }
            }
            return string.Empty;
        }

        public void Sort()
        {
            listaAlumnos = UtilidadesListas.Sort(listaAlumnos);
        }

        public int Count()
        {
            return listaAlumnos.Count;
        }

        public List<Alumno> List()
        {
            return listaAlumnos;
        }

        public bool Contains(string dni)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.DNI == dni)
                {
                    return true;
                }
            }
            return false;
        }

        public int FindIndex(string dni)
        {
            for (int i = 0; i < listaAlumnos.Count(); i++)
            {
                if (listaAlumnos[i].DNI == dni)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
