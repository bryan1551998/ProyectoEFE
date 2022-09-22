<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProyectoEFE.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <main class="fondoPantallaGeneralDisplaygrid">
        <div class=" color-contenedor posicionamiento">
            <p class="text-danger">
                <asp:Literal runat="server" ID="ErrorMessage" />
            </p>

            <div class="form-group">
                <h4>Create a new account</h4>
                <hr />
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="">
                    <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="">First Name</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" TextMode="SingleLine" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                            CssClass="text-danger" ErrorMessage="The first name field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="LastName" CssClass="">Last Name</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="LastName" CssClass="form-control" TextMode="SingleLine" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                            CssClass="text-danger" ErrorMessage="The last name field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="BirthDay" CssClass="">Birth Day</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" placeholder="mm/dd/yyyy" ID="BirthDay" CssClass="form-control" TextMode="Date" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                            CssClass="text-danger" ErrorMessage="The birth day field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Email" CssClass="">Email</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                            CssClass="text-danger" ErrorMessage="The email field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="NickName" CssClass="">User Name</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="NickName" CssClass="form-control" TextMode="SingleLine" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="NickName"
                            CssClass="text-danger" ErrorMessage="The first name field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Password" CssClass="">Password</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                            CssClass="text-danger" ErrorMessage="The password field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="">Confirm password</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                        <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                    </div>
                </div>
                <div class="form-group">
                    <div class="">
                        <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn btn-outline-light" />
                    </div>
                </div>
            </div>
        </div>
    </main>
    
</asp:Content>
