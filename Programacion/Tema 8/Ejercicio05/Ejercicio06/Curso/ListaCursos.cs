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
        ListaPersonas listaGlobal;

        public ListaCursos(ListaPersonas listaGlobal)
        {
            listaCursos = new List<Curso>();
            this.listaGlobal = listaGlobal;
        }

        public List<Curso> List()
        {
            return listaCursos;
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

        public override string ToString()
        {
            string salida = string.Empty;
            foreach(Curso curso in listaCursos)
            {
                salida += "Codigo del curso: " + curso.Codigo + "\n";
                salida += "Nombre del curso: " + curso.Nombre + "\n\n";
            }
            return salida;
        }

        public string ToString(string codigo)
        {
            string salida = string.Empty;
            for(int i = 0; i < listaGlobal.Count(); i++)
            {

            }
            return salida;
        }

        public bool Contains(string codigoCurso)
        {
            for (int i = 0; i < listaCursos.Count(); i++)
            {
                if (codigoCurso == listaCursos[i].codigo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

