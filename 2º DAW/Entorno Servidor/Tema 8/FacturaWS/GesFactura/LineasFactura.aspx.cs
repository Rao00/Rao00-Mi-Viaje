using GesFactura.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesFactura
{
    public partial class LineasFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            CalculosFacturaWSSoapClient wsCalculos = new CalculosFacturaWSSoapClient();
            double w_cantidad = Convert.ToDouble(txtCantidad.Text);
            double w_precio = Convert.ToDouble(txtPrecio.Text);
            double w_descuento = Convert.ToDouble(txtDescuento.Text);
            double w_tipoIVA = Convert.ToDouble(txtTipoIVA.Text);
            // Invocación del Web Service que devuelve un objeto de tipo Calculos
            var resul = wsCalculos.CalculosLineaFactura(w_cantidad, w_precio,
            w_descuento, w_tipoIVA);
            wsCalculos.Close();
            lblBruto.Text = resul.Bruto;
            lblDescuento.Text = resul.Descuento;
            lblBaseImponible.Text = resul.BaseImponible;
            lblIva.Text = resul.Iva;
            lblTotal.Text = resul.Total;
        }
    }
}