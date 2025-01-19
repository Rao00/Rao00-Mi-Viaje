<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlError.aspx.cs" Inherits="GesTienda.ControlError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <h1>Aplicación Web GesTienda</h1><br />
        <h3>Error en el tiempo de ejecución</h3>
        
        <article style="text-align:left; width:50%; padding:20px;">
            <p style="margin-top:20px">Error ASP.NET:</p>
            <asp:Label runat="server" ID="lblErrorASP" ForeColor="Red"></asp:Label>
            <p style="margin-top:20px">Error ADO.NET:</p>
            <asp:Label runat="server" ID="lblErrorADO" style="margin-bottom:20px" ForeColor="Red" Height="40px"></asp:Label>
        </article>
        </center>
    </form>
</body>
</html>
