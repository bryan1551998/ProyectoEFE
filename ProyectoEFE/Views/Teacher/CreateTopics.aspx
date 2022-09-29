<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateTopics.aspx.cs" Inherits="ProyectoEFE.Views.Teacher.CreateTopic" %>

<asp:Content ID="PaginaTopics" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container pb-4">
        <div class="row pt-4 pb-4">

            <div class="col-6">

                <label for="SelectCurs" class="form-label">Selecciona del curso al que pertene el tema</label>
                <asp:DropDownList ID="SelectCurs" runat="server" class="form-select">
                </asp:DropDownList>
                <br />
                <label for="name_topics" class="form-label">Nombre del tema</label>
                <input runat="server" type="text" class="form-control" id="name_topics" />
                <br />
                <label for="description_topics" class="form-label">Descripcion del tema</label>
                <textarea runat="server" type="text" class="form-control" id="description_topics" rows="4" cols="50"> </textarea>
                <br />
                <label for="image_topics" class="form-label">Imagen del tema</label>
                <input runat="server" type="text" class="form-control" id="image_topics" />
                <br />
                <asp:Button ID="btn_Crear_Topics" runat="server" Text="Crear Tema" class="btn btn-primary" OnClick="btn_Crear_Topics_Click" />
                <asp:Button ID="btn_Crear_Lessons" runat="server" Text="Crear Leccion" class="btn btn-primary" OnClick="btn_Crear_Lessons_Click" />
            </div>

            <div class="col-6 table-responsive">

                <asp:GridView ID="GridViewTopics" runat="server" CssClass="table table-hover" BorderStyle="None" GridLines="None">
                    <FooterStyle BorderStyle="None" />
                </asp:GridView>

            </div>

        </div>

        <div class="row pt-4 pb-4">
            <div class="col-6">

                <label for="id_tema_delete" class="form-label">Introduzca el <b>ID</b> del tema para eliminarlo: </label>
                <input runat="server" type="number" class="form-control" id="id_tema_delete" />
                <br />
                <asp:Button ID="btn_eliminar_curs" runat="server" Text="Eliminar Tema" class="btn btn-primary" OnClick="btn_eliminar_curs_Click" />

            </div>
        </div>
    </div>

      <script>
          var tabla = document.querySelector("#MainContent_GridViewTopics");
        var datatable = new DataTable(tabla);
      </script>

</asp:Content>
