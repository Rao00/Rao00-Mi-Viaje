<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LineasFactura.aspx.cs" Inherits="GesFactura.LineasFactura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h1>Uso de Servicio Web - Cálculos factura de un artículo</h1></center>
        </div>
        <br />
        <div>
            <center><table>
                <tr>
                    <td><asp:Label runat="server">Cantidad</asp:Label></td>
                    <td><asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Precio</asp:Label></td>
                    <td><asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Descuento (%)</asp:Label></td>
                    <td><asp:TextBox ID="txtDescuento" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Tipo de IVA (%)</asp:Label></td>
                    <td><asp:TextBox ID="txtTipoIVA" runat="server"></asp:TextBox></td>
                </tr>
            </table></center>
        </div>
        <br />
        <div>
            <center>
                <asp:Button runat="server" Text="Enviar" ID="btnEnviar" OnClick="btnEnviar_Click"/>
            </center>
        </div>
        <br />
        <br />
        <br />
        <div>
            <center><p>Resultados de los cálculos:</p></center>
            <hr />
            <center>
                <table>
                    <tr>
                        <td><asp:Label runat="server">Bruto</asp:Label></td>
                        <td><asp:Label runat="server">Descuento</asp:Label></td>
                        <td><asp:Label runat="server">Base Imponible</asp:Label></td>
                        <td><asp:Label runat="server">IVA</asp:Label></td>
                        <td><asp:Label runat="server">Total</asp:Label></td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" ID="lblBruto"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblDescuento"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblBaseImponible"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblIva"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblTotal"></asp:Label></td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>

</html>
