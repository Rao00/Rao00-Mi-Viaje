using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejercicio1
{
    public class Profesor : Persona
    {
        private int _codCursoTutor;
        private string _asignatura1;
        private string _asignatura2;
        private string _asignatura3;

        public int CodCursoTutor
        {
            get { return _codCursoTutor; }
            set { _codCursoTutor = value; }
        }

        public string Asignatura1
        {
            get { return _asignatura1; }
            set { _asignatura1 = value;}
        }

        public string Asignatura2
        {
            get { return _asignatura2; }
            set { _asignatura2 = value;}
        }

        public string Asignatura3
        {
            get { return _asignatura3; }
            set { _asignatura3 = value;}
        }

        public Profesor(string DNI, string Nombre, string Apellido, string Telefono, string Email, Image fotoPerfil = null, int codTutorCurso = 0, string asginatura1 = null, string asignatura2 = null, string asignatura3 = null) : base(DNI, Nombre, Apellido, Telefono, Email, fotoPerfil)
        {
            _codCursoTutor = codTutorCurso;
            _asignatura1 = asginatura1;
            _asignatura2 = asignatura2;
            _asignatura3 = asignatura3;
        }

        new public string GetType()
        {
            return "Profesor";
        }
    }
}
