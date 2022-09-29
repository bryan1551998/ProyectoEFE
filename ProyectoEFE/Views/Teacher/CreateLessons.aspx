<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateLessons.aspx.cs" Inherits="ProyectoEFE.Views.Teacher.CreateLesson" %>
<asp:Content ID="PaginaLessons" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container pb-4">
        <div class="row pt-4 pb-4">

            <div class="col-6">

                <label for="SelectLesson" class="form-label">Selecciona el tema al que pertene la lesión</label>
                <asp:DropDownList ID="SelectLesson" runat="server" class="form-select">
                </asp:DropDownList>
                <br />
                <label for="name_lesson" class="form-label">Nombre del lesión</label>
                <input runat="server" type="text" class="form-control" id="name_lesson" />
                <br />
                <label for="description_lesson" class="form-label">Descripcion de la lesión</label>
                <textarea runat="server" type="text" class="form-control" id="description_lesson" rows="4" cols="50"> </textarea>
                <br />
                <label for="image_lesson" class="form-label">Imagen del lesión</label>
                <input runat="server" type="text" class="form-control" id="image_lesson" />
                <br />
                <asp:Button ID="btn_Crear_Lesson" runat="server" Text="Crear Lesión" class="btn btn-primary" OnClick="btn_Crear_Lesson_Click" />
                <asp:Button ID="btn_Crear_Exercises" runat="server" Text="Crear Ejercicio" class="btn btn-primary" OnClick="btn_Crear_Exercises_Click" />
            </div>

            <div class="col-6 table-responsive">

                <asp:GridView ID="GridViewLesson" runat="server" CssClass="table table-hover" BorderStyle="None" GridLines="None">
                    <FooterStyle BorderStyle="None" />
                </asp:GridView>

            </div>
        </div>

        <div class="row pt-4 pb-4">
            <div class="col-6">

                <label for="id_lesson_delete" class="form-label">Introduzca el <b>ID</b> de la lesión para eliminarlo: </label>
                <input runat="server" type="number" class="form-control" id="id_lesson_delete" />
                <br />
                <asp:Button ID="btn_eliminar_lesson" runat="server" Text="Eliminar Lesión" class="btn btn-primary" OnClick="btn_eliminar_lesson_Click" />

            </div>
        </div>
    </div>

      <script>
          var tabla = document.querySelector("#MainContent_GridViewLesson");
        var datatable = new DataTable(tabla);
      </script>

</asp:Content>
