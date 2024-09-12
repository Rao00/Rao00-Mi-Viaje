using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Fecha
    {
        private int dia;
        private int mes;
        private int anyo;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Anyo
        {
            get { return anyo; }
            set { anyo = value; }
        }

        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            dia = 1;
            mes = 1;
            anyo = 1;
        }

        /// <summary>
        /// Metodo encargado de comporbar si una fecha es valida o.
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="mes"></param>
        /// <param name="anyo"></param>
        /// <returns>Devuelve "true" si la fecha es valida y "false" si la fecha es incorrecta</returns>
        public bool ValidarFecha(int dia, int mes, int anyo)
        {
            bool valida = true;

            if (dia <= 0 || dia > 31 || mes <= 0 || mes > 12 || anyo <= 0)
            {
                valida = false;
            }

            if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30)
            {
                valida = false;
            }

            if (Bisiesto(anyo) == true)
            {
                if (mes == 2 && dia > 29)
                {
                    valida = false;
                }
            }
            else
            {
                if (mes == 2 && dia > 28)
                {
                    valida = false;
                }
            }

            return valida;
        }


        /// <summary>
        /// Metodo encargado de comprobar si un año es bisiesto o no.
        /// </summary>
        /// <param name="anyo"></param>
        /// <returns>Devolvera "true" si el año es bisiesto y "false" si no lo es</returns>
        public bool Bisiesto(int anyo)
        {
            bool bisiesto = true;
            if (anyo % 4 == 0)
            {
                if (anyo % 100 == 0 && anyo % 400 != 0)
                {
                    bisiesto = false;
                }
            }
            return bisiesto;
        }


        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se  sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns> public override string
        override
        public string ToString()
        {
            return dia + "/" + mes + "/" + anyo;
        }
    }
}
