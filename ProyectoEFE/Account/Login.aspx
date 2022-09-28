<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoEFE.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="fondoPantallaGeneralDisplayFlex">
            <div class="color-contenedor posicionamiento ">
                <div class="p-3">
                    <section id="loginForm">
                    <div class="">
                        <h4>Login</h4>
                        <hr />
                        <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="FailureText" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="Email" CssClass="">Email</asp:Label>
                            <div class="">
                                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                    CssClass="text-danger" ErrorMessage="The email field is required." />
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="Password" CssClass="">Password</asp:Label>
                            <div class="">
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="">
                                <div class="checkbox">
                                    <asp:CheckBox runat="server" ID="RememberMe" />
                                    <asp:Label runat="server" AssociatedControlID="RememberMe">Recuerdame</asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="form-group botonLogin ">
                            <div class="">
                                <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-outline-light " />
                            </div>
                        </div>
                    </div>
                    <p>
                        <asp:HyperLink runat="server" CssClass="link-light" ID="RegisterHyperLink" ViewStateMode="Disabled">Registrate</asp:HyperLink>
                    </p>
                    <p>
                        <%-- Enable this once you have account confirmation enabled for password reset functionality
                        <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Forgot your password?</asp:HyperLink>
                        --%>
                    </p>
                </section>
            </div>
                <div>
                    <section id="socialLoginForm">
                        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
                    </section>
                </div>
         </div>                
    </div>
</asp:Content>
