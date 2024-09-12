using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListaEmpleados listaEmpleados = new ListaEmpleados();

        private void btnNewEmpleado_Click(object sender, EventArgs e)
        {
            var nuevoEmpleado = añadirEmpleado();
            listaEmpleados.NewEmpleado(nuevoEmpleado.nombre, nuevoEmpleado.edad);
        }

        (string nombre, int edad) añadirEmpleado()
        {
            string nombre = "";
            int edad = 0;
            try
            {
                nombre = Interaction.InputBox("Nombre Empleado", "Nombre Empleado");
                if (!Regex.IsMatch(nombre, @"^[a-zA-ZñÑáÁéÉíÍóÓúÚçÇ]+"))
                {
                    throw new FormatException();
                }
                edad = int.Parse(Interaction.InputBox("Edad Empleado", "Edad Empleado"));
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Insert a correct value");
            }
            return (nombre, edad);
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaEmpleados.VerEmpleados());
        }

        private void btnAddEdad_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Nombre Empleado", "Nombre Empleado");
            listaEmpleados.CumplEmpleado(nombre);
        }

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            listaEmpleados.AñadirVentas();
        }
    }
}
