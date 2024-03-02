using Ejercicio06.Cursos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio06.Alumnos
{
    public partial class fAlumnos : Form
    {
        ListaAlumnos listaAlumnos;
        ListaCursos listaCursos;

        public fAlumnos(ListaAlumnos listaAlumnos, ListaCursos listaCursos)
        {
            InitializeComponent();
            this.listaAlumnos = listaAlumnos;
            this.listaCursos = listaCursos;
        }

        private void btnNewAlumno_Click(object sender, EventArgs e)
        {
            int i;
            List<Alumno> tempListaAlumnos = listaAlumnos.List();
            string dni = Interaction.InputBox("Documento nacional de identidad del alumno");
            try
            {
                if (listaAlumnos.New(dni) == 1)
                {
                    string nombre = Interaction.InputBox("Nombre del alumno");
                    i = listaAlumnos.List().Count-1;
                    tempListaAlumnos[i].Nombre = nombre;
                    string telefono = Interaction.InputBox("Telefono del alumno");
                    tempListaAlumnos[i].Telefono = telefono;
                    string codigoCurso = Interaction.InputBox("Codigo del curso del alumno");
                    if (listaCursos.Contains(codigoCurso))
                    {
                        tempListaAlumnos[i].CodigoCurso = codigoCurso;
                    }
                    else { throw new ArgumentException("El curso no existe"); }
                    MessageBox.Show("Alumno añadido");
                }
            }
            catch (ArgumentException aex) 
            {
                listaAlumnos.Delete(dni);
                MessageBox.Show(aex.Message); 
            }   
        }

        private void btnDeleteAlumno_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
            {
                string dni = Interaction.InputBox("Documento nacional de identidad del alumno a eliminar");
                if(listaAlumnos.Delete(dni) == 1)
                {
                    MessageBox.Show($"Alumno con DNI: {dni}\nHa sido eliminado");
                }
                else { MessageBox.Show($"Alumno con DNI: {dni}\nNo se ha encontrado"); }
            }
            else { MessageBox.Show("No hay alumnos para eliminar"); }
        }

        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            string salida = listaAlumnos.Show();
            if (salida == string.Empty)
            {
                MessageBox.Show("No hay alumnos que mostrar");
            }
            else
            {
                MessageBox.Show(salida);
            }
        }
        
        private void btnSortAlphOrderAlumnos_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
            {
                listaAlumnos.Sort();
                MessageBox.Show("Lista ordenada");
            }
            else { MessageBox.Show("No hay alumnos para ordenar"); }
        }

        private void btnShowAlumno_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
            {
                string alumno = listaAlumnos.LookFor(Interaction.InputBox("Introduce el DNI del alumno a buscar"));
                if (alumno == string.Empty)
                {
                    MessageBox.Show("El alumno no existe");
                }
                else { MessageBox.Show(alumno) ; }
            }
            else { MessageBox.Show("No hay alumnos"); }
        }

        private void btnAlumnosEnCurso_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
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
            else { MessageBox.Show("No hay alumnos"); }
        }

        private void btnAñadirNota_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
            {
                string dni = Interaction.InputBox("DNI del alumno");
                if (listaAlumnos.Contains(dni))
                {
                    int i = listaAlumnos.FindIndex(dni);
                    string notas = Interaction.InputBox("Notas separadas con ';'");
                    List<string> listaNotasTemp = notas.Split(';').ToList();
                    List<double> listaNotas = new List<double>();
                    foreach (string nota in listaNotasTemp)
                    {
                        listaNotas.Add(double.Parse(nota));
                    }
                    listaAlumnos.List()[i].Notas = listaNotas;
                    MessageBox.Show("Notas añadidas");
                }
                else { MessageBox.Show("Ningun alumno coincide con ese DNI"); }
            }
            else { MessageBox.Show("No hay alumnos"); }
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
            {
                string dni = Interaction.InputBox("DNI del alumno");
                if (listaAlumnos.Contains(dni))
                {
                    bool continuar = true;
                    int indice = listaAlumnos.FindIndex(dni);
                    string notas = Interaction.InputBox("Notas a eliminar separadas con ';'");
                    List<double> listaNotasTemp = UtilidadesListas.StringToDouble(notas.Split(';').ToList());
                    for (int i = 0; i < listaNotasTemp.Count(); i++)
                    {
                        for (int j = 0; j < listaAlumnos.List()[indice].Notas.Count() && continuar; j++)
                        {
                            if (listaNotasTemp.Contains(listaAlumnos.List()[indice].Notas[i]))
                            {
                                listaAlumnos.List()[indice].Notas.Remove(listaNotasTemp[i]);
                                continuar = false;
                            }
                        }
                        continuar = true;
                    }
                    MessageBox.Show("Notas eliminadas");
                }
                else { MessageBox.Show("Ningun alumno coincide con ese DNI"); }
            }
            else { MessageBox.Show("No hay alumnos"); }
        }

        private void btnMediaMayor_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
            {
                int media = 5;
                string salida = string.Empty;
                for (int i = 0; i < listaAlumnos.Count(); i++)
                {
                    if (listaAlumnos.List()[i].Media >= media)
                    {
                        salida += listaAlumnos.List()[i].ToString();
                    }
                }
                if (salida == string.Empty)
                {
                    MessageBox.Show("No hay ningun alumno con media igual o superior a 5");
                }
                else { MessageBox.Show(salida); }
            }
            else { MessageBox.Show("No hay alumnos"); }
        }

        private void btnMediaMenor_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Count() > 0)
            {
                int media = 5;
                string salida = string.Empty;
                for (int i = 0; i < listaAlumnos.Count(); i++)
                {
                    if (listaAlumnos.List()[i].Media < media)
                    {
                        salida += listaAlumnos.List()[i].ToString();
                    }
                }
                if (salida == string.Empty)
                {
                    MessageBox.Show("No hay ningun alumno con media igual o superior a 5");
                }
                else { MessageBox.Show(salida); }
            }
            else { MessageBox.Show("No hay alumnos"); }
        }
    }
}
