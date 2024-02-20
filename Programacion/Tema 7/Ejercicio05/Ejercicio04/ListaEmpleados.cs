using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public string VerEmpleados(string empleado = null)
        {
            string salida = string.Empty;
            int i;
            bool bucle = true;
            bool init_bucle = true;
            if (!string.IsNullOrEmpty(empleado))
            {
                i = LookForEmpleado(empleado);
                bucle = false;
            }
            else { i = 0; }
            while (i < ListaPrincipal.Count() && init_bucle)
            {
                if (i >= 0)
                {
                    salida += $"Nombre: {ListaPrincipal[i].Nombre}\nEdad: {ListaPrincipal[i].Edad}\n";
                    if (ListaPrincipal[i].ListaVentas.Count() > 0)
                    {
                        salida += $"Ventas:\n";
                        for (int j = 0; j < ListaPrincipal[i].ListaVentas.Count(); j++)
                        {
                            if (j == ListaPrincipal[i].ListaVentas.Count() - 1 && bucle)
                            {
                                salida += $"{j + 1}.- {ListaPrincipal[i].ListaVentas[j]} €\n\n";
                            }
                            else 
                            {
                                salida += $"{j + 1}.- {ListaPrincipal[i].ListaVentas[j]} €\n";
                            }
                        }
                    }
                    else { salida += "Empleado sin ventas\n\n"; }
                }
                else { MessageBox.Show($"Empleado {empleado} no existe"); }
                if(!bucle) { init_bucle = false; }
                i++;
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
                ListaPrincipal[indice].AddVenta(venta);
                if (MessageBox.Show("Quieres añadir mas ventas?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    sigo = false;
                }
            }
        }

        public void DeleteVentas()
        {
            int indice = LookForEmpleado(Interaction.InputBox("Empleado al que limpiar las ventas"));
            if(indice >= 0)
            {
                ListaPrincipal[indice].RemoveVenta();
            }
            else { MessageBox.Show("El empleado no existe"); }
        }

        public void DeleteEmpleado(string nombre)
        {
            int indexEmpleado = LookForEmpleado(nombre);
            if (LookForEmpleado(nombre) >= 0)
            {
                ListaPrincipal.RemoveAt(indexEmpleado);
                MessageBox.Show($"Empleado {nombre} a sido eliminado");
            }
            else { MessageBox.Show("Empleado no encontrado"); }
        }

        public void SortEmpleados()
        {
            bool cont = true;
            for (int i = 0; i < ListaPrincipal.Count(); i++)
            {
                for (int j = 0; j < ListaPrincipal.Count() && cont; j++)
                {
                    if (String.Compare(ListaPrincipal[j].Nombre, ListaPrincipal[i].Nombre) > 0)
                    {
                        ListaPrincipal = MoveEmpleado(ListaPrincipal, i, j);
                        cont = false;
                    }
                }
                cont = true;
            }
        }

        public void SortEmpleadosVentas()
        {
            bool cont = true;
            for (int i = 0; i < ListaPrincipal.Count(); i++)
            {
                for (int j = 0; j < ListaPrincipal.Count() && cont; j++)
                {
                    if (ListaPrincipal[j].TotalVentas > ListaPrincipal[i].TotalVentas)
                    {
                        ListaPrincipal = MoveEmpleado(ListaPrincipal, i, j);
                        cont = false;
                    }
                }
                cont = true;
            }
        }

        public string MostSells()
        {
            int indiceMayor = 0;
            for (int i = 1; i < ListaPrincipal.Count(); i++)
            {
                if (ListaPrincipal[i].TotalVentas > ListaPrincipal[indiceMayor].TotalVentas)
                {
                    indiceMayor = i;
                }
            }
            return VerEmpleados(ListaPrincipal[indiceMayor].Nombre);
        }

        public int LookForEmpleado(string nombre)
        {
            int i;
            for(i = 0; i < ListaPrincipal.Count(); i++)
            {
                if (String.Compare(ListaPrincipal[i].Nombre, nombre) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public string LookForName(int indice)
        {
            if (indice >= ListaPrincipal.Count())
            {
                return null;
            }
            else { return ListaPrincipal[indice].Nombre; }
        }

        private List<Empleado> MoveEmpleado(List<Empleado> lista, int i, int j)
        {
            Empleado empleadoTemp = new Empleado();
            empleadoTemp = lista[j];
            lista[j] = lista[i];
            lista[i] = empleadoTemp;
            return lista;
        }
    }
}
