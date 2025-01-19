using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesPresta
{
    public partial class EmpleadosCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodEmp.Focus();
        }

        protected void ComprobarCalendarios()
        {
            DateTime dateNacimiento = cFechaNacimiento.SelectedDate;
            DateTime dateIngreso = cFechaIngreso.SelectedDate;

            if (dateNacimiento > dateIngreso && txtFechaNacimiento.Text != "" && txtFechaIngreso.Text != "")
                lblErrorNacimientoMayorIngreso.Visible = true;
            else
                lblErrorNacimientoMayorIngreso.Visible = false;

            if (dateNacimiento > DateTime.Now)
                lblErrorNacimientoMayorActual.Visible = true;
            else
                lblErrorNacimientoMayorActual.Visible= false;

            if (dateIngreso > DateTime.Now)
                lblErrorIngresoMayorActual.Visible = true;
            else
                lblErrorIngresoMayorActual.Visible = false;

            DateTime fechaMin = new DateTime(1, 1, 1);
            TimeSpan difDates = DateTime.Now - dateIngreso;

            if (dateNacimiento < fechaMin)
                txtFechaNacimiento.Text = dateNacimiento.ToShortDateString();
            if (dateIngreso < fechaMin && difDates.Days < 0)
            {
                txtFechaIngreso.Text = dateIngreso.ToShortDateString();
                return;
            }
                    
            if (dateNacimiento > fechaMin)
            {
                txtFechaNacimiento.Text = dateNacimiento.ToShortDateString();
            }
            if (dateIngreso > fechaMin)
            {
                txtFechaIngreso.Text = dateIngreso.ToShortDateString();

                try
                {
                    txtAnos.Text = ((fechaMin + difDates).Year - 1).ToString();
                    txtMeses.Text = ((fechaMin + difDates).Month - 1).ToString();
                    txtDias.Text = ((fechaMin + difDates).Day - 1).ToString();
                }
                catch { }
            }
        }

        protected void ComprobarCalendarios(object sender, EventArgs e)
        {
            ComprobarCalendarios();
        }

        protected void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaMin = new DateTime(1, 1, 1);
                DateTime fechaTxt = Convert.ToDateTime(txtFechaNacimiento.Text);
                if (fechaTxt > fechaMin)
                {
                    cFechaNacimiento.SelectedDate = fechaTxt;
                    cFechaNacimiento.VisibleDate = fechaTxt;
                }
                else
                {
                    cFechaNacimiento.SelectedDate = fechaMin;
                    cFechaNacimiento.VisibleDate = fechaMin;
                }

                ComprobarCalendarios();
            }
            catch { txtFechaNacimiento.Text = cFechaNacimiento.SelectedDate.ToShortDateString(); }
        }

        protected void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaMin = new DateTime(1, 1, 1);
                DateTime fechaTxt = Convert.ToDateTime(txtFechaIngreso.Text);
                if (fechaTxt > fechaMin)
                {
                    cFechaIngreso.SelectedDate = fechaTxt;
                    cFechaIngreso.VisibleDate = fechaTxt;
                }
                else
                {
                    cFechaIngreso.SelectedDate = fechaMin;
                    cFechaIngreso.VisibleDate = fechaTxt;
                }
                    
                ComprobarCalendarios();
            }
            catch { txtFechaIngreso.Text = cFechaIngreso.SelectedDate.ToShortDateString(); }
        }
    }
}