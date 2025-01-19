<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GesPresta.Default" %>

<%@ Register src="Cabecera.ascx" tagname="Cabecera" tagprefix="uc1" %>

<!DOCTYPE html>
<link rel="stylesheet" href="stylesheet.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:Cabecera ID="Cabecera1" runat="server" />
        <div class="parrafo">
            <br />
            <p>
                La corporación ACME está comprometida con sus empleados. Para ello ha establecido una serie de prestaciones que pueden utilizar sus empleados para obtener ayudas sociales asociados a diversos gastos de tipo familiar, medico, etc.
            </p>
            <p>
                Esta aplicacion a traves de Web permite realizar todas las tareas de gestion relacionadas con la prestacion de ayudas a los empleados
            </p>
            <p>
                Para cualquier duda o consulta puede contactar con el Departamento de Ayuda Social: <a href="">ayuda.social@acme.com</a>
            </p>
        </div>
    </form>
</body>
</html>
