<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TiposVer.aspx.cs" Inherits="GesTienda.TiposVer"%>
<%@ OutputCache Duration="1" VaryByParam="None" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="InfoContenido" runat="server">
    <div class="contenidotitulo">Tipos de productos</div>
 <asp:GridView ID="grdTipos" runat="server" AutoGenerateColumns="False" DataKeyNames="IdTipo" DataSourceID="SqlDataSource1" EnableSortingAndPagingCallbacks="True" AllowPaging="True" HorizontalAlign="Center" PageSize="5" Width="50%" CellPadding="4" ForeColor="#333333" GridLines="None">
     <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
     <Columns>
         <asp:BoundField DataField="IdTipo" HeaderText="Código" ReadOnly="True" SortExpression="IdTipo" />
         <asp:BoundField DataField="DesTip" HeaderText="Descripción" SortExpression="DesTip" />
     </Columns>
     <EditRowStyle BackColor="#999999" />
     <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
     <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
     <PagerSettings FirstPageText="Primero" LastPageText="Último" Mode="NextPreviousFirstLast" NextPageText="Siguiente" PreviousPageText="Anterior" />
     <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
     <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
     <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
     <SortedAscendingCellStyle BackColor="#E9E7E2" />
     <SortedAscendingHeaderStyle BackColor="#506C8C" />
     <SortedDescendingCellStyle BackColor="#FFFDF8" />
     <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
 <br />
 <div>
 <asp:Label ID="lblResultado" runat="server"></asp:Label>
 </div>
 <br />
 <asp:Label ID="lblMensajes" ForeColor="red" runat="server"></asp:Label>
 <br />
 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [TIPO]"></asp:SqlDataSource>
 <br />
</asp:Content>
