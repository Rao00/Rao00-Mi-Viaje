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
using Microsoft.VisualBasic;

namespace Ejercicio06.Cursos
{
    public partial class fCursos : Form
    {
        private ListaCursos listaCursos;
        private ListaAlumnos listaAlumnos;

        public fCursos(ListaCursos listaCursos, ListaAlumnos listaAlumnos)
        {
            InitializeComponent();
            this.listaCursos = listaCursos;
            this.listaAlumnos = listaAlumnos;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Nombre del curso");
                string codigo = Interaction.InputBox("Codigo del curso");
                listaCursos.Add(nombre, codigo);
            }
            catch(Exception) { MessageBox.Show("Inserta un parametro correcto"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = Interaction.InputBox("Codigo del curso a eliminar");
                bool removed = listaCursos.Remove(codigo);
                if (removed)
                {
                    MessageBox.Show("Curso eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Curso no encontrado");
                }
            }
            catch { MessageBox.Show("Introduce un codigo valido"); }
        }

        private void btnShowCursos_Click(object sender, EventArgs e)
        {
            string cursosMostrar = listaCursos.ToString();
            if (cursosMostrar == string.Empty)
            {
                MessageBox.Show("No hay cursos que mostrar");
            }
            else { MessageBox.Show(cursosMostrar); }
        }

        private void btnShowCursoContent_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Codigo del curso a mostrar");
            string salida = listaCursos.ToString(codigo);
            if(salida == string.Empty)
            {
                MessageBox.Show("No hay alumnos en ese curso");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }
    }
}
