using Ejercicio06.Cursos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06.Profesores
{
    internal class ListaProfesores
    {
        List<Profesores> listaProfesores;
        ListaCursos listaCursos;

        public ListaProfesores()
        {
            listaProfesores = new List<Profesores>();
            
        }

        public void New()
        {
            Profesores profesor = new Profesores();
            profesor.DNI = Interaction.InputBox("Documento nacional de identidad del alumno");
            profesor.Nombre = Interaction.InputBox("Nombre del alumno");
            profesor.telefono = Interaction.InputBox("Numero de contacto del alumno");
            var asignaturas = Interaction.InputBox("Asiganturas del profesor, separalas con ';'").Split(';');
            profesor.asignaturas = asignaturas.ToList<string>();
            string curso = Interaction.InputBox("Numero de contacto del alumno");
            for(int i = 0; i < listaCursos.List.Count(); i++)
            {
                if (curso == listaCursos[i].Nombre)
            }
            listaProfesores.Add(profesor);
        }
    }
}
