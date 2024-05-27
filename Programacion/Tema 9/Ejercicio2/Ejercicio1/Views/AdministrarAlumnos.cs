using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class AdministrarAlumnos : Form
    {
        // Atributos para almacenar el DNI y el tipo de la persona administrada
        private string DNI, tipo;

        // Instancia de SqlDBHelper para interactuar con la base de datos
        private SqlDBHelper dbHelper;

        // Constructor de la clase AdministrarAlumnos
        public AdministrarAlumnos(SqlDBHelper dbHelper, string DNI, string tipo)
        {
            // Inicializa los componentes del formulario
            InitializeComponent();
            // Asigna el DNI y el tipo recibidos a los atributos correspondientes
            this.DNI = DNI;
            this.tipo = tipo;
            // Asigna la instancia de SqlDBHelper recibida al atributo correspondiente
            this.dbHelper = dbHelper;
            // Lee la tabla de Cursos de la base de datos
            dbHelper.ReadTable("Cursos");
        }

        // Evento TextChanged del campo de texto Curso Asignado
        private void txtCursoAsignado_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el curso asignado ingresado existe en la tabla de Cursos
            if (!dbHelper.Contains(txtCursoAsignado.Text, "Cursos"))
            {
                txtCursoAsignado.BackColor = Color.Firebrick; // Cambia el color de fondo a rojo si el curso no existe
            }
            else
            {
                txtCursoAsignado.BackColor = SystemColors.Control; // Restablece el color de fondo predeterminado si el curso existe
            }
        }

        // Evento Click del botón Aplicar cambios
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            // Aplica los cambios en los datos del alumno
            dbHelper.AlterAlumnos(DNI, txtCursoAsignado.Text, double.Parse(txtNotaMedia.Text));
            // Muestra un mensaje informando que se aplicaron los cambios
            MessageBox.Show("Cambios Aplicados", "Cambios Realizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Cierra el formulario de administración de alumnos
            this.Close();
        }

        // Evento Click del botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario de administración de alumnos sin aplicar cambios
            this.Close();
        }

        // Evento Load del formulario
        private void AdministrarProfesores_Load(object sender, EventArgs e)
        {
            // Muestra el DNI del alumno en el campo de texto correspondiente
            txtDNI.Text = DNI;

            // Si el alumno existe en la base de datos, carga sus datos en los campos correspondientes
            if (dbHelper.Contains(DNI, "Alumnos"))
            {
                dbHelper.QueryTable("Alumnos", $"SELECT * FROM Alumnos WHERE DNI = '{DNI}'");
                txtCursoAsignado.Text = dbHelper.ReadRow(0, "Alumnos")[1].ToString();
                txtNotaMedia.Text = dbHelper.ReadRow(0, "Alumnos")[2].ToString();
                ComprobarAplicar();
            }
        }

        // Método para verificar si se puede aplicar cambios en los datos del alumno
        private void ComprobarAplicar()
        {
            // Obtiene el tipo de usuario actual (Administrador, Profesor, Alumno)
            string tipoUsuario = dbHelper.GetType(dbHelper.DNIUsuario);

            // Habilita el botón Aplicar solo si el usuario actual es un Administrador
            if (tipoUsuario == "Administrador")
            {
                btnAplicar.Enabled = true;
            }
            else
            {
                btnAplicar.Enabled = false;
            }
        }
    }
}
