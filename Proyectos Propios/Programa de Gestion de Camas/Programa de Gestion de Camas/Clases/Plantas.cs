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
        private int maxCamas;

        public string Nombre 
        {  
            get { return nombrePlanta; } 
            set { nombrePlanta = value; }
        }

        public int MaxCamas
        {
            get { return maxCamas; }
            set { maxCamas = value; }
        }

        public int TotalCamas
        {
            get { return Suma(); }
        }

        public List<Servicio> List
        {
            get { return listaServicios; }
        }

        public Plantas(string Nombre)
        {
            nombrePlanta = Nombre;
            maxCamas = 0;
            listaServicios = new List<Servicio>();
        }

        private int Suma()
        {
            int total = 0;
            foreach(Servicio servicio in listaServicios)
            {
                total += servicio.NumCamasActuales;
            }
            return total;
        }

        public void Add(Servicio servicio)
        {
            listaServicios.Add(servicio);
        }
    }
}
