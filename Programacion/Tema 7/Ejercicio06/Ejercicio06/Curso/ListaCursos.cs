using Ejercicio06.Alumnos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06.Cursos
{
    public class ListaCursos
    {
        List<Curso> listaCursos;
        ListaAlumnos listaAlumnos;

        public ListaCursos(ListaAlumnos listaAlumnos)
        {
            listaCursos = new List<Curso>();
            listaAlumnos = this.listaAlumnos;
        }

        public List<Curso> List
        {
            get { return listaCursos; }
        }

        public void Add(string nombre, string codigo)
        {
            Curso curso = new Curso();
            curso.nombre = nombre;
            curso.codigo = codigo;
            listaCursos.Add(curso);
        }

        public bool Remove(string codigo) 
        {
            for(int i = 0; i < listaCursos.Count(); i++)
            {
                if(listaCursos[i].codigo == codigo)
                {
                    listaCursos.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        override
        public string ToString()
        {
            string salida = string.Empty;
            foreach(Curso curso in listaCursos)
            {
                salida += "Codigo del curso:" + curso.Codigo + "\n";
                salida += "Nombre del curso:" + curso.Nombre + "\n\n";
            }
            return salida;
        }

        public string ToString(string codigo)
        {
            string salida = string.Empty;
            List<Alumno> lista = listaAlumnos.List();
            for(int i = 0; i < listaAlumnos.Count(); i++)
            {
                if (lista[i].CodigoCurso == codigo)
                {
                    salida += lista[i].ToString() + "\n";
                }
            }
            return salida;
        }

        public bool Contains(string nombreCurso)
        {
            for (int i = 0; i < listaCursos.Count(); i++)
            {
                if (nombreCurso == listaCursos[i].Nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

