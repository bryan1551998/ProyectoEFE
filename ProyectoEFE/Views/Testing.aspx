<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Testing.aspx.cs" Inherits="ProyectoEFE.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="El Rol Es: "></asp:Label>
            <h1 runat="server" id="role"> </h1>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Ver Rol" OnClick="Button1_Click" />
    </form>
</body>
</html>
