using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio04
{
    internal class Empleado
    {
        private string nombre;
        private int edad;
        private int totalVentas;
        private List<double> listaVentas;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Edad
        { 
            get 
            { 
                return edad; 
            } 
            set 
            {
                try
                {
                    if (value >= 0)
                    {
                        edad = value;
                    }
                    else { throw new IndexOutOfRangeException(); }
                }
                catch(IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException("Parameter must be more than 0");
                }
                catch (FormatException)
                {
                    throw new IndexOutOfRangeException("Parameter must be an integer");
                }
            } 
        }
        public int TotalVentas
        {
            get { return totalVentas; }
            set
            {
                try
                {
                    if (value >= 0)
                    {
                        totalVentas = value;
                    }
                    else { throw new IndexOutOfRangeException(); }
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException("Parameter must be more than 0");
                }
                catch (FormatException)
                {
                    throw new IndexOutOfRangeException("Parameter must be an integer");
                }
            }
        }
        public List<double> ListaVentas
        {
            get
            {
                return listaVentas;
            }
        }

        public void AddVenta(double valorVenta)
        {
            listaVentas.Add(valorVenta);
        }

        public Empleado()
        {
            nombre = "";
            edad = 0;
            totalVentas = 0;
            listaVentas = new List<double>();
        }
    }
}
