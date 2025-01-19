<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpleadosNombreCambiado.aspx.cs" Inherits="GesPresta.EmpleadosNombreCambiado" Trace="false"%>

<%@ Register src="Cabecera.ascx" tagname="Cabecera" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="stylesheet.css" />

<title></title>

</head>
<body>
    <form id="form1" runat="server">
        <uc1:Cabecera ID="Cabecera" runat="server" />
        <h2 class="tituloseccion">Datos Empleados</h2>
        <div>
            <table style="margin:auto; margin-top:5px;">
                <tr>
                    <td class="columnaIzqEmpleados">Código Empleado</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtCodEmp" RequiredFieldValidator="true"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqdCodEmp" runat="server" ControlToValidate="txtCodEmp" ErrorMessage="El codigo de empleado es obligatorio" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regCodEmpleado" runat="server" ControlToValidate="txtCodEmp" ErrorMessage="El codigo de empleado no es correcto" ForeColor="Red" ValidationExpression="\w\d{5}">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">NIF</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtNIF"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqdNIF" runat="server" ControlToValidate="txtNIF" ErrorMessage="El NIF es obligatorio" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regNIF" runat="server" ControlToValidate="txtNIF" ErrorMessage="El NIF no es correcto" ForeColor="Red" ValidationExpression="\d{8}-\w">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Apellidos y Nombre</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtNomEmp"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqdNomEmp" runat="server" ControlToValidate="txtNomEmp" ErrorMessage="Los apellidos y el nombre son obligatorios" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
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
                    <td><asp:textbox runat="server" Width="259px" ID="txtTelf"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqdTelf" runat="server" ControlToValidate="txtTelf" ErrorMessage="El télefono es obligatorio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Fecha de Nacimiento</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtFechaNacimiento"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqdFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="La fecha de nacimiento es obligatoria" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="La fecha de nacimiento no es correcta" ForeColor="Red" ValidationExpression="\d\d/\d\d/\d{4}">*</asp:RegularExpressionValidator>
                        <asp:CompareValidator ID="cmpFechaNacimiento" runat="server" ControlToCompare="txtFechaIngreso" ControlToValidate="txtFechaNacimiento" ErrorMessage="La Fecha de Ingreso del Empleado debe ser mayor que la Fecha de Nacimiento" ForeColor="Red" Operator="LessThan" Type="Date">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Fecha de Ingreso</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtFechaIngreso"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqdFechaIngreso" runat="server" ControlToValidate="txtFechaIngreso" ErrorMessage="La fecha de ingreso es obligatoria" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regFechaIngreso" runat="server" ControlToValidate="txtFechaIngreso" ErrorMessage="La fecha de ingreso no es correcta" ForeColor="Red" ValidationExpression="\d\d/\d\d/\d{4}">*</asp:RegularExpressionValidator>
                    </td>
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
            </table>
        </div>
        <asp:Button class="pieDePagina" runat="server" ID="btnEnviar" Text="Enviar" OnClick="btnEnviar_Click" />
        <asp:Label ID="lblValores" runat="server" BackColor="#66FFFF" Visible="False" Width="60%"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
