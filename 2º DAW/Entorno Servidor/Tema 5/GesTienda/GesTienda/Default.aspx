    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GesTienda.Default" %>
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
        <center><main>
            <br /><h2>GesTienda</h2><br />
            <section>
                <article>
                    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
                        <LayoutTemplate>
                            <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
                                <tr>
                                    <td>
                                        <table cellpadding="0">
                                            <tr>
                                                <td align="center" colspan="2" style="color:#000000; font-size:1.5em; font-weight:bold; height: 50px;">Iniciar sesión</td>
                                            </tr>
                                            <tr>
                                                <td align="right" style="padding-right:10px">
                                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Correo electrónico:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em" Width="145px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" style="padding-right:10px">
                                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password" Width="145px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2" style="color:Red;">
                                                    <asp:Button ID="LoginButton" runat="server" BorderWidth="1px" CommandName="Login" Font-Names="Arial" Font-Size="1em" Text="Inicio de sesión" ValidationGroup="Login1" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" colspan="2">
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                    </asp:Login>
                    <br />
                    <center>
                        <asp:Label ID="lblMensajes" runat="server" visible="false"></asp:Label><br />
            <asp:LinkButton runat="server" ID="LinkButton1" PostBackUrl="~/Registrarse.aspx">Registrarse</asp:LinkButton>
                    </center>
                </article>
            </section>
        </main></center>
        <br /><br /><br /><br /><br /><br /><br /><br /><br />
        <footer id="pie">
            © Desarrollo de Aplicaciones Web interactivas con Acceso a Datos
            <br />
            IES Mare Nostrum (Alicante)
        </footer>
    </form>
</body>
</html>
