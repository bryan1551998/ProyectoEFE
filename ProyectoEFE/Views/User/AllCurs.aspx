<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCurs.aspx.cs" Inherits="ProyectoEFE.Views.User.AllCurs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                         <!--contenedor general-->
        <div class="color-contenedor posicionamiento " style="max-width:850px; min-width:850px;">
            <div><!--contenedor objetos -->
                <div class="p-2"><!--Titulo-->
                    <h1>Cursos Disponibles</h1>
                </div>
                    <!--contenedor de los cursos-->
                    <div id="contenedor" class="color-contenedor table-responsive" runat="server">

                    </div>
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-outline-light p-2 m-3" Text="Button" OnClick="Button1_Click" />
            </div>
        </div>

    
</asp:Content>
