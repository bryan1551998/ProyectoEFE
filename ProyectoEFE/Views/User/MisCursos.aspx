<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCursos.aspx.cs" Inherits="ProyectoEFE.Views.User.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <center class="p-4">
                <h2 class="tituloCurstemsCards">Catálogo de cursos</h2>
                <h6>Mis cursos</h6>
            </center>
            <div id="contenedorCurs" class="contenidos" runat="server">
            </div>

        </div>
    </div>

</asp:Content>
