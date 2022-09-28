<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ProyectoEFE.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main class="fondoPantallaGeneralDisplayFlex" >
        <div class="color-contenedor posicionamiento aboutContainer" id="AboutUs">
            <div class="aboutContainer_Informacion d-flex justify-content-center text-center">
                <div id="collapseOne"  aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                    <h1>
                        Education For Everyone
                    </h1>
                        <h3>
                            <i>Nos encanta aprender y descubrir</i>
                        </h3>
                        <br />
                        <p>
                            hemos creado este sitio web para que la gente de cualquier clase social pueda aprender de manera gratiuta y sencilla el arte de programar 
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
                            ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur
                            adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
               </div>
            </div>
            
            <div class="aboutContainer_Personal">
                <div>
                    <p>Ignacio Lerda</p>
                    <p>ing. Informatico & Founder</p>
                    <img src="../images/The.Matrix.glmatrix.2.png" class="aboutContainer_Personal_img" alt="Random Name">
                </div>
                <div>
                    <p>Sebastian</p>
                    <p>ing. Informatico & Founder</p>
                    <img src="../images/The.Matrix.glmatrix.2.png" class="aboutContainer_Personal_img" alt="Random Name">
                </div>
                <div>
                    <p>Bryan</p>
                    <p>ing. Informatico & Founder</p>
                    <img src="../images/The.Matrix.glmatrix.2.png" class="aboutContainer_Personal_img" alt="Random Name">
                </div>
            </div>
        </div>
    </main>
    
</asp:Content>
