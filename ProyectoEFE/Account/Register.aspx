<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProyectoEFE.Account.Register" %>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

        <div class="container-flex  registerContenedor " id="divRegister">
            <div class="row justify-content-center">

                <div class="col-5 posicionamiento color-contenedor mt-4 ">

                    <div>
                        <center>
                            <h4 class="p-2">Registro de nuevo usuario</h4>
                        </center>
                        <hr />
                        <%-- <asp:ValidationSummary runat="server" CssClass="text-danger" />--%>
                    </div>

                    <div id="MainContent_contenedor_Register">
                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="">Nombre</asp:Label>
                            <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                                CssClass="text-danger" ErrorMessage="Nombre obligatorio*." />
                        </div>

                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="LastName" CssClass="">Apellido</asp:Label>
                            <asp:TextBox runat="server" ID="LastName" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                                CssClass="text-danger" ErrorMessage="Apellido obligatorio*." />
                        </div>

                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="NickName" CssClass="">Usuario</asp:Label>
                            <asp:TextBox runat="server" ID="NickName" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="NickName"
                                CssClass="text-danger" ErrorMessage="Usuario obligatorio*." />
                        </div>

                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="BirthDay" CssClass="">Fecha De Nacimiento</asp:Label>
                            <asp:TextBox runat="server" placeholder="mm/dd/yyyy" ID="BirthDay" CssClass="form-control" TextMode="Date" required="true" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="BirthDay"
                                CssClass="text-danger" ErrorMessage="The birth day field is required." />
                        </div>

                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="selectRol" CssClass="">¿Que eres?</asp:Label>
                            <select name="select" runat="server" id="selectRol" class="form-select">
                                <option runat="server" value="student" selected>Student</option>
                                <option runat="server" value="teacher">Teacher</option>
                            </select>
                        </div>
                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="selectgender" CssClass="">¿Que eres?</asp:Label>
                            <select name="select" runat="server" id="selectgender" class="form-select">
                                <option runat="server" value="Hombre" selected>Hombre</option>
                                <option runat="server" value="Mujer">Mujer</option>
                                <option runat="server" value="Otro">Otro</option>
                            </select>
                        </div>


                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="Email" CssClass="">Email</asp:Label>
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="text-danger" ErrorMessage="Email obligatorio*." />
                        </div>

                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="Password" CssClass="">Contraseña</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                CssClass="text-danger" ErrorMessage="Contraseña obligatoria*." />
                        </div>

                        <div class="">
                            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="">Confirmar contraseña</asp:Label>
                            <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="Contraseña obligatoria*." />
                            <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="Las contraseñas no coinciden." />

                        </div>
                    </div>

                    <div class="text-danger p-2">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </div>

                    <hr />

                    <div class="form-group">
                        <center>
                            <div class="">
                                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn btn-outline-light botonRegister " />
                            </div>
                        </center>
                    </div>
                </div>
            </div>
        </div>
    </div>
    


</asp:Content>