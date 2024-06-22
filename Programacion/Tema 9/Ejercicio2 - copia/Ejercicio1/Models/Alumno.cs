using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Alumno:Persona
    {
        private int _codCurso;
        private double _notaMedia;

        public int CodCurso
        {
            get { return _codCurso; }
            set { _codCurso = value; }
        }

        public double NotaMedia
        { 
            get { return _notaMedia; }
            set { _notaMedia = value; }
        }

        public Alumno(string dni, string nombre, string apellido, string telefono, string email, Image fotoPerfil, int codCurso = 0, double notaMedia = 0) : base(dni, nombre, apellido, telefono, email, fotoPerfil)
        {
            _codCurso = codCurso;
            _notaMedia = notaMedia;
        }

        new public string GetType()
        {
            return "Alumno";
        }
    }
}
