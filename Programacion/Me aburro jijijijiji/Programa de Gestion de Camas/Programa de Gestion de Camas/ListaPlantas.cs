using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_Gestion_de_Camas
{
    class ListaPlantas
    {
        List<Servicio> listaServicios;

        private string nombrePlanta;

        public string Nombre 
        {  
            get { return nombrePlanta; } 
            set { nombrePlanta = value; }
        }

        public ListaPlantas()
        {
            listaServicios = new List<Servicio>();
        }
    }
}
