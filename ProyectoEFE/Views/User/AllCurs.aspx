<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCurs.aspx.cs" Inherits="ProyectoEFE.Views.User.AllCurs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #MainContent_contenedor {
            background-color: #fafafa !important;
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(20rem, 1fr));
            grid-auto-rows: auto;
            grid-gap: 15px;
            padding: 8px;
        }

        .CursAll {
            background-color: red;
            border-radius: 8px;
        }

        .tituloCursClass {
            text-align: center;
            padding: 12px;
        }

        .imgCursClass {
            margin: 10px auto;
            display: block;
        }

        .descriptionCursClass {
            padding: 10px;
            text-align: justify;
            height: 150px
        }
    </style>

    <div class="container pb-4">
        <div class="row pt-4 pb-4">
            <div id="contenedor" class="contenidos" runat="server">
                
            </div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>

    </div>
</asp:Content>
