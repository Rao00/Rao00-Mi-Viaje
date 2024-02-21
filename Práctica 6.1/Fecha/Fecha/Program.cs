using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Anotación:
 * Devido ha que entre las diferentes modificaciones que he realizado al refactorizar el código se cuentra un cambio
 * entre los constructores de la clase Fecha ya que e obtado por eliminar uno de ellos y sustituir su cometido por
 * metodos de la clase y uno de los fragmentos de codigo dentro de esta clase Program a pasado a carecer de sentido
 * ya que se encargaba de probar las asignaciones incorrectas de los datos al instanciar el objeto Fecha pero ya no es 
 * necesario al solo aver una forma de hacerlo.
 */

namespace Fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fecha correcta, año bisiesto
            Fecha fecha1 = new Fecha();
            int dia1 = 4;
            int mes1 = 12;
            int anyo1 = 2004;

            if (fecha1.ValidarFecha(dia1, mes1, anyo1))
            {
                fecha1.Dia = dia1;
                fecha1.Mes = mes1;
                fecha1.Anyo = anyo1;
                Console.WriteLine("Fecha 1: " + fecha1.ToString());
            }
            else
                Console.WriteLine("Fecha 1 incorrecta");

            if (fecha1.EsBisiesto(anyo1))
                Console.WriteLine("El año " + anyo1 + " es bisiesto");
            else
                Console.WriteLine("El año " + anyo1 + " no es bisiesto");


            //Fecha correcta, año no bisiesto
            Fecha fecha2 = new Fecha();
            int dia2 = 4;
            int mes2 = 10;
            int anyo2 = 2013;

            if (fecha2.ValidarFecha(dia2, mes2, anyo2))
            {
                fecha2.Dia = dia2;
                fecha2.Mes = mes2;
                fecha2.Anyo = anyo2;
                Console.WriteLine("Fecha 2: " + fecha2.ToString());
            }
            else
                Console.WriteLine("Fecha 2 incorrecta");

            if (fecha2.EsBisiesto(anyo2))
                Console.WriteLine("El año " + anyo2 + " es bisiesto");
            else
                Console.WriteLine("El año " + anyo2 + " no es bisiesto");


            //Fecha con valores incorrectos
            Fecha fecha3 = new Fecha();
            int dia3 = 4;
            int mes3 = 13;
            int anyo3 = -4;

            if (fecha3.ValidarFecha(dia3, mes3, anyo3))
            {
                fecha3.Dia = dia3;
                fecha3.Mes = mes3;
                fecha3.Anyo = anyo3;
                Console.WriteLine("Fecha 3: " + fecha1.ToString());
            }
            else
                Console.WriteLine("Fecha 3 incorrecta");


            Console.ReadKey();
        }
    }
}
