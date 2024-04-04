using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_Gestion_de_Camas
{
    class Servicio
    {
        private string nombre;
        private int mediaAnual;
        private int numCamasActuales;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int MediaAnual
        {
            get { return mediaAnual; }
            set { mediaAnual = value; }
        }


        public int NumCamasActuales
        {
            get { return numCamasActuales; }
            set { numCamasActuales = value; }
        }
    }
}
