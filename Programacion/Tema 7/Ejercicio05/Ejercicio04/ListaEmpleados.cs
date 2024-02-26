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
            if (ListaPrincipal.Count() > 0)
            {
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
                    else
                    {
                        salida = "El empleado no existe";
                    }
                    if (!bucle) { init_bucle = false; }
                    i++;
                }
            }
            return salida;
        }

        public int Count()
        {
            return ListaPrincipal.Count();
        }

        public bool AñadirVentas(string nombre, double venta)
        {
            bool encotrado = false;
            for (int i = 0; i < ListaPrincipal.Count(); i++)
            {
                if (ListaPrincipal[i].Nombre == nombre)
                {
                    ListaPrincipal[i].AddVenta(venta);
                    encotrado = true;
                }
            }
            return encotrado;
        }

        public bool? DeleteVentas(string nombre = null)
        {
            bool? eliminado = false;
            try
            {
                if(nombre == null)
                {
                    foreach (Empleado empleado in ListaPrincipal)
                    {
                        if (empleado.TotalVentas > 0) { eliminado = true; }
                    }
                }
                else
                {
                    int indice = LookForEmpleado(nombre);
                    if (ListaPrincipal[indice].TotalVentas > 0)
                    {
                        ListaPrincipal[indice].RemoveVenta();
                        eliminado = true;
                    }
                    else { eliminado = null; }
                }
                return eliminado;
            }
            catch (Exception) { return null; }
        }

        public bool DeleteEmpleado(string nombre)
        {
            bool eliminado;
            int indexEmpleado = LookForEmpleado(nombre);
            if (LookForEmpleado(nombre) >= 0)
            {
                ListaPrincipal.RemoveAt(indexEmpleado);
                eliminado = true;
            }
            else { eliminado = false; }
            return eliminado;
        }

        public void SortEmpleados()
        {
            bool cont = true;
            for (int i = 0; i < ListaPrincipal.Count() - 1; i++)
            {
                for (int j = i + 1; j < ListaPrincipal.Count() && cont; j++)
                {
                    if (String.Compare(ListaPrincipal[j].Nombre, ListaPrincipal[i].Nombre) < 0)
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
                    if (ListaPrincipal[j].TotalVentas < ListaPrincipal[i].TotalVentas)
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
            string salida = string.Empty;
            bool añadir = true;
            bool algunaVenta = false;
            if (ListaPrincipal.Count() > 0)
            {
                int i = 0;
                while (i < ListaPrincipal.Count())
                {
                    int j = 0;
                    añadir = true;
                    if (ListaPrincipal[i].TotalVentas > 0)
                    {
                        while (j < ListaPrincipal.Count())
                        {
                            if (ListaPrincipal[i].TotalVentas < ListaPrincipal[j].TotalVentas)
                            {
                                j = ListaPrincipal.Count();
                                añadir = false;
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }
                    else { algunaVenta = false; }
                    if (j == ListaPrincipal.Count() && añadir)
                    {
                        salida += VerEmpleados(ListaPrincipal[i].Nombre);
                    }
                    i++;
                }
                if (salida == string.Empty && !algunaVenta)
                {
                    salida = "Ningun empleado ha realizado ventas";
                }
            }
            else { salida = "No existen empleados"; }
            return salida;
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