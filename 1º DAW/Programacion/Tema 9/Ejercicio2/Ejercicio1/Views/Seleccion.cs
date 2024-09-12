using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Seleccion : Form
    {
        private string DNI, tipo;
        private SqlDBHelper dbHelper;

        public Seleccion(SqlDBHelper dbHelper, string DNI, string tipo)
        {
            InitializeComponent();
            this.DNI = DNI;
            this.tipo = tipo;
            this.dbHelper = dbHelper;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("Está seguro que quiere añadir un administrador\nEl usuario prodrá:\n\n- Manipular cuentas de usuario\n- Acceder a la base de datos libremente\n- Crear nuevos usuarios\n- Eliminar usuarios ya existentes\n\nConfirma esta accion?", "Añadir Administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmacion == DialogResult.Yes) { AdministrarAdmins admins = new AdministrarAdmins(dbHelper, DNI, dbHelper.GetType(DNI)); this.Hide(); admins.ShowDialog(); dbHelper.ReadTable("Administradores"); this.Close(); }
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("Está seguro que quiere añadir un profesor\nEl usuario prodrá:\n\n- Acceder a datos de alumnos\n- Gestionar los cursos\n- Leer sus datos\n\nConfirma esta accion?", "Añadir Profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes) { AdministrarProfesores admins = new AdministrarProfesores(dbHelper, DNI, dbHelper.GetType(DNI)); this.Hide(); admins.ShowDialog(); dbHelper.ReadTable("Profesores"); this.Close(); }
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("Está seguro que quiere añadir un alumno\nEl usuario prodrá:\n\n- Acceder sus datos\n- Ver los profesores asignados a su curso\n\nConfirma esta accion?", "Añadir Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes) { AdministrarAlumnos admins = new AdministrarAlumnos(dbHelper, DNI, dbHelper.GetType(DNI)); this.Hide(); admins.ShowDialog(); dbHelper.ReadTable("Alumnos"); this.Close(); }
        }
    }
}
