<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cabecera.ascx.cs" Inherits="GesPresta.Cabecera1" %>

    <link rel="stylesheet" href="Cabeceras.css" />

<div style="text-align:center">
    <asp:LinkButton ID="lbtnInicio" runat="server" style="margin:20px;" PostBackUrl="~/Default.aspx">Inicio</asp:LinkButton>
    <asp:LinkButton ID="lbtnEmpleados" runat="server" style="margin:20px;" PostBackUrl="~/Empleados.aspx">Empleados</asp:LinkButton>
    <asp:LinkButton ID="lbtnPrestacion" runat="server" style="margin:20px;" PostBackUrl="~/Prestaciones.aspx">Prestación</asp:LinkButton>
</div>
<div>
    <h1 class="titulo" style="margin-bottom:0px;">ACME INNOVACIÓN, S. FIG.</h1>
    <b><p class="subtitlo">Gestión de Prestaciones Sociales</p></b>
</div>
<hr />

