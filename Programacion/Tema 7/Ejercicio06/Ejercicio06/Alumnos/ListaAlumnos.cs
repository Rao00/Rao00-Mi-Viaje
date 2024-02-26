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

        public void New()
        {
            Alumno alumno = new Alumno();
            alumno.DNI = Interaction.InputBox("Documento nacional de identidad del alumno");
            alumno.Nombre = Interaction.InputBox("Nombre del alumno");
            string apellidos = Interaction.InputBox("Apellidos del alumno");
            var apellidosSplit = apellidos.Split(' ');
            alumno.Apellido1 = apellidosSplit[0];
            alumno.Apellido2 = apellidosSplit[1];
            alumno.telefono = Interaction.InputBox("Numero de contacto del alumno");
            listaAlumnos.Add(alumno);
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
