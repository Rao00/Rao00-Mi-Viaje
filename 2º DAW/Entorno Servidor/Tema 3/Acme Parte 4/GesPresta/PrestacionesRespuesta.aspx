<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrestacionesRespuesta.aspx.cs" Inherits="GesPresta.PrestacionesRespuesta" %>

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
            <asp:Label ID="lblValores" runat="server" BackColor="#C0FFFF" Width="70%"></asp:Label>
    </form>
</body>
</html>
