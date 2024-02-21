using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio06.Alumnos;
using Ejercicio06.Profesores;
using Ejercicio06.Cursos;

namespace Ejercicio06
{
    public partial class Eje06 : Form
    {
        ListaCursos listaCursos;
        ListaAlumnos listaAlumnos;
        ListaProfesores listaProfesores;

        public Eje06(Alumno alumnos, Profesor profesores)
        {
            InitializeComponent();
            this.listaAlumnos = new ListaAlumnos();
            this.listaProfesores = new ListaProfesores();
            this.listaCursos = new ListaCursos();
        }

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            fCursos FormCursos = new fCursos();
        }
    }
}
