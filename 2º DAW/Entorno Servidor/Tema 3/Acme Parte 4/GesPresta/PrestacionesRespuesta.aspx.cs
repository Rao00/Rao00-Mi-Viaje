using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesPresta
{
    public partial class PrestacionesRespuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cadena + "Código: " + Request.Form["txtCodPres"] + "<br/>";
            cadena = cadena + "Descripción: " + Request.Form["txtDescripción"] + "<br/>";
            cadena = cadena + "Importe: " + Request.Form["txtImporte"] + "<br/>";
            cadena = cadena + "Porcentaje: " + Request.Form["txtPorcentaje"] + "<br/>";
            cadena = cadena + "Tipo de Prestación: " + Request.Form["ddlPrestacion"] + "<br/>";
            lblValores.Text = cadena;
            lblValores.Visible = true;
        }
    }
}