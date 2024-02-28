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
                string apellidos = Interaction.InputBox("Apellidos del alumno");
                string telefono = Interaction.InputBox("Numero de contacto del alumno");
                if (listaAlumnos.New(dni, nombre, apellidos, telefono) == 1)
                {
                    MessageBox.Show("Alumno añadido");
                }
                else
                {
                    MessageBox.Show("Alumno no añadido (error)");
                }
            }
            catch (ArgumentException aex) { MessageBox.Show(aex.Message); }
            
        }
    }
}
