<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerCurso.aspx.cs" Inherits="ProyectoEFE.Views.User.Curs.VerCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row justify-content-center mb-4 pb-4">

            <div id="contenedorCursID" class="col-10 " runat="server">

                <%-- Info corso --%>
                <h2 class="tituloCurstemsCards p-4 text-center" id="nameCursMyCurs" runat="server"></h2>

                <center>
                    <img id="imagenfoMyCurs" runat="server" class="img-fluid" />
                </center>

                <div class="pt-4 pb-4">
                    <p class="text-center " id="parrafoMyCurs" runat="server"></p>
                </div>
                <%--  --%>

                <%-- Contenido Cursos --%>
                <div id="contendorMyCursos" runat="server"></div>

                <%-- Acordeon cursos --%>
                <div class="accordion accordion-flush pt-4" id="accordionExample" runat="server">
                </div>

            </div>

        </div>
    </div>
</asp:Content>
