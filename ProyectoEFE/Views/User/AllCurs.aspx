<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCurs.aspx.cs" Inherits="ProyectoEFE.Views.User.AllCurs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        
    </style>

    <div class="container pb-4">
        <div class="row pt-4 pb-4">
            <div id="result" class="contenidos" runat="server">
            </div>
            <div id="contenedor" class="contenidos" runat="server">
            </div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>



    </div>
</asp:Content>
