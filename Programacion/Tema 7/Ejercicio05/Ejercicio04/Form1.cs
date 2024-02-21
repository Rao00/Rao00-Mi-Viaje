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
            if (listaEmpleados.DeleteEmpleado(nombre))
            {
                MessageBox.Show($"Empleado {nombre} a sido eliminado");
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }

        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            string txtEmpleados = listaEmpleados.VerEmpleados();
            if (txtEmpleados != null)
            {
                MessageBox.Show(txtEmpleados);
            }
            else { MessageBox.Show($"No existen empleados"); }   
            
        }

        private void btnSortAlphOrder_Click(object sender, EventArgs e)
        {
            string txtEmpleados = listaEmpleados.VerEmpleados();
            listaEmpleados.SortEmpleados();
            if (txtEmpleados != null)
            {
                MessageBox.Show(txtEmpleados);
            }
            else { MessageBox.Show($"No existen empleados"); }
        }

        private void btnShowEmpl_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Inserta empleado a buscar");
            string txtEmpleados = listaEmpleados.VerEmpleados(nombre);
            if (txtEmpleados != null)
            {
                MessageBox.Show(txtEmpleados);
            }
            else { MessageBox.Show($"No existen empleados"); }  
        }

/*------------------------------------------------------------------------------------------------*/

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            double venta;
            bool cont = true;
            string nombre = Interaction.InputBox("Nombre Empleado", "Nombre Empleado");
            while (cont)
            {
                if (MessageBox.Show("Quieres añadir mas ventas?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    venta = double.Parse(Interaction.InputBox("Nueva venta", "Nueva venta"));
                    if(!listaEmpleados.AñadirVentas(nombre, venta))
                    {
                        cont = false;
                    }
                }
                else { cont = false; }
            }
            
        }

        private void btnShowMostSells_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaEmpleados.MostSells());
        }

        private void btnDeleteVentas_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Empleado al que limpiar las ventas");
            if (listaEmpleados.DeleteVentas(nombre))
            {
                MessageBox.Show($"Las ventas de {nombre} han sido eliminadas");
            }
            else { MessageBox.Show("El empleado no existe"); }
            
        }

        private void btnSortVentas_Click(object sender, EventArgs e)
        {
            listaEmpleados.SortEmpleadosVentas();
            string txtEmpleados = listaEmpleados.VerEmpleados();
            listaEmpleados.SortEmpleados();
            if (txtEmpleados != null)
            {
                MessageBox.Show(txtEmpleados);
            }
            else { MessageBox.Show($"No existen empleados"); }
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
