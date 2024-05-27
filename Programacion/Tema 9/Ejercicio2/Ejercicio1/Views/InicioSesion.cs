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
    public partial class InicioSesion : Form
    {
        private SqlDBHelper dbHelper = new SqlDBHelper();

        public InicioSesion()
        {
            InitializeComponent();
        }

        // Evento Load del formulario InicioSesion
        private void InicioSesion_Load(object sender, EventArgs e)
        {
            // Lee las tablas necesarias al cargar el formulario
            dbHelper.ReadTable("Usuarios");
            dbHelper.ReadTable("Profesores");
            dbHelper.ReadTable("Alumnos");
            dbHelper.ReadTable("Administradores");
            dbHelper.ReadTable("Personas");
        }

        // Evento Click del botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Variable para controlar si se ha encontrado el usuario y contraseña
            bool encontrado = false;
            // Obtiene la tabla de usuarios
            DataTable dataSet = dbHelper.GetTable("Usuarios");
            // Obtiene la clave primaria del usuario (sin el prefijo)
            string pk = (txtUsuario.Text).Substring(2);
            // Verifica si la tabla de usuarios contiene la clave primaria
            if (dbHelper.Contains(pk, "Usuarios"))
            {
                // Itera sobre las filas de la tabla de usuarios
                for (int i = 0; i < dataSet.Rows.Count; i++)
                {
                    // Comprueba si el usuario y la contraseña coinciden con una fila de la tabla
                    if (dataSet.Rows[i][1].ToString() == txtUsuario.Text && dataSet.Rows[i][2].ToString() == txtContraseña.Text)
                    {
                        encontrado = true;
                        // Obtiene el tipo de usuario (rol) a partir de la clave primaria
                        string type = dbHelper.GetType(dataSet.Rows[i][0].ToString());
                        if (type != null)
                        {
                            // Establece la clave primaria del usuario actual en el DBHelper
                            dbHelper.DNIUsuario = pk;
                            // Abre el formulario correspondiente según el tipo de usuario
                            AdministrarPersonas administrarPersonas = new AdministrarPersonas(dbHelper, pk, type);
                            this.Hide();
                            administrarPersonas.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            // Muestra un mensaje de advertencia si el usuario no tiene un rol asignado
                            MessageBox.Show("El usuario no tiene asignado un rol, ponte en contacto con el administrador más cercano", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            // Si el usuario no se encuentra, muestra un mensaje de error y limpia los campos
            if (!encontrado)
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}