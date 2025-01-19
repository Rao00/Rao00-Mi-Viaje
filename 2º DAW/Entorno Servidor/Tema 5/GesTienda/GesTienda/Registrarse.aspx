<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="GesTienda.Registrarse" %>
<%@ OutputCache Duration="1" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="Estilos/HojaEstilo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div id="cabecera1">
               <br />
               comerciodaw.com &nbsp;
            </div>
            <div id="cabecera2">
                <br />
                &nbsp;&nbsp;TIENDA ONLINE - SHOPPING DAW<br />
                <br />
            </div>
        </header>
        <center>
        <div>
            <br />
            <h2>GesTienda</h2>
            <h4>Registro Usuario</h4>
            <table>
                <tr>
                    <td>Correo electrónico</td>
                    <td><asp:TextBox runat="server" ID="txtCorCli"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Contraseña</td>
                    <td><asp:TextBox runat="server" ID="txtPassword1" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Introduzca nuevamente la contraseña</td>
                    <td><asp:TextBox runat="server" ID="txtPassword2" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>NIF/NIE/CIF</td>
                    <td><asp:TextBox runat="server" ID="txtIdCliente"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nombre/Razón Social</td>
                    <td><asp:TextBox runat="server" ID="txtNomCli"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Dirección</td>
                    <td><asp:TextBox runat="server" ID="txtDirCli"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Población</td>
                    <td><asp:TextBox runat="server" ID="txtPobCli"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Código Postal</td>
                    <td><asp:TextBox runat="server" ID="txtCpoCli"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Teléfono</td>
                    <td><asp:TextBox runat="server" ID="txtTelCli"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <asp:Button Text="Insertar" runat="server" ID="btnInsertar" OnClick="btnInsertar_Click"/>
            <br /><br /><br /><br />
            <asp:LinkButton runat="server" PostBackUrl="~/Default.aspx">Ir a Inicio</asp:LinkButton><br />
            <asp:Label ID="lblMensajes" ForeColor="red" runat="server"></asp:Label>
        </div></center>
        <br /><br /><br /><br /><br /><br /><br /><br /><br />
        <footer id="pie">
            © Desarrollo de Aplicaciones Web interactivas con Acceso a Datos
            <br />
            IES Mare Nostrum (Alicante)
        </footer>
    </form>
</body>
</html>
