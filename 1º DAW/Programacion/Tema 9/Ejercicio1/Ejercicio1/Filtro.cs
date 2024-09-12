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

namespace Ejercicio1
{
    public partial class Filtro : Form
    {
        DataSet textData;
        DataSet outputData;
        SqlConnection sql;
        List<RadioButton> radioButtons = new List<RadioButton>();

        public Filtro(SqlConnection _sql)
        {
            InitializeComponent();
            textData = new DataSet();
            this.sql = _sql;
        }

        public DataSet DataText
        {
            get { return outputData; }
        }

        private string FiltrarBusqueda(string tipoFiltro)
        {
            sql.Open();
            string consulta;
            string filtro = txtFiltro.Text.ToLower();
            int tamFiltro = filtro.Length;
            string salida = string.Empty;
            if (tamFiltro <= 0)
            {
                consulta = $"SELECT {tipoFiltro}, DNI FROM Profesores";
            }
            else if (tipoFiltro == "DNI")
            {
                consulta = $"SELECT DNI, Nombre FROM Profesores WHERE LEFT(DNI, {tamFiltro}) = '{filtro}'";
            }
            else
            {
                consulta = $"SELECT {tipoFiltro}, DNI FROM Profesores WHERE LEFT({tipoFiltro}, {tamFiltro}) = '{filtro}'";
            }
            textData = new DataSet();
            SqlDataAdapter adapterNombre = new SqlDataAdapter(consulta, sql);
            adapterNombre.Fill(textData, "Profesores");    
            foreach(DataRow nombres in textData.Tables["Profesores"].Rows)
            {
                salida += ($"{nombres[0]} - {nombres[1]}\n");
            }
            sql.Close();
            return salida;
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            radioButtons.Add(rbDNI);
            radioButtons.Add(rbNombre);
            radioButtons.Add(rbApellido);
            radioButtons.Add(rbCorreo);
            radioButtons.Add(rbTelefono);
        }

        private void rbDNI_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in radioButtons) 
            { 
                if (radioButton.Name != "rbDNI")
                {
                    radioButton.Checked = false;
                }     
            }
            txtResultados.Text = FiltrarBusqueda("DNI");
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbNombre")
                {
                    radioButton.Checked = false;
                }
            }
            txtResultados.Text = FiltrarBusqueda("Nombre");
        }

        private void rbApellido_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbApellido")
                {
                    radioButton.Checked = false;
                }
            }
            txtResultados.Text = FiltrarBusqueda("Apellido");
        }

        private void rbTelefono_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbTelefono")
                {
                    radioButton.Checked = false;
                }
            }
            txtResultados.Text = FiltrarBusqueda("Tlf");
        }

        private void rbCorreo_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Name != "rbCorreo")
                {
                    radioButton.Checked = false;
                }
            }
            txtResultados.Text = FiltrarBusqueda("EMail");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            RadioButton tempRadioButton = new RadioButton();
            string tipoFiltro = "";
            foreach(RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    tempRadioButton = radioButton;
                }
            }
            switch (tempRadioButton.Name)
            {
                case "rbDNI":
                    tipoFiltro = "DNI";
                    break;
                case "rbNombre":
                    tipoFiltro = "Nombre";
                    break;
                case "rbApellido":
                    tipoFiltro = "Apellido";
                    break;
                case "rbTelefono":
                    tipoFiltro = "Tlf";
                    break;
                case "rbCorreo":
                    tipoFiltro = "EMail";
                    break;
            }
            txtResultados.Text = FiltrarBusqueda(tipoFiltro);
        }

        private void btnNoFiltrar_Click(object sender, EventArgs e)
        {
            sql.Open();
            string consulta = "SELECT * FROM Profesores";
            textData = new DataSet();
            SqlDataAdapter tempAdapter = new SqlDataAdapter(consulta, sql);
            tempAdapter.Fill(textData, "Profesores");
            sql.Close();
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
