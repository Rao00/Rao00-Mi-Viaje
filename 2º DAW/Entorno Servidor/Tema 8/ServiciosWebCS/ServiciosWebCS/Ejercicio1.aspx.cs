using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiciosWebCS.ServiceReference1;

namespace ServiciosWebCS
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnObtenerInformacion_Click(object sender, EventArgs e)
        {
            // Consumo de Servicio Web wstitulosuni de la Universidad de Alicante
            // disponible en: https://si.ua.es/es/servicios-web/serviciosweb/publicos/publicos.html
            try
            {
                // Creación de la instancia y llamada al método
                pub_gestdocenteSoapClient ws = new pub_gestdocenteSoapClient();
                string StrCursoAcademico = txtCurso.Text;
                var resultado = ws.wstitulosuni("C", StrCursoAcademico);
                ws.Close();

                lblResultado.Text = "<b>Resultados obtenidos de la respuesta: </b>" + resultado;

                // Incluye los datos en tabla
                string StrTabla = "<div style='display:table; width:70%; margin:auto'>";
                StrTabla += "<div style='display:table-row;height:25px;'>";
                StrTabla += "<div style='display:table-cell;'><b>CÓDIGO</b></div>";
                StrTabla += "<div style='display:table-cell; width:50%;'><b>NOMBRE</b></div>";
                StrTabla += "<div style='display:table-cell;'><b>TIPO</b></div>";
                StrTabla += "<div style='display:table-cell;'><b>ÁREA</b></div>";
                StrTabla += "<div style='display:table-cell;'><b>ENLACE</b></div>";
                StrTabla += "</div>";
                foreach (var item in resultado)
                {
                    StrTabla += "<div style='display:table-row; height:20px;'>";
                    StrTabla += "<div style='display:table-cell;'>" + item.codigo + "</div>";
                    StrTabla += "<div style='display:table-cell;'>" + item.nombre + "</div>";
                    if (item.tipo == "0")
                        StrTabla += "<div style='display:table-cell;'>Grado</div>";
                    if (item.tipo == "1")
                        StrTabla += "<div style='display: table-cell;'>Master</div>";
                    StrTabla += "<div style='display:table-cell;'>" + item.area + "</div>";
                    StrTabla += "<div style='display:table-cell;'>" +
                    "<a href='" + item.url + "'>Más información</a></div>";
                    StrTabla += "</div>";
                }
                StrTabla += "</div>";
                lblResultado.Text = StrTabla;
                // Incluye los datos de la respuesta en un GridView
                GridView1.AutoGenerateColumns = true;
                GridView1.DataSource = resultado;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                string StrError = "<p>Se han producido errores durante el registro</p>";
                StrError = StrError + "<div>Código: " + ex.HResult + "</div>";
                StrError = StrError + "<div>Descripción: " + ex.Message + "</div>";
                lblResultado.Text = "Información de " + txtCurso.Text.ToUpper() +
                " no disponible <br />" + StrError;
                GridView1.Dispose();
                GridView1.DataBind();
            }
        }
    }
}