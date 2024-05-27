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
    public partial class AdministrarAdmins : Form
    {
        // Atributos para almacenar el DNI y el tipo de la persona administradora
        private string DNI, tipo;

        // Instancia de SqlDBHelper para interactuar con la base de datos
        private SqlDBHelper dbHelper;

        // Evento Click del botón Aplicar cambios
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            // Aplica los cambios en los datos de la persona administradora
            dbHelper.AlterAdministradores(DNI, txtOrdenador.Text, txtHoras.Text, txtPisoAsignado.Text);
            // Muestra un mensaje informando que se aplicaron los cambios
            MessageBox.Show("Cambios Aplicados", "Cambios Realizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Cierra el formulario de administración de administradores
            this.Close();
        }

        // Evento Load del formulario
        private void AdministrarAdmins_Load(object sender, EventArgs e)
        {
            // Carga el DNI de la persona administradora en el campo de texto correspondiente
            txtDNI.Text = DNI;
        }

        // Evento Click del botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario de administración de administradores sin aplicar cambios
            this.Close();
        }

        // Constructor de la clase AdministrarAdmins
        public AdministrarAdmins(SqlDBHelper dbHelper, string DNI, string tipo)
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
    }
}