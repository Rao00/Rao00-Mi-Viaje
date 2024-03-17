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
        private ListaPersonas listaGlobal;

        public fCursos(ListaCursos listaCursos, ListaPersonas listaGlobal)
        {
            InitializeComponent();
            this.listaCursos = listaCursos;
            this.listaGlobal = listaGlobal;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Nombre del curso");
                string codigo = "";
                if (nombre != "") 
                {
                    codigo = Interaction.InputBox("Codigo del curso");
                }
                else { throw new Exception("Inserta un nombre valido"); }
                if (nombre != "" && codigo != "")
                {
                    listaCursos.Add(nombre, codigo);
                }
                else { throw new Exception("Inserta un codigo valido"); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listaCursos.List().Count() > 0)
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
            else
            {
                MessageBox.Show("No hay cursos para eliminar");
            }
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
            if (listaCursos.List().Count() > 1)
            {
                string codigo = Interaction.InputBox("Codigo del curso a mostrar");
                if (listaCursos.Contains(codigo))
                {
                    string salida = listaCursos.ToString(codigo);
                    if (salida == string.Empty)
                    {
                        MessageBox.Show("No hay alumnos en ese curso");
                    }
                    else
                    {
                        MessageBox.Show(salida);
                    }
                }
                else { MessageBox.Show("No existe ese curso"); }
            }
            else
            {
                MessageBox.Show("No hay cursos suficientes para ordenar");
            }   
        }
    }
}
