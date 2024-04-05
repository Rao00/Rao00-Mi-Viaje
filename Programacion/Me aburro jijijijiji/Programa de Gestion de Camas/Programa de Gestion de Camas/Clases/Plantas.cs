using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Programa_de_Gestion_de_Camas
{
    class Plantas
    {
        List<Servicio> listaServicios;

        private string nombrePlanta;

        public string Nombre 
        {  
            get { return nombrePlanta; } 
            set { nombrePlanta = value; }
        }

        public List<Servicio> List
        {
            get { return listaServicios; }
        }

        public Plantas(string Nombre)
        {
            nombrePlanta = Nombre;
            listaServicios = new List<Servicio>();
        }

        public void Add(Servicio servicio)
        {
            listaServicios.Add(servicio);
        }
    }
}
