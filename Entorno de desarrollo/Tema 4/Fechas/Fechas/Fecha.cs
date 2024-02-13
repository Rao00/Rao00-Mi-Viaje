using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Fecha
    {
        public int d;
        public int m;
        public int a;

        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            d = 1;
            m = 1;
            a = 1;
        }

        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// </summary>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// <param name="dia">Dia</param>
        /// <param name="bi">Indica si es bisiesto</param>
        public Fecha(int mes, int anyo, int dia, bool bi)
        {
            if (anyo >= 1 && anyo <= 2500)
            {
                this.a = anyo;
            }
            else
            {
                this.a = 1;
            }

            bool bisiesto;

            if ((a % 400 == 0) || ((a % 4 == 0) && (a % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;

            if (mes >= 1 && mes <= 12)
                this.m = mes;
            else
                this.m = 1;

            int diasMes = 0;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diasMes = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diasMes = 30;
                    break;
                case 2: // verificación de año bisiesto
                    if (bisiesto)
                        diasMes = 29;
                    else
                        diasMes = 28;
                    break;
            }

            if (dia >= 1 && dia <= diasMes)
                this.d = dia;
            else
                this.d = 1;
        }

        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((a % 400 == 0) || ((a % 4 == 0) && (a % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
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
            return d + "/" + m + "/" + a;
        }
    }
}
