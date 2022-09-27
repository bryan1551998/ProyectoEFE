<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="ProyectoEFE.Views.User.Perfil" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="fondoPantallaGeneralDisplayFlex">
        <div class="color-contenedor posicionamiento">
            <div class="contenedorInfoGeneral">
                <div >
                    <img src="../../images/The.Matrix.glmatrix.2.png" class="img" />
                </div>
                <div>
                    <div id="contenedorInfo">
                        <label for="nombreP">Nombre</label>
                        <input type="text" id="nombreP" />
                        <label for="apellidoP">Apellido</label>
                        <input type="text" id="apellidoP" />
                        <label for="fechaP">Fecha de nacimiento</label>
                        <input type="text" id="fechaP"/>
                        <label for="apodoP">Apodo</label>
                        <input type="text" id="apodoP" />
                        <label for="rolP">Rol</label>
                        <input type="text" id="rolP"/>
                    </div>
                    
                </div>
            </div>
            <div>
                <div>
                    <h2>Cursos Realizados</h2>
                    <hr />
                          <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
                               <div class="carousel-inner">
                                   <div class="contenidos " id="contenedor" runat="server">
                                   </div>
                               </div>
                                  <button runat="server" class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev" id="Next">
                                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Previous</span>
                                  </button>
                                  <button runat="server" class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next" id="Prev">
                                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Next</span>
                                  </button>
                          </div>
                </div>
            </div>
        </div>

</asp:Content>
