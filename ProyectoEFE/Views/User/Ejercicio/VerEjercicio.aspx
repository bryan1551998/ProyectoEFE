<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerEjercicio.aspx.cs" Inherits="ProyectoEFE.Views.User.Ejercicio.VerEjercicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row justify-content-center mb-4 pb-4">

            <div id="contenedorCursID" class="col-10 " runat="server">

                <h2 class="tituloCurstemsCards p-4 text-center" id="tituloEjercicio" runat="server"></h2>

                <div class="pt-4 pb-4">

                    <p class="" id="descriptionEjercicio" runat="server"></p>
                    <p>Ejemplo</p>
                    <p class="" id="ejemploEjercicio" runat="server"></p>
                    <input  type="text" id="respuestaEjercico" runat="server" class=" form-control"/>
                    <br/>
                    <asp:Button cssClass="btn btn-primary"  ID="btn_comprobar_result" runat="server" Text="Comprobar" OnClick="btn_comprobar_result_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
