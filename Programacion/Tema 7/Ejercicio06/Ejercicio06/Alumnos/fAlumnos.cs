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

        public fAlumnos(ListaAlumnos listaAlumnos)
        {
            InitializeComponent();
            this.listaAlumnos = listaAlumnos;
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
            listaAlumnos.Sort();
            MessageBox.Show("Lista ordenada");
        }

        private void btnShowAlumno_Click(object sender, EventArgs e)
        {
            string alumno = listaAlumnos.LookFor(Interaction.InputBox("Introduce el DNI del alumno a buscar"));
            if (alumno == string.Empty)
            {
                MessageBox.Show("El alumno no existe");
            }
            else { MessageBox.Show(alumno) ; }
        }
    }
}
