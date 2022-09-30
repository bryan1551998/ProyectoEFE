<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoEFE._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

         <div class="text-light text-right banner" id="tituloDeLaPagina">
                 <div class="display-4 text-center font-weight-bold heading">
                        <h1 id="titutlo" aria-atomic="False">
                            E.f{e}
                        </h1>
                        <h3>
                           Education For Everyone 
                       </h3>
                     <asp:Button Text="Teacher" runat="server" ID="butRegisteacher" OnClick="butRegisteacher_Click" />
                 </div>
            </div>
    </div>
</asp:Content>
