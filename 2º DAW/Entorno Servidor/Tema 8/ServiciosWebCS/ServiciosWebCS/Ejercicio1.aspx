<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="ServiciosWebCS.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <h2>CONSUMIR UN SERVICIO YA EXISTENTE</h2>
            <h1>Titulaciones Oficiales en la Universidad de Alicante</h1
        </div>
        <hr />
        <br />
        <div>
            Curso Académico (Formato aaaa-aa)
            <asp:TextBox runat="server" ID="txtCurso"></asp:TextBox>
            <asp:Button runat="server" text="Obtener Información" ID="btnObtenerInformacion" OnClick="btnObtenerInformacion_Click"/>
        </div>
        <br />
        <br />
        <br />
        <div>
            <asp:Label runat="server" ID="lblResultado">
                <asp:GridView runat="server" ID="GridView1"></asp:GridView>
            </asp:Label>
        </div>
        </center>
    </form>
</body>
</html>
