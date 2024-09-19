<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestaciones.aspx.cs" Inherits="GesPresta.Prestaciones" %>

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
        <uc1:Cabecera ID="Cabecera1" runat="server" />
        <div>
        <h2 class="tituloseccion">Datos Prestaciones</h2>
        </div>
            <table style="margin:auto; margin-top:5px;">
                <tr>
                    <td class="columnaIzqEmpleados">Código Prestación</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtCodPres"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Ciudad</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtDescripción"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Teléfonos</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtImporte"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Fecha de Nacimiento</td>
                    <td><asp:textbox runat="server" Width="259px" ID="txtPorcentaje"></asp:textbox></td>
                </tr>
                <tr>
                    <td class="columnaIzqEmpleados">Tipo de Prestación</td>
                    <td class="auto-style2">
                        <asp:DropDownList runat="server" ID="ddlPrestacion">
                            <asp:ListItem Value="Dentaria">Dentaria</asp:ListItem>
                            <asp:ListItem Value="Familiar">Familiar</asp:ListItem>
                            <asp:ListItem Value="Ocular" Selected="True">Ocular</asp:ListItem>
                            <asp:ListItem Value="Otras">Otras</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        <p>
        <asp:Button class="pieDePagina" runat="server" ID="btnEnviar" Text="Enviar" />
        </p>
    </form>
</body>
</html>
