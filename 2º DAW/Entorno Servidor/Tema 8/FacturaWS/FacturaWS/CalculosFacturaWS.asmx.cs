using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FacturaWS
{
    /// <summary>
    /// Descripción breve de CalculosFacturaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/",
 Description = "Servicio Web para la obtención de cálculos en líneas de factura.")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculosFacturaWS : System.Web.Services.WebService
    {
        [Serializable()]
        public class Calculos
        {
            public Calculos() { }
            public string Bruto;
            public string Descuento;
            public string BaseImponible;
            public string Iva;
            public string Total;
        }
        [WebMethod]
        public Calculos CalculosLineaFactura(double cantidad, double precio,
         double tipo_descuento, double tipo_iva)
        {
            Calculos resultado = new Calculos();
            double w_bruto = cantidad * precio;
            double w_descuento = cantidad * precio * tipo_descuento / 100;
            double w_baseImponible = w_bruto - w_descuento;
            double w_iva = w_baseImponible * tipo_iva / 100;
            double w_total = w_baseImponible + w_iva;
            resultado.Bruto = String.Format("{0:c}", w_bruto);
            resultado.Descuento = String.Format("{0:c}", w_descuento);
            resultado.BaseImponible = String.Format("{0:c}", w_baseImponible);
            resultado.Iva = String.Format("{0:c}", w_iva);
            resultado.Total = String.Format("{0:c}", w_total);

            return resultado;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
    }
}
