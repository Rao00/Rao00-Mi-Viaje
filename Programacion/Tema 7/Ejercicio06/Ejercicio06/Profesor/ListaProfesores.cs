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
        List<Profesor> listaProfesores;

        public ListaProfesores()
        {
            listaProfesores = new List<Profesor>();
        }

        public void New()
        {
            Profesor profesor = new Profesor();
            profesor.DNI = Interaction.InputBox("Documento nacional de identidad del profesor");
            profesor.Nombre = Interaction.InputBox("Nombre del profesor");
            profesor.telefono = Interaction.InputBox("Numero de contacto del profesor");
            var asignaturas = Interaction.InputBox("Asiganturas del profesor, separalas con ';'").Split(';');
            profesor.asignaturas = asignaturas.ToList<string>();
            string tutor = Interaction.InputBox("Curso del que el profesor es tutor");
            /*if (tutor != null && listaCursos.Contains(tutor))
            {
                profesor.tutorCurso = tutor;
            }
            listaProfesores.Add(profesor);*/
        }
    }
}
