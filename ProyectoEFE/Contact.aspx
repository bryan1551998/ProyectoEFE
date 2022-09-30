<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ProyectoEFE.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="fondoPantallaGeneralDisplayFlex">
        <div class="color-contenedor posicionamiento aboutContainer" id="AboutUs">
            <h2 class="pt-4">Envianos Tus Dudas</h2>
            <div class="d-flex justify-content-center align-content-center">
                <div class="contenedorContactanos_form">
                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Email</label>
                        <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com">
                    </div>
                    <div class="mb-3">
                        <label for="exampleFormControlTextarea1" class="form-label">Escribe aqui tu consulta:</label>
                        <textarea class="form-control" id="exampleFormControlTextarea1" rows="6"></textarea>
                    </div>
                </div>
            </div>
            <div>
                <button type="submit" class="btn btn-light">Enviar</button>
            </div>
            <address>
                En la segunda avenida del cielo estrellado<br />
                Barcelona, ES
                <br />
                <abbr title="Phone">Tel.:</abbr>
                +34-queteimporta
            </address>
        </div>
    </main>
</asp:Content>
