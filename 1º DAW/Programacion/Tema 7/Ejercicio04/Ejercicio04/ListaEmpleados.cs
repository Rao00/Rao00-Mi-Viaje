using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    internal class ListaEmpleados
    {
        private List<Empleado> ListaPrincipal;
        public ListaEmpleados()
        {
            ListaPrincipal = new List<Empleado>();
        }
        public void NewEmpleado(string nombre, int edad)
        {
            Empleado empleadoTemp = new Empleado();
            empleadoTemp.Nombre = nombre;
            empleadoTemp.Edad = edad;
            ListaPrincipal.Add(empleadoTemp);
        }
        public void CumplEmpleado(string nombre)
        {
            bool encontrado = false;
            for(int i = 0; i < ListaPrincipal.Count(); i++)
            {
                if(ListaPrincipal[i].Nombre == nombre)
                {
                    ListaPrincipal[i].Cumple();
                    encontrado = true;
                }
            }
            if (!encontrado) { MessageBox.Show("Empleado no encontrado"); }
        }
        public string VerEmpleados()
        {
            string salida = string.Empty;
            for (int i = 0; i < ListaPrincipal.Count(); i++)
            {
                salida += $"Nombre: {ListaPrincipal[i].Nombre}\nEdad: {ListaPrincipal[i].Edad}\n";
                if (ListaPrincipal[i].ListaVentas.Count() > 0)
                {
                    salida += $"Ventas:\n";
                    for (int j = 0; j < ListaPrincipal[i].ListaVentas.Count(); j++)
                    {
                        salida += $"{j+1}.- {ListaPrincipal[i].ListaVentas[j]} €\n";
                    }
                }
                else { salida += "Empleado sin ventas\n"; }
            }
            return salida;
        }
        public int Count()
        {
            return ListaPrincipal.Count();
        }
        public void AñadirVentas()
        {
            bool sigo = true;
            double venta;
            int indice = 0;
            string nombre = Interaction.InputBox("Nombre Empleado", "Nombre Empleado");
            while (indice < ListaPrincipal.Count() && sigo)
            {
                if (ListaPrincipal[indice].Nombre == nombre)
                {
                    sigo = false;
                }
                else { indice++; }
                
                
            }
            sigo = true;
            while (sigo)
            {
                venta = double.Parse(Interaction.InputBox("Nueva venta", "Nueva venta"));
                ListaPrincipal[indice].ListaVentas.Add(venta);
                if (MessageBox.Show("Quieres añadir mas ventas?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    sigo = false;
                }
            }
        }
    }
}
