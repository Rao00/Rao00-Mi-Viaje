<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrestacionesNombreCambiado.aspx.cs" Inherits="GesPresta.PrestacionesNombreCambiado" %>

<%@ Register src="Cabecera.ascx" tagname="Cabecera" tagprefix="uc1" %>

<%@ Register src="prestacionesBuscar.ascx" tagname="prestacionesBuscar" tagprefix="uc2" %>

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
        <main style="display:flex;">
            <section style="width:80%;">
                <table style="margin:auto; margin-top:5px;">
                    <tr>
                        <td class="columnaIzqEmpleados">Código Prestación</td>
                        <td><asp:textbox runat="server" Width="259px" ID="txtCodPres"></asp:textbox>
                            <asp:Button ID="btnVerPrestaciones" runat="server" CausesValidation="False" OnClick="btnVerPrestaciones_Click" Text="Ver prestaciones" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodPres" ErrorMessage="El codigo de la prestación és obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="columnaIzqEmpleados">Descripción</td>
                        <td><asp:textbox runat="server" Width="259px" ID="txtDescripción"></asp:textbox></td>
                    </tr>
                    <tr>
                        <td class="columnaIzqEmpleados">Importe fijo</td>
                        <td><asp:textbox runat="server" Width="259px" ID="txtImporte"></asp:textbox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtImporte" ErrorMessage="El importe fijo és obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtImporte" ErrorMessage="El importe ha de estar entre 0€ y 500€" ForeColor="Red" Type="Double"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="columnaIzqEmpleados">Porcentaje de la Prestación</td>
                        <td><asp:textbox runat="server" Width="259px" ID="txtPorcentaje"></asp:textbox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPorcentaje" ErrorMessage="El porcentaje de la prestación és obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtPorcentaje" ErrorMessage="El porcentaje debe de estar entre 0% y 15%" ForeColor="Red" Type="Double"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="columnaIzqEmpleados">Tipo de Prestación</td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlPrestacion">
                                <asp:ListItem Value="Dentaria">Dentaria</asp:ListItem>
                                <asp:ListItem Value="Familiar">Familiar</asp:ListItem>
                                <asp:ListItem Value="Ocular" Selected="True">Ocular</asp:ListItem>
                                <asp:ListItem Value="Otras">Otras</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </section>
            <section style="width:15%;">
                <uc2:prestacionesBuscar ID="prestacionesBuscar1" runat="server" Visible="False" />
                <asp:Button ID="btnSeleccionar" runat="server" CausesValidation="False" Text="Seleccionar" Visible="False" />
            </section>
        </main>
        <p>
        <asp:Button class="pieDePagina" runat="server" ID="btnEnviar" Text="Enviar" PostBackUrl="~/PrestacionesRespuesta.aspx" />
        </p>
    </form>
</body>
</html>
