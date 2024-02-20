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
using System.Security.Permissions;

namespace Ejercicio04
{
    public partial class EmpleadosVentas : Form
    {
        public EmpleadosVentas()
        {
            InitializeComponent();
        }

/*------------------------------------------------------------------------------------------------*/

        ListaEmpleados listaEmpleados = new ListaEmpleados();

/*------------------------------------------------------------------------------------------------*/

        private void btnNewEmpleado_Click(object sender, EventArgs e)
        {
            bool repetido = false;
            var nuevoEmpleado = añadirEmpleado();
            for(int i = 0; i < listaEmpleados.Count() && !repetido; i++)
            {
                if (String.Compare(listaEmpleados.LookForName(i), nuevoEmpleado.nombre) == 0)
                {
                    repetido = true;
                    MessageBox.Show($"El empleado {nuevoEmpleado.nombre} ya existe");
                }
            }
            if (!repetido) { listaEmpleados.NewEmpleado(nuevoEmpleado.nombre, nuevoEmpleado.edad); }
        }

        private void btnDeleteEmpl_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Inserta empleado a eliminar");
            listaEmpleados.DeleteEmpleado(nombre);
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaEmpleados.VerEmpleados());
        }

        private void btnSortAlphOrder_Click(object sender, EventArgs e)
        {
            listaEmpleados.SortEmpleados();
            MessageBox.Show("Empleados ordenados");
            listaEmpleados.VerEmpleados();
        }

        private void btnShowEmpl_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Inserta empleado a buscar");
            MessageBox.Show(listaEmpleados.VerEmpleados(nombre));
        }

/*------------------------------------------------------------------------------------------------*/

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            listaEmpleados.AñadirVentas();
        }

        private void btnShowMostSells_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaEmpleados.MostSells());
        }

        private void btnDeleteVentas_Click(object sender, EventArgs e)
        {
            listaEmpleados.DeleteVentas();
        }

        private void btnSortVentas_Click(object sender, EventArgs e)
        {
            listaEmpleados.SortEmpleadosVentas();
            MessageBox.Show("Empleados ordenados");
            listaEmpleados.VerEmpleados();
        }

/*------------------------------------------------------------------------------------------------*/

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
            catch (FormatException)
            {
                MessageBox.Show("Insert a correct value");
            }
            return (nombre, edad);
        }

    }
}
