<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="CreateCurs.aspx.cs" Inherits="ProyectoEFE.Views.Curs.WebForm1" %>

<asp:Content ID="BodyContent1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-4">
               

                    <label for="name_curs" class="form-label">Nombre del curso</label>
                    <input runat="server" type="text" class="form-control" id="name_curs" />
                    <br />
                    <label for="description_curs" class="form-label">Descripcion del curso</label>
                    <input runat="server" type="text" class="form-control" id="description_curs" />
                    <br />
                    <label for="image_curs" class="form-label">Imagen del curso</label>
                    <input runat="server" type="text" class="form-control" id="image_curs" />
                    <br />

                    <asp:Button ID="btn_Crear_Curs" runat="server" Text="Crear Curso" class="btn btn-primary" OnClick="btn_Crear_Curs_Click" />
                
            </div>
        </div>
    </div>
  </asp:Content>
