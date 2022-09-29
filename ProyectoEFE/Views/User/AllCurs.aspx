<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCurs.aspx.cs" Inherits="ProyectoEFE.Views.User.AllCurs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        
    </style>
    <div class="fondoPantallaGeneralDisplayFlex"><!--contenedor general-->
        <div class="color-contenedor posicionamiento "><!--contenedor contenido general-->
            <div><!--contenedor objetos -->
                <div class="p-2"><!--Titulo-->
                    <h1>Cursos Disponibles</h1>
                </div>
                    <!--contenedor de los cursos-->
                    <div id="contenedor" class="color-contenedor table-responsive" runat="server">

                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
    
</asp:Content>
