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

        public Eje06()
        {
            InitializeComponent();
            this.listaAlumnos = new ListaAlumnos();
            this.listaCursos = new ListaCursos(listaAlumnos);
            this.listaProfesores = new ListaProfesores();
        }

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            fCursos formCursos = new fCursos(listaCursos, listaAlumnos);
            formCursos.ShowDialog();
        }

        private void btnGestionarAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos formAlumnos = new fAlumnos(listaAlumnos, listaCursos);
            formAlumnos.ShowDialog();
        }
    }
}
