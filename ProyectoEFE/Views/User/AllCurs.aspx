<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCurs.aspx.cs" Inherits="ProyectoEFE.Views.User.AllCurs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        
    </style>

    <div class="container">
        <div class="row">
            <center class="p-4">
                <h2 class="tituloCurstemsCards">Catálogo de cursos</h2>
                <h6>Elije el que más te guste</h6>

            </center>
            <div id="result" class="resultCursItems" runat="server">
            </div>
            <div id="contenedorCurs" class="contenidos" runat="server">
            </div>
            <br />
        
        </div>



    </div>
</asp:Content>
