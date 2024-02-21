using Fechas;
using System;


/* Anotación:
 * Devido ha que entre las diferentes modificaciones que he realizado al refactorizar el código se cuentra un cambio
 * entre los constructores de la clase Fecha ya que e obtado por eliminar uno de ellos y sustituir su cometido por
 * metodos de la clase y uno de los fragmentos de codigo dentro de esta clase Program a pasado a carecer de sentido
 * ya que se encargaba de probar las asignaciones incorrectas de los datos al instanciar el objeto Fecha pero ya no es 
 * necesario al solo aver una forma de hacerlo.
 */
namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fecha correcta, año bisiesto
            Fecha fecha1 = new Fecha();
            int dia = 4;
            int mes = 12;
            int anyo = 2014;

            if (fecha1.ValidarFecha(dia, mes, anyo))
            {
                fecha1.Dia = dia;
                fecha1.Mes = mes;
                fecha1.Anyo = anyo;
                Console.WriteLine("Fecha 1: " + fecha1.ToString());
            }
            else
                Console.WriteLine("Fecha 1 incorrecta");

            if (fecha1.EsBisiesto(anyo))
                Console.WriteLine("El año " + anyo + " es bisiesto");
            else
                Console.WriteLine("El año " + anyo + " no es bisiesto");


            //Fecha correcta, año no bisiesto
            Fecha fecha2 = new Fecha();
            int dia = 4;
            int mes = 10;
            int anyo = 2013;

            if (fecha2.ValidarFecha(dia, mes, anyo))
            {
                fecha2.Dia = dia;
                fecha2.Mes = mes;
                fecha2.Anyo = anyo;
                Console.WriteLine("Fecha 2: " + fecha2.ToString());
            }
            else
                Console.WriteLine("Fecha 2 incorrecta");

            if (fecha2.EsBisiesto(anyo))
                Console.WriteLine("El año " + anyo + " es bisiesto");
            else
                Console.WriteLine("El año " + anyo + " no es bisiesto");


            //Fecha con valores incorrectos
            Fecha fecha3 = new Fecha();
            int dia = 4;
            int mes = 13;
            int anyo = -4;

            if (fecha3.ValidarFecha(dia, mes, anyo))
            {
                fecha3.Dia = dia;
                fecha3.Mes = mes;
                fecha3.Anyo = anyo;
                Console.WriteLine("Fecha 3: " + fecha1.ToString());
            }
            else
                Console.WriteLine("Fecha 3 incorrecta");
        }
    }
}
