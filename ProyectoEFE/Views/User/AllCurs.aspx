<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCurs.aspx.cs" Inherits="ProyectoEFE.Views.User.AllCurs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #MainContent_contenedor {
            background-color: #fafafa  !important;
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(20rem, 1fr));
            grid-auto-rows: 15rem;
            grid-gap: 8px;
            padding:8px;
        }

        .CursAll {
            background-color: red;
            border-radius: 8px;
        }
    </style>

    <div class="container pb-4">
        <div class="row pt-4 pb-4">
            <div id="contenedor" class="contenidos" runat="server">
              
            </div>
        </div>

    </div>
</asp:Content>
