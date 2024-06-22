using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualBasic;

namespace Ejercicio1
{
    public partial class AdministrarPersonas : Form
    {
        // Colores para indicar errores y estado normal
        private Color colorError = Color.FromArgb(255, 255, 192, 192);
        private Color colorBlanco = Color.FromArgb(255, 255, 255, 255);

        // Instancia del DBHelper y variables de información de usuario
        private SqlDBHelper dbHelper;
        private string DNI, tipo;

        // Variables de validación de campos
        private bool registroDNI = false;
        private bool registroNombre = false;
        private bool registroApellidos = false;
        private bool registroTelefono = false;
        private bool registroEmail = false;

        // Lista de TextBoxes para facilitar el manejo
        private List<TextBox> txts = new List<TextBox>();

        // Constructor
        public AdministrarPersonas(SqlDBHelper dbHelper, string DNI, string tipo)
        {
            InitializeComponent();
            this.DNI = DNI;
            this.tipo = tipo;
            this.dbHelper = dbHelper;
        }

        // Evento Load del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar datos según el tipo de usuario
            switch (tipo)
            {
                case "Profesor":
                    dbHelper.QueryTable("Personas", $"SELECT * FROM Personas WHERE DNI = ANY(SELECT DNI FROM Alumnos WHERE codCurso = ANY(SELECT cursoAsignado FROM Profesores WHERE DNI = '{DNI}'))");
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnFiltrar.Enabled = false;
                    break;
                case "Alumno":
                    dbHelper.QueryTable("Personas", $"SELECT * FROM Personas WHERE DNI = ANY(SELECT DNI FROM Profesores WHERE cursoAsignado = ANY(SELECT codCurso FROM Alumnos WHERE DNI = '{DNI}'))");
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnFiltrar.Enabled = false;
                    break;
                default:
                    dbHelper.Filter("", "DNI", "Personas");
                    break;
            }

            // Mostrar mensaje si hay registros
            if (dbHelper.LastPos() > 0)
            {
                CambiarDatos(dbHelper.ReadRow(0));
            }
            else
            {
                // Limpiar campos y deshabilitar botones si no hay registros
                foreach (TextBox txt in txts)
                {
                    txt.Text = string.Empty;
                }
                lblNumRegistro.Text = "Sin Registros";
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
            ComprobarBotones();
            btnLimpiar.Enabled = HabilitarLimpiar();

            // Añadir TextBoxes a la lista
            txts.Add(txtDni);
            txts.Add(txtNombre);
            txts.Add(txtApellidos);
            txts.Add(txtTelefono);
            txts.Add(txtEmail);

            // Deshabilitar edición si no es un administrador
            if (tipo != "Administrador")
            {
                foreach (TextBox txt in txts)
                {
                    txt.Enabled = false;
                }
                btnGuardarNuevo.Enabled = false;
            }
        }

        // Método para cambiar los datos mostrados en el formulario
        private void CambiarDatos(DataRow dataFila)
        {
            lblNumRegistro.Text = $"Registro = {dbHelper.ActPos + 1} | {dbHelper.LastPos()}";
            dbHelper.GetTable("Personas");
            txtDni.Text = dataFila[0].ToString();
            txtNombre.Text = dataFila[1].ToString();
            txtApellidos.Text = dataFila[2].ToString();
            txtTelefono.Text = dataFila[3].ToString();
            txtEmail.Text = dataFila[4].ToString();
        }

        // Método para habilitar o deshabilitar el botón de limpiar
        private bool HabilitarLimpiar()
        {
            if ((txtDni.Text.Length, txtNombre.Text.Length, txtApellidos.Text.Length, txtTelefono.Text.Length, txtEmail.Text.Length) == (0, 0, 0, 0, 0))
            {
                return false;
            }
            else
            {
                if (tipo == "Administrador")
                    return true;
                else
                    return false;
            }
        }

        // Método para comprobar el estado de los botones de navegación
        private void ComprobarBotones()
        {
            // Deshabilitar botones si es el primer o último registro
            if (dbHelper.ActPos <= 0)
            {
                btnAnterior.Enabled = false;
                btnAnterior.BackColor = SystemColors.ControlLight;
                btnPrincipio.Enabled = false;
                btnPrincipio.BackColor = SystemColors.ControlLight;
            }
            else
            {
                btnAnterior.Enabled = true;
                btnAnterior.BackColor = SystemColors.ButtonHighlight;
                btnPrincipio.Enabled = true;
                btnPrincipio.BackColor = SystemColors.ButtonHighlight;
            }

            if (dbHelper.ActPos >= dbHelper.LastPos() - 1)
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.BackColor = SystemColors.ControlLight;
                btnFinal.Enabled = false;
                btnFinal.BackColor = SystemColors.ControlLight;
            }
            else
            {
                btnSiguiente.Enabled = true;
                btnSiguiente.BackColor = SystemColors.ButtonHighlight;
                btnFinal.Enabled = true;
                btnFinal.BackColor = SystemColors.ButtonHighlight;
            }

            // Ocultar botón de error si el DNI es válido
            if (dbHelper.GetType(txtDni.Text) != null)
            {
                btnError.Visible = false;
            }
            else
            {
                btnError.Visible = true;
            }
        }

        // Método para comprobar la validez de todos los campos
        private bool ComprobarValidez()
        {
            if (registroDNI && registroNombre && registroApellidos && registroTelefono && registroEmail)
            {
                return true;
            }
            else { return false; }
        }

        // Método para comprobar la validez de todos los campos excepto el DNI
        private bool ComprobarValidezSinDNI()
        {
            if (registroNombre && registroApellidos && registroTelefono && registroEmail)
            {
                return true;
            }
            else { return false; }
        }

        // Método para comprobar si ya existe un DNI en la base de datos
        private bool ExisteDNI()
        {
            foreach (DataRow row in dbHelper.GetTable().Rows)
            {
                if (row[0].ToString() == txtDni.Text)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para comprobar si ha habido cambios en los campos editables
        private bool ComprobarCambios()
        {
            bool cambio = false;

            for (int i = 0; i < 5; i++)
            {
                if (dbHelper.GetTable().Rows[dbHelper.ActPos][i].ToString() != txts[i].Text)
                {
                    cambio = true;
                }
            }

            return cambio;
        }

        // Método para actualizar un registro existente
        private void Actualizar()
        {
            if (ExisteDNI())
            {
                if (ComprobarValidezSinDNI())
                {
                    Persona persona = new Persona(txtDni.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
                    dbHelper.UpdatePersona(persona);
                    ComprobarBotones();
                    dbHelper.ReadTable("Personas");
                }
                else
                {
                    MessageBox.Show("Hay campos erroneos");
                }
            }
            else
            {
                MessageBox.Show($"La persona con DNI {txtDni.Text} no existe");
            }
        }

        // Evento TextChanged del campo de DNI
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtDni.Text.ToUpper(), @"^[0-9]{8}[A-Z]{1}$") && txtDni.Text.Length != 0)
            {
                registroDNI = false;
                txtDni.BackColor = colorError;
            }
            else
            {
                registroDNI = (txtDni.Text.Length > 0);
                txtDni.BackColor = colorBlanco;
            }
        }

        // Evento TextChanged del campo de nombre
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtNombre.Text, @"^[A-Za-z\s]+$") && txtNombre.Text.Length != 0)
            {
                registroNombre = false;
                txtNombre.BackColor = colorError;
            }
            else
            {
                registroNombre = (txtNombre.Text.Length > 0);
                txtNombre.BackColor = colorBlanco;
            }
        }

        // Evento TextChanged del campo de teléfono
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtTelefono.Text, @"^[0-9]{9}$") && txtTelefono.Text.Length != 0)
            {
                registroTelefono = false;
                txtTelefono.BackColor = colorError;
            }
            else
            {
                registroTelefono = (txtTelefono.Text.Length > 0);
                txtTelefono.BackColor = colorBlanco;
            }
        }

        // Evento TextChanged del campo de apellidos
        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtApellidos.Text, @"^[A-Za-z\s]+$") && txtApellidos.Text.Length != 0)
            {
                registroApellidos = false;
                txtApellidos.BackColor = colorError;
            }
            else
            {
                registroApellidos = (txtApellidos.Text.Length > 0);
                txtApellidos.BackColor = colorBlanco;
            }
        }

        // Evento TextChanged del campo de email
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtEmail.Text.ToLower(), @"^[a-z]+[0-9-._]*[@]{1}[a-z.]+\.{1}[a-z]{2,}$") && txtEmail.Text.Length != 0)
            {
                registroEmail = false;
                txtEmail.BackColor = colorError;
            }
            else
            {
                registroEmail = (txtEmail.Text.Length > 0);
                txtEmail.BackColor = colorBlanco;
            }
        }

        // Evento Click del botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            btnLimpiar.Enabled = HabilitarLimpiar();
        }

        // Evento Click del botón Principio
        private void btnPrincipio_Click(object sender, EventArgs e)
        {
            if (ComprobarCambios())
            {
                DialogResult cambios; ;
                cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cambios == DialogResult.Yes) { Actualizar(); }
            }
            dbHelper.ActPos = 0;
            CambiarDatos(dbHelper.GetTable().Rows[dbHelper.ActPos]);
            ComprobarBotones();
            btnLimpiar.Enabled = HabilitarLimpiar();
        }

        // Evento Click del botón Anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dbHelper.ActPos > 0)
            {
                if (ComprobarCambios())
                {
                    DialogResult cambios;
                    cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cambios == DialogResult.Yes) { Actualizar(); }
                }
                dbHelper.ActPos--;
                CambiarDatos(dbHelper.GetTable().Rows[dbHelper.ActPos]);
                ComprobarBotones();
                btnLimpiar.Enabled = HabilitarLimpiar();
            }
        }

        // Evento Click del botón Siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dbHelper.ActPos < dbHelper.LastPos() - 1)
            {
                if (ComprobarCambios())
                {
                    DialogResult cambios;
                    cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cambios == DialogResult.Yes) { Actualizar(); }
                }
                dbHelper.ActPos++;
                CambiarDatos(dbHelper.GetTable().Rows[dbHelper.ActPos]);
                ComprobarBotones();
                btnLimpiar.Enabled = HabilitarLimpiar();
            }
        }

        // Evento Click del botón Final
        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (ComprobarCambios())
            {
                DialogResult cambios;
                cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cambios == DialogResult.Yes) { Actualizar(); }
            }
            dbHelper.ActPos = dbHelper.LastPos() - 1;
            CambiarDatos(dbHelper.GetTable().Rows[dbHelper.ActPos]);
            ComprobarBotones();
            btnLimpiar.Enabled = HabilitarLimpiar();
        }

        // Evento Click del botón Guardar Nuevo
        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (ComprobarValidez() && !ExisteDNI())
            {
                Persona persona = new Persona(txtDni.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
                dbHelper.AddPersona(persona);
                ComprobarBotones();
                CambiarDatos(dbHelper.ReadRow((dbHelper.LastPos() - 1), "Personas"));
            }
            else
            {
                if (ExisteDNI())
                {
                    MessageBox.Show("El DNI ya existe");
                }
                else
                {
                    MessageBox.Show("Hay campos erroneos");
                }
            }
            if (dbHelper.LastPos() - 1 > 0 && tipo == "Administrador")
            {
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }

        // Evento Click del botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        // Evento Click del botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ExisteDNI())
            {
                if (MessageBox.Show("¿Esta seguro de que desea eliminar el registro actual?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dbHelper.DeletePersona(txtDni.Text);
                    ComprobarBotones();
                    if (dbHelper.LastPos() - 1 > 0)
                    {
                        CambiarDatos(dbHelper.GetTable().Rows[dbHelper.ActPos]);
                    }
                    else
                    {
                        foreach (TextBox txt in txts)
                        {
                            txt.Text = string.Empty;
                        }
                        lblNumRegistro.Text = "Sin Registros";
                        btnEliminar.Enabled = false;
                        btnActualizar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Operacion abortada");
                }
            }
            else
            {
                MessageBox.Show($"El DNI {txtDni.Text} no existe");
            }
        }

        // Evento KeyDown del formulario
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
        }

        // Evento Click del botón Filtrar Profesores
        private void btnFiltrarProfesores_Click(object sender, EventArgs e)
        {
            Filtro filtroForm = new Filtro(dbHelper);
            filtroForm.ShowDialog();
            dbHelper.ActPos = 0;
            ComprobarBotones();
            if (dbHelper.LastPos() > 0)
            {
                CambiarDatos(dbHelper.GetTable("Personas").Rows[dbHelper.ActPos]);
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else
            {
                foreach (TextBox txt in txts)
                {
                    txt.Text = string.Empty;
                }
                lblNumRegistro.Text = "Sin Registros";
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }

        // Evento Click del botón More Info
        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            string tipo = dbHelper.GetType(txtDni.Text);
            switch (tipo)
            {
                case "Profesor":
                    AdministrarProfesores administrarProfesores = new AdministrarProfesores(dbHelper, txtDni.Text, dbHelper.GetType(txtDni.Text));
                    administrarProfesores.ShowDialog();
                    dbHelper.ReadTable("Profesores");
                    break;
                case "Alumno":
                    AdministrarAlumnos administrarAlumnos = new AdministrarAlumnos(dbHelper, txtDni.Text, dbHelper.GetType(txtDni.Text));
                    administrarAlumnos.ShowDialog();
                    dbHelper.ReadTable("Alumnos");
                    break;
                case "Administrador":
                    AdministrarAdmins administrarAdmins = new AdministrarAdmins(dbHelper, txtDni.Text, dbHelper.GetType(txtDni.Text));
                    administrarAdmins.ShowDialog();
                    dbHelper.ReadTable("Administradores");
                    break;
                default:
                    Seleccion seleccion = new Seleccion(dbHelper, txtDni.Text, dbHelper.GetType(txtDni.Text));
                    seleccion.ShowDialog();
                    break;
            }
            ComprobarBotones();
        }
    }
}