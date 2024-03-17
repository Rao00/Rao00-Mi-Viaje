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

        List<ListaCursos> listaCursos;
        List<ListaPersonas> listaGlobal;

        public Eje06()
        {
            InitializeComponent();
            this.listaCursos = new List<ListaCursos>();
            this.listaGlobal = new List<ListaPersonas>();
        }

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            fCursos formCursos = new fCursos(listaCursos, listaGlobal);
            formCursos.ShowDialog();
        }

        private void btnGestionarAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos formAlumnos = new fAlumnos();
            formAlumnos.ShowDialog();
        }

        private void btnGestionarProfesores_Click(object sender, EventArgs e)
        {
            fProfesores formProfesores = new fProfesores();
            formProfesores.ShowDialog();
        }
    }
}
