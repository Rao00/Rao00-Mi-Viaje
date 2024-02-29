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
            try
            {
                string dni = Interaction.InputBox("Documento nacional de identidad del alumno");
                string nombre = Interaction.InputBox("Nombre del alumno");
                string telefono = Interaction.InputBox("Numero de contacto del alumno");
                if (listaAlumnos.New(dni, nombre, telefono) == 1)
                {
                    MessageBox.Show("Alumno añadido");
                }
            }
            catch (ArgumentException aex) { MessageBox.Show(aex.Message); }   
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
            /*string txtEmpleados;
            if (listaEmpleados.Count() > 1)
            {
                listaEmpleados.SortEmpleados();
                txtEmpleados = listaEmpleados.VerEmpleados();
                if (txtEmpleados != string.Empty)
                {
                    MessageBox.Show(txtEmpleados);
                }
                else { MessageBox.Show($"No existen empleados"); }
            }
            else
            {
                MessageBox.Show("No hay sufiencientes empleados para ordenar");
            }*/
        }
    }
}
