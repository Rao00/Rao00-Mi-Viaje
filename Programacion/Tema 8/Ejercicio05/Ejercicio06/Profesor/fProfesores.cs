using Ejercicio06.Alumnos;
using Ejercicio06.Cursos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ejercicio06.Profesores
{
    public partial class fProfesores : Form
    {

        List<Persona> listaProfesores;

        public fProfesores(List<Persona> Global, List<ListaCursos> listaCursos)
        {
            InitializeComponent();
            this.listaProfesores = Global.;
            this.listaCursos = listaCursos;
        }

        private void btnNewProfesor_Click(object sender, EventArgs e)
        {
            List<Profesor> tempListaProfesores = listaProfesores.List();
            string dni = Interaction.InputBox("Documento nacional de identidad del profesor");
            try
            {
                if (listaProfesores.New(dni) == 1)
                {
                    int i = listaProfesores.List().Count - 1;
                    string nombre = Interaction.InputBox("Nombre del profesor");
                    tempListaProfesores[i].Nombre = nombre;
                    string telefono = Interaction.InputBox("Telefono del profesor");
                    tempListaProfesores[i].Telefono = telefono;
                    string codigoCurso = Interaction.InputBox("Codigo del curso del que se es tutor");
                    if (listaCursos.Contains(codigoCurso))
                    {
                        if (listaProfesores.CheckTutor(codigoCurso))
                        {
                            tempListaProfesores[i].TutorCurso = codigoCurso;
                        }
                        else { throw new ArgumentException("El curso ya tiene asignado un tutor"); } 
                    }
                    else if (codigoCurso == "")
                    {
                        tempListaProfesores[i].TutorCurso = "No es tutor";
                    }
                    else { throw new ArgumentException("El curso no existe"); }
                    MessageBox.Show("Profesor añadido");
                }
            }
            catch (ArgumentException aex)
            {
                listaProfesores.Delete(dni);
                MessageBox.Show(aex.Message);
            }
        }

        private void btnDeleteProfesor_Click(object sender, EventArgs e)
        {
            if (listaProfesores.Count() > 0)
            {
                string dni = Interaction.InputBox("Documento nacional de identidad del profesor a eliminar");
                if (listaProfesores.Delete(dni) == 1)
                {
                    MessageBox.Show($"Profesor con DNI: {dni}\nHa sido eliminado");
                }
                else { MessageBox.Show($"Profesor con DNI: {dni}\nNo se ha encontrado"); }
            }
            else { MessageBox.Show("No hay profesores para eliminar"); }
        }

        private void btnMostrarListaProfesores_Click(object sender, EventArgs e)
        {
            string salida = listaProfesores.Show();
            if (salida == string.Empty)
            {
                MessageBox.Show("No hay profesores que mostrar");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }

        private void btnSortAlphOrderProfesor_Click(object sender, EventArgs e)
        {
            if (listaProfesores.Count() > 0)
            {
                listaProfesores.Sort();
                MessageBox.Show("Lista ordenada");
            }
            else { MessageBox.Show("No hay profesores para ordenar"); }
        }

        private void btnShowProfesor_Click(object sender, EventArgs e)
        {
            if (listaProfesores.Count() > 0)
            {
                string profesor = listaProfesores.LookFor(Interaction.InputBox("Introduce el DNI del profesor a buscar"));
                if (profesor == string.Empty)
                {
                    MessageBox.Show("El profesor no existe");
                }
                else { MessageBox.Show(profesor); }
            }
            else { MessageBox.Show("No hay profesores"); }
        }

        private void btnAddAsignatura_Click(object sender, EventArgs e)
        {
            if (listaProfesores.Count() > 0)
            {
                string dni = Interaction.InputBox("Introduce el DNI del profesor a añadir la asignatura");
                int indiceProfesor = listaProfesores.FindIndex(dni);
                if (indiceProfesor >= 0)
                {
                    string asignaturas = Interaction.InputBox($"{listaProfesores.ToString(dni)}", "Asignaturas separadas con ';'");
                    List<string> listaAsignaturasTemp = asignaturas.Split(';').ToList();
                    listaProfesores.List()[indiceProfesor] = listaProfesores.AddSubjects(listaProfesores.List()[indiceProfesor], listaAsignaturasTemp);
                    MessageBox.Show("Asignaturas añadidas");
                }
                else { MessageBox.Show("El profesor no existe"); }
            }
            else { MessageBox.Show("No hay profesores"); }
        }

        private void btnDeleteAsignaturas_Click(object sender, EventArgs e)
        {
            if (listaProfesores.Count() > 0)
            {
                string dni = Interaction.InputBox("DNI del profesor");
                if (listaProfesores.Contains(dni))
                {
                    int indice = listaProfesores.FindIndex(dni);
                    string asignaturas = Interaction.InputBox($"{listaProfesores.ToString(dni)}", "Asignaturas a eliminar separadas con ';'");
                    List<string> listaAsignaturas = asignaturas.Split(';').ToList();
                    listaProfesores.List()[indice] = listaProfesores.RemoveSubjects(listaProfesores.List()[indice], listaAsignaturas);
                    MessageBox.Show("Asignaturas eliminadas");
                }
                else { MessageBox.Show("El profesor no existe"); }
            }
            else { MessageBox.Show("No hay profesores"); }
        }

        private void btnShowProfesoresAsinatura_Click(object sender, EventArgs e)
        {
            if (listaProfesores.Count() > 0)
            {
                string salida = string.Empty;
                string asignatura = Interaction.InputBox("Asignatura por la que buscar");
                foreach (Profesor profesor in listaProfesores.List())
                {
                    if (profesor.Asignaturas.Contains(asignatura))
                    {
                        salida += profesor.ToString();
                    }
                }
                if (salida == string.Empty)
                {
                    MessageBox.Show("Ningun profesor imparte esa asignatura");
                }
                else { MessageBox.Show(salida); }
            }
            else { MessageBox.Show("No hay suficientes profesores"); }
        }
    }
}
