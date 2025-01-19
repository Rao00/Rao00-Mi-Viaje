<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpleadosCalendar.aspx.cs" Inherits="GesPresta.EmpleadosCalendar" %>

<%@ Register src="Cabecera.ascx" tagname="Cabecera" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="stylesheet.css" />

<title></title>

    <style type="text/css">
        .resultadoDeTiempo {
            width: 190px;
            text-align: left;
            padding-right: 20px;
            vertical-align: top;
            margin-left:10px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <uc1:Cabecera ID="Cabecera" runat="server" />
        <h2 class="tituloseccion">Datos Empleados</h2>
        <div>
            <table style="margin:auto; margin-top:5px;">
                <tr>
                    <td class="columnaIzqEmpleados">Código Empleado</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtCodEmp"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">NIF</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtNIF"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Apellidos y Nombre</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtNomEmp"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Direccion</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtDireccion"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Ciudad</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtCiudad"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Teléfonos</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtTelf"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Sexo</td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="rblSexo" RepeatDirection="Horizontal" >
                            <asp:ListItem Value="H" Selected="True">Hombre</asp:ListItem>
                            <asp:ListItem Value="M">Mujer</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Departamento</td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlDepEmp">
                            <asp:ListItem Value="Investigación" Selected="True">Investigación</asp:ListItem>
                            <asp:ListItem Value="Desarrollo">Desarrollo</asp:ListItem>
                            <asp:ListItem Value="Innovación">Innovación</asp:ListItem>
                            <asp:ListItem Value="Administración">Administración</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">
                        Fecha de Nacimiento
                        <asp:textbox runat="server" Width="123px" ID="txtFechaNacimiento" OnTextChanged="txtFechaNacimiento_TextChanged"></asp:textbox>
                        <br />
                        <asp:Label runat="server" ID="lblErrorNacimientoMayorActual" ForeColor="#FF3300" Visible="False">La fecha de nacimiento no puede ser mayor a la actual</asp:Label>
                    </td>
                    <td>
                        <asp:Calendar runat="server" ID="cFechaNacimiento" Width="264px" FirstDayOfWeek="Monday" OnSelectionChanged="ComprobarCalendarios" />
                    </td>
                    <td class="columnaIzqEmpleados">
                        Fecha de Ingreso
                        <asp:textbox runat="server" Width="123px" ID="txtFechaIngreso" OnTextChanged="txtFechaIngreso_TextChanged"></asp:textbox>
                        <br />
                        <asp:Label runat="server" ID="lblErrorIngresoMayorActual" ForeColor="#FF3300" Visible="False">La fecha de ingreso no puede ser menor a la actual</asp:Label> <br /> <br />
                        <asp:Label runat="server" ID="lblErrorNacimientoMayorIngreso" ForeColor="#FF3300" Visible="False">La fecha de ingreso no puede ser menor a la fecha de nacimiento</asp:Label>
                    </td>
                    <td>
                        <asp:Calendar runat="server" ID="cFechaIngreso" Width="264px" OnSelectionChanged="ComprobarCalendarios" />
                    </td>
                    <td class="resultadoDeTiempo">
                        <p>Antiguedad</p>
                        <div class="resultadoDeTiempo">
                            <asp:TextBox runat="server" ID="txtAnos" Width="50px" />
                            &nbsp Años
                        </div>
                        <div class="resultadoDeTiempo">
                            <asp:TextBox runat="server" ID="txtMeses" Width="50px" />
                            &nbsp Meses
                        </div>
                        <div class="resultadoDeTiempo">
                            <asp:TextBox runat="server" ID="txtDias" Width="50px" />
                            &nbsp Dias
                        </div>
                        <br />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button class="pieDePagina" runat="server" ID="btnEnviar" Text="Enviar" />
    </form>
</body>
</html>
