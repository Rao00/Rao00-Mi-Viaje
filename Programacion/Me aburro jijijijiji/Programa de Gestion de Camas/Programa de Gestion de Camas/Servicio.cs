﻿using System;
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
        private int numCamasMax;
        private string planta;

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

        public int NumCamasMax
        {
            get { return numCamasMax; }
            set { numCamasMax = value; }
        }

        public string Planta
        {
            get { return planta; }
            set { planta = value; }
        }
    }
}
