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
            <h1>Para Probar la insercion a la base de datos</h1>
            <asp:Label ID="Label1" runat="server" Text="Agregar Curso"></asp:Label>
            <asp:TextBox ID="txtcurso" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Add_Curs" runat="server" OnClick="Add_Curs_Click" Text="Añadir" />
        <p>
            <asp:Label ID="Labe" runat="server" Text="Agregar Topic"></asp:Label>
            <asp:TextBox ID="txttopics" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Add_topics" runat="server" OnClick="Add_topics_Click" Text="Añadir" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Agregar Leccion"></asp:Label>
            <asp:TextBox ID="txtlesson" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Add_lesson" runat="server" OnClick="Add_lesson_Click" Text="Añadir" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Agregar Ejercicio"></asp:Label>
            <asp:TextBox ID="txtexerci" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Add_exercises" runat="server" OnClick="Add_exercises_Click" Text="Añadir" />
        </p>
    </form>
</body>
</html>
