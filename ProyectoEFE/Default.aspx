<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoEFE._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>-->

    <div class="container">
        <div class="w3-content" style="max-width: 100%; margin-top: 46px">

            <!-- Automatic Slideshow Images -->
            <div class="mySlide w3-display-container w3-center estilo_imagen_carrusel">
                <img src="../imagenes/ProyectoAprendisaje1.jpg" class="imgenesprincipales">
                <div class="w3-display-middle w3-container w3-text-white w3-padding-32 w3-hide-small">
                    <h1>E.f{e}</h1>
                    <h3><b>Education For Everyone</b></h3>
                    <h6>
                         <a class="btn w3-white w3-padding-large w3-large w3-opacity w3-hover-opacity-off" style="transition: 3s;" runat="server" href="~/Account/Register">   
                           Registrarme
                        </a>
                    </h6>
                </div>
            </div>
            <div class="mySlides w3-display-container w3-center estilo_imagen_carrusel">
                <img src="../imagenes/working-on-code.jpg" class="imgenesprincipales">
                <div class="w3-display-middle w3-container w3-text-white w3-padding-32 w3-hide-small">
                    <h1>E.f{e}</h1>
                    <h3><b>Education For Everyone</b></h3>
                    <h6>
                        <button class="btn w3-white w3-padding-large w3-large w3-opacity w3-hover-opacity-off" style="transition: 3s;" runat="server" href="~/Account/Register">
                            Registrarmes
                        </button>
                        
                    </h6>
                </div>
            </div>
            <div class="mySlides w3-display-container w3-center estilo_imagen_carrusel">
                <img src="../imagenes/imagenPefe.jpg" class="imgenesprincipales">
                <div class="w3-display-middle w3-container w3-text-white w3-padding-32 w3-hide-small">
                    <h1>E.f{e}</h1>
                    <h3><b>Education For Everyone</b></h3>
                    <h6>
                        <button class="btn w3-white w3-padding-large w3-large w3-opacity w3-hover-opacity-off" style="transition: 3s;" href="~/Account/Register.aspx">
                            Registrarme
                        </button>
                    </h6>
                </div>
            </div>


            <!--Curse section-->

            <div class="gradiantbg">
                <div class="w3-container w3-content w3-center w3-padding-64" style="max-width: 80%; max-height: 70%;" id="cursos">
                    <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="false">
                        <div class="carousel-indicators">
                            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
                            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
                            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="3" aria-label="Slide 4"></button>
                        </div>
                        <div class="carousel-inner">
                            <div class="carousel-item active">
                                <img src="./imagenes/WebDesign.jpg" class="d-block w-100" alt="..." width="600px" height="500px">
                                <div class="carousel-caption d-none d-lg-block">
                                    <h5>Desarrollo Web</h5>
                                    <p>Some representative placeholder content for the first slide.</p>
                                </div>
                            </div>
                            <div class="carousel-item">
                                <img src="./imagenes/CBSCTY.jpg" class="d-block w-100" alt="..." width="600px" height="500px">
                                <div class="carousel-caption d-none d-lg-block">
                                    <h5>Ciberseguridad</h5>
                                    <p>Some representative placeholder content for the second slide.</p>
                                </div>
                            </div>
                            <div class="carousel-item">
                                <img src="./imagenes/AI.jpg" class="d-block w-100" alt="..." width="600px" height="500px">
                                <div class="carousel-caption d-none d-lg-block">
                                    <h5>Itenligencia Artificial</h5>
                                    <p>Some representative placeholder content for the third slide.</p>
                                </div>
                            </div>
                            <div class="carousel-item">
                                <img src="./imagenes/Robotica.jpg" class="d-block w-100" alt="..." width="600px" height="500px">
                                <div class="carousel-caption d-none d-md-block">
                                    <h5>Informatica aplicada al campo de la Robotica</h5>
                                    <p>Some representative placeholder content for the fourth slide.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



                <!-- The Band Section -->
                <div class="w3-container w3-content w3-center w3-padding-64" style="max-width: 800px" id="AboutUs">
                    <h2 class="w3-wide">Education For Everyone</h2>
                    <p class="w3-opacity">
                        <i>Nos encanta aprender y descubrir</i>
                    </p>
                    <p class="w3-justify">
                        hemos creado este sitio web para que la gente de cualquier clase social pueda aprender de manera gratiuta y sencilla el arte de programar 
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
            ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur
            adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                    </p>
                    <div class="w3-row w3-padding-32">
                        <div class="w3-third">
                            <p>Ignacio Lerda</p>
                            <p>ing. Informatico & Founder</p>
                            <img src="./imagenes/The.Matrix.glmatrix.2.png" class="w3-round w3-margin-bottom" alt="Random Name" style="width: 60%">
                        </div>
                        <div class="w3-third">
                            <p>Sebastian</p>
                            <p>ing. Informatico & Founder</p>
                            <img src="./imagenes/The.Matrix.glmatrix.2.png" class="w3-round w3-margin-bottom" alt="Random Name" style="width: 60%">
                        </div>
                        <div class="w3-third">
                            <p>Bryan</p>
                            <p>ing. Informatico & Founder</p>
                            <img src="./imagenes/The.Matrix.glmatrix.2.png" class="w3-round" alt="Random Name" style="width: 60%">
                        </div>
                    </div>
                </div>

                <!-- The Contact Section -->
                <div class="w3-container w3-content w3-padding-64" style="max-width: 800px" id="contact">
                    <h2 class="w3-wide w3-center">Contactanos</h2>
                    <p class="w3-opacity w3-center"><i>Te atreves al reto?</i></p>
                    <div class="w3-row w3-padding-32">
                        <div class="w3-col m6 w3-large w3-margin-bottom">
                            <i class="fa fa-map-marker" style="width: 30px"></i>Barcelona, Es<br>
                            <i class="fa fa-phone" style="width: 30px"></i>Phone: +34 627894567<br>
                            <i class="fa fa-envelope" style="width: 30px"></i>Email: user@educatioforeveryone.com<br>
                        </div>
                        <div class="w3-col m6">
                            <form action="/action_page.php" target="_blank">
                                <div class="w3-row-padding" style="margin: 0 -16px 8px -16px">
                                    <div class="w3-half">
                                        <input class="w3-input w3-border" type="text" placeholder="Name" required name="Name">
                                    </div>
                                    <div class="w3-half">
                                        <input class="w3-input w3-border" type="text" placeholder="Email" required name="Email">
                                    </div>
                                </div>
                                <input class="w3-input w3-border" type="text" placeholder="Message" required name="Message">
                                <button class="w3-button w3-black w3-section w3-right" type="submit">Enviar</button>
                            </form>
                        </div>
                    </div>
                </div>

                <!-- End Page Content -->
            </div>
        </div>
    </div>
</asp:Content>
