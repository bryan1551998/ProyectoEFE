<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="ProyectoEFE.Views.User.Perfil" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="fondoPantallaGeneralDisplayFlex">
            <div class="color-contenedor posicionamiento contenedorPerfil ">
                <div class="d-flex justify-content-center"><!-- contenedor general-->
                    <div >
                        <div class="contenedorSuperior d-flex flex-column justify-content-center align-items-center"><!--contenedor de parte superior-->
                                     <button class="btn1 btn-secondary mt-3">
                                         <img src="https://i.imgur.com/wvxPV9S.png" height="100" width="100" />
                                     </button>
                                       <div runat="server" id="nombreUser" class="name mt-3"></div>
                                       <div runat="server" id="rolUser"></div>

                                     <div class="d-flex flex-row justify-content-center align-items-center p-2">
                                         <span class="number">1069 
                                             <span class="follow">Followers</span>
                                         </span> 
                                     </div>
                                    
                                    <div class="mb-2 bg_Sobremi"  style="color:black;">
                                                       <span>Eleanor Pena is a creator of minimalistic x bold graphics and digital artwork.
                                                             Artist/ Creative Director by Day #NFT minting@ with FND night.
                                                        </span>
                                    </div>
                          </div>
                        
                          <div class="contenedorSecuencia bg-carousel"> <!--contenedor de las secuencias de los cursos-->
                              <br />
                              <br />
                                 <h2>Cursos Iniciados/Realizados</h2>
                                 <hr />
                                    <div id="carouselExampleControls" class="carousel slide " data-bs-ride="carousel">
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
                              <br />
                              <hr />
                              <br />
                         </div>
                        <div class="bg-pieDePerfil">
                            <div class=" d-flex d-flex flex-column justify-content-center align-items-center">
                                <button class="btn btn-outline-light">Edit Profile</button>

                            </div> 
                            <div class="gap-3 mt-3 icons d-flex flex-row justify-content-center align-items-center"> 
                                <span><i class="fa fa-twitter"></i></span>
                                <span><i class="fa fa-facebook-f"></i></span>       
                                <span><i class="fa fa-instagram"></i></span>      
                                <span><i class="fa fa-linkedin"></i></span>     
                            </div> 
                            <br />
                        </div>
                        
                    </div>
               </div>
        </div>
 </div>
                        
</asp:Content>
