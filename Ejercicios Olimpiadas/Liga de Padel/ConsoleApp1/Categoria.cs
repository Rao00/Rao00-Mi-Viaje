using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Categoria
    {
        List<string> ListaPartidos = new List<string>();
        string NombreCategoria;
        
        public string Name
        {
            get { return NombreCategoria; }
            set { NombreCategoria = value; }
        }

        public List<string> List
        {
            get { return ListaPartidos; }
            set { ListaPartidos = value; }
        }

        public void AddPartido(string nombrePareja1)
        {
            ListaPartidos.Add(nombrePareja1);
        }
    }
}
