<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="ProyectoEFE.Views.User.Perfil" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="fondoPantallaGeneralDisplayFlex" >
         <!-- contenedor general--> 
            <div class="color-contenedor posicionamiento contenedorPefil">
                <div class="">
                                        <!--contenedor de parte superior-->
                    <div class="contenedorSuperior d-flex flex-column justify-content-center align-items-center">            
                        <button class="btn1 btn-secondary mt-3">                 
                            <img src="*"  runat="server" id="imagenGenero" height="100" width="100" />              
                        </button>                
                        <div runat="server" id="nombreUser" class="name mt-2 mb-2"></div>              
                        <div runat="server" id="rolUser"></div>               
                        <div class="d-flex flex-row justify-content-center align-items-center p-2">                
                            <span class="number">1069 
                                <span class="follow">Followers</span>
                            </span> 
                        </div>  
                    </div>
                                <!--contenedor didascalia-->
              
                    <div class="d-flex justify-content-center align-items-center">    
                        <div class="mb-2 bg_Sobremi ">
                            <span>     
                                Eleanor Pena is a creator of minimalistic x bold graphics and digital artwork.<br/>            
                                Artist/ Creative Director by Day #NFT minting@ with FND night.             
                            </span> 
                        </div>
                    </div>
                   
                </div>
                
                          <div class="contenedorSecuencia bg-carousel"> <!--contenedor de las secuencias de los cursos-->
                              <br />
                                 <h2>Cursos Iniciados/Realizados</h2>
                                 <hr />
                                    <div id="carouselExampleControls" class="carousel slide " data-bs-ride="carousel">
                                       <div class="carousel-inner contenidos bg_div_carousel" id="contenedor" runat="server">
                                       </div>
                                       <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev" id="Next">
                                          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                          <span class="visually-hidden">Previous</span>
                                      </button>
                                      <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next" id="Prev">
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
                                <!-- Button trigger modal -->
                                <button type="button" class="btn btn-outline-light" data-bs-toggle="modal" data-bs-target="#staticBackdrop">
                                  Edit Perfil
                                </button>

                                <!-- Modal -->
                                <div class="modal fade " id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                                  <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
                                    <div class="modal-content color-contenedor" style="border-radius:15px;">
                                      <div class="heaterModal">
                                        <h5 class="modal-title" id="staticBackdropLabel">Editar Perfil</h5>
                                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                      </div>
                                      <div class="modalBody  p-3">
                                          <div class="datosModal m-auto">
                                                <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="form-label">Nombre</asp:Label>
                                                <asp:TextBox runat="server" ID="firstName" CssClass="form-control" TextMode="SingleLine" />
                                                <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                                                    CssClass="text-danger" ErrorMessage="Nombre obligatorio*." />
                                            </div>

                                            <div class="datosModal m-auto">
                                                <asp:Label runat="server" AssociatedControlID="LastName" CssClass="form-label">Apellido</asp:Label>
                                                <asp:TextBox runat="server" ID="lastName" CssClass="form-control" TextMode="SingleLine" />
                                                <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                                                    CssClass="text-danger" ErrorMessage="Apellido obligatorio*." />
                                            </div>

                                            <div class="datosModal m-auto">
                                                <asp:Label runat="server" AssociatedControlID="NickName" CssClass="form-label">Usuario</asp:Label>
                                                <asp:TextBox runat="server" ID="nickName" CssClass="form-control" TextMode="SingleLine" />
                                                <asp:RequiredFieldValidator runat="server" ControlToValidate="NickName"
                                                    CssClass="text-danger" ErrorMessage="Usuario obligatorio*." />
                                            </div>

                                            <div class="datosModal m-auto">
                                                <asp:Label runat="server" AssociatedControlID="selectRol" CssClass="form-label">¿Que eres?</asp:Label>
                                                <select name="select" runat="server" id="selectRol" class="form-select">
                                                    <option runat="server" value="student" selected>Student</option>
                                                    <option runat="server" value="teacher">Teacher</option>
                                                </select>
                                            </div>
                                            <div class="datosModal mt-2 m-auto">
                                                <asp:Label runat="server" AssociatedControlID="selectgender" CssClass="form-label">¿Que eres?</asp:Label>
                                                <select name="select" runat="server" id="selectgender" class="form-select">
                                                    <option runat="server" value="Hombre" selected>Hombre</option>
                                                    <option runat="server" value="Mujer">Mujer</option>
                                                    <option runat="server" value="Otro">Otro</option>
                                                </select>
                                                <asp:RequiredFieldValidator runat="server" ControlToValidate="selectgender"
                                                    CssClass="text-danger" ErrorMessage="Escoje,Por favor*." />
                                            </div>
                                      </div>
                                      <div class="footerModal m-auto">
                                        <asp:Button runat="server" OnClick="ModifyUser_Click" Text="Confirmar" CssClass="btn btn-light botonesModal" />
                                      </div>
                                    </div>
                                  </div>
                                </div>
                                <!-- Scrollable modal
                                    <div class="modal-dialog modal-dialog-scrollable">
                                      ...
                                    </div>-->
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
                               
</asp:Content>
