<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CreateCurs.aspx.cs" Inherits="ProyectoEFE.Views.Teacher.TeacherCurs" %>

<asp:Content ID="PaginaCurs" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container pb-4 mb-4 fondo-cursos">
        <center>
            <h3 class="p-4">Administrar Cursos</h3>
        </center>

        <div class="row pt-4 pb-4">

            <div class="col-6">

                <label for="name_curs" class="form-label">Nombre del curso</label>
                <input runat="server" type="text" class="form-control" id="name_curs" />
                <br />
                <label for="description_curs" class="form-label">Descripcion del curso</label>
                <textarea runat="server" type="text" class="form-control" id="description_curs" rows="1" cols="50" />
                <br />
                <label for="image_curs" class="form-label">Imagen del curso</label>
                <input runat="server" type="text" class="form-control" id="image_curs" />
                <br />
                <asp:Button ID="btn_Crear_Curs" runat="server" Text="Crear Curso" class="btn btn-primary" OnClick="btn_Crear_Curs_Click" />
                <asp:Button ID="btn_Crear_Tema" runat="server" Text="Crear Tema" class="btn btn-primary" OnClick="btn_Crear_Topic_Click" />
            </div>
            <div class="col-6">

                <label for="id_curs_delete" class="form-label">Introduzca el <b>ID</b> del curso para eliminarlo: </label>
                <input runat="server" type="number" class="form-control" id="id_curs_delete" />
                <br />
                <asp:Button ID="btn_eliminar_curs" runat="server" Text="Eliminar" class="btn btn-primary" OnClick="btn_eliminar_curs_Click" />
            </div>
        </div>

        <hr />
        
        <div class="row pt-4 pb-4">


            <div class="col-12 table-responsive">

                <asp:GridView ID="GridViewCurs" runat="server" CssClass="table table-hover" BorderStyle="None" GridLines="None">
                    <FooterStyle BorderStyle="None" />
                </asp:GridView>

            </div>
        </div>
    </div>
    <script>
        var tabla = document.querySelector("#MainContent_GridViewCurs");
        var datatable = new DataTable(tabla);
    </script>
</asp:Content>
