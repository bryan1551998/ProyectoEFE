<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CursPage.aspx.cs" Inherits="ProyectoEFE.CursPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtnamecurs" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Add_Curs" runat="server" OnClick="Add_Curs_Click" Text="Añadir curso" />
    </form>
</body>
</html>
