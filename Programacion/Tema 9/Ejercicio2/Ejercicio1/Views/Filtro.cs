using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio1
{
    public partial class Filtro : Form
    {
        // Instancia de SqlDBHelper para interactuar con la base de datos
        SqlDBHelper dbHelper;
        // Listas para almacenar los RadioButton de los filtros y tipos de tabla
        List<RadioButton> radioButtons = new List<RadioButton>();
        List<RadioButton> radioType = new List<RadioButton>();
        // Variables para almacenar el tipo de filtro y la tabla seleccionados
        string tipoFiltro;
        string tabla;

        // Constructor de la clase Filtro
        public Filtro(SqlDBHelper _dbHelper)
        {
            InitializeComponent();
            // Asigna la instancia de SqlDBHelper recibida al atributo correspondiente
            this.dbHelper = _dbHelper;
        }

        // Evento Load del formulario
        private void Filtro_Load(object sender, EventArgs e)
        {
            // Agrega los RadioButton de los filtros a la lista correspondiente
            radioButtons.Add(rbDNI);
            radioButtons.Add(rbNombre);
            radioButtons.Add(rbApellido);
            radioButtons.Add(rbCorreo);
            radioButtons.Add(rbTelefono);

            // Agrega los RadioButton de los tipos de tabla a la lista correspondiente
            radioType.Add(rbAdmin);
            radioType.Add(rbProfesores);
            radioType.Add(rbAlumnos);
            radioType.Add(rbTodos);
        }

        // Evento CheckedChanged del RadioButton DNI
        private void rbDNI_CheckedChanged(object sender, EventArgs e)
        {
            // Establece el tipo de filtro como DNI y actualiza el TextBox de resultados
            rbDNI.Checked = true;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbDNI")
                {
                    radioButton.Checked = false;
                }
            }
            tipoFiltro = "DNI";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Nombre
        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            // Establece el tipo de filtro como nombre y actualiza el TextBox de resultados
            rbNombre.Checked = true;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbNombre")
                {
                    radioButton.Checked = false;
                }
            }
            tipoFiltro = "nombre";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Apellido
        private void rbApellido_CheckedChanged(object sender, EventArgs e)
        {
            // Establece el tipo de filtro como apellido y actualiza el TextBox de resultados
            rbApellido.Checked = true;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbApellido")
                {
                    radioButton.Checked = false;
                }
            }
            tipoFiltro = "apellido";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Teléfono
        private void rbTelefono_CheckedChanged(object sender, EventArgs e)
        {
            // Establece el tipo de filtro como teléfono y actualiza el TextBox de resultados
            rbTelefono.Checked = true;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbTelefono")
                {
                    radioButton.Checked = false;
                }
            }
            tipoFiltro = "telefono";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Correo
        private void rbCorreo_CheckedChanged(object sender, EventArgs e)
        {
            // Establece el tipo de filtro como correo y actualiza el TextBox de resultados
            rbCorreo.Checked = true;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbCorreo")
                {
                    radioButton.Checked = false;
                }
            }
            tipoFiltro = "email";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Profesores
        private void rbtnProfesores_CheckedChanged(object sender, EventArgs e)
        {
            // Establece la tabla como Profesores y actualiza el TextBox de resultados
            rbProfesores.Checked = true;
            foreach (RadioButton radioButton in radioType)
            {
                if (radioButton.Name != "rbProfesores")
                {
                    radioButton.Checked = false;
                }
            }
            tabla = "Profesores";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Administradores
        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            // Establece la tabla como Administradores y actualiza el TextBox de resultados
            rbAdmin.Checked = true;
            foreach (RadioButton radioButton in radioType)
            {
                if (radioButton.Name != "rbAdmin")
                {
                    radioButton.Checked = false;
                }
            }
            tabla = "Administradores";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Alumnos
        private void rbtnAlumnos_CheckedChanged(object sender, EventArgs e)
        {
            // Establece la tabla como Alumnos y actualiza el TextBox de resultados
            rbAlumnos.Checked = true;
            foreach (RadioButton radioButton in radioType)
            {
                if (radioButton.Name != "rbAlumnos")
                {
                    radioButton.Checked = false;
                }
            }
            tabla = "Alumnos";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento CheckedChanged del RadioButton Todos
        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            // Establece la tabla como Personas y actualiza el TextBox de resultados
            rbTodos.Checked = true;
            foreach (RadioButton radioButton in radioType)
            {
                if (radioButton.Name != "rbTodos")
                {
                    radioButton.Checked = false;
                }
            }
            tabla = "Personas";
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento TextChanged del TextBox de filtro
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            // Actualiza el TextBox de resultados con el filtro aplicado
            txtResultados.Text = dbHelper.Filter(txtFiltro.Text, tipoFiltro, tabla);
        }

        // Evento Click del botón No Filtrar
        private void btnNoFiltrar_Click(object sender, EventArgs e)
        {
            // Restablece la tabla como Personas y cierra el formulario
            dbHelper.ReadTable("Personas");
            this.Close();
        }

        // Evento Click del botón Filtrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }
    }
}