using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesPresta
{
    public partial class EmpleadosNombreCambiado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("Evento", "Entrando en Page_Load");
            txtCodEmp.Focus();
            if (Trace.IsEnabled)
            {
                txtNIF.Text = "11111111X";
                Trace.Warn("Asignación", "Cambiado el valor de txtNIF a: " + txtNIF.Text);
            }
            Trace.Write("Evento", "Saliendo de Page_Load");
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblValores.Visible = true;
            lblValores.Text = "VALORES DEL FORMULARIO" +
                                "<br/> Código Empleado: " + txtCodEmp.Text +
                                "<br/> NIF: " + txtNIF.Text +
                                "<br/> Apellidos y Nombre: " + txtNomEmp.Text +
                                "<br/> Dirección: " + txtDireccion.Text +
                                "<br/> Ciudad: " + txtCiudad.Text +
                                "<br/> Teléfonos: " + txtTelf.Text +
                                "<br/> Fecha de Nacimiento: " + txtFechaNacimiento.Text +
                                "<br/> Fecha de Incorporación: " + txtFechaIngreso.Text +
                                "<br/> Sexo: " + rblSexo.SelectedItem.Value + "<br/> Departamento: " + ddlDepEmp.Text + ";";
        }
    }
}