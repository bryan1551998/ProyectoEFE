<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateExercises.aspx.cs" Inherits="ProyectoEFE.Views.Exercises.CreateExercises" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container pb-4">
        <div class="row pt-4 pb-4">

            <div class="col-6">

                <label for="SelectExercises" class="form-label">Selecciona la lesión a la que pertene el ejercicio</label>
                <asp:DropDownList ID="SelectExercises" runat="server" class="form-select">
                </asp:DropDownList>
                <br />
                <label for="name_exercise" class="form-label">Nombre del ejercicio</label>
                <input runat="server" type="text" class="form-control" id="name_exercise" />
                <br />
                <label for="description_exercise" class="form-label">Descripcion del ejercicio</label>
                <textarea runat="server" type="text" class="form-control" id="description_exercise" rows="4" cols="50"> </textarea>
                <br />
                <label for="number_of_exercise" class="form-label">Numero de Ejercicio</label>
                <input runat="server" type="text" class="form-control" id="number_of_exercise" />
                <br />
                <label for="resposta_exercise" class="form-label">Respuesta del ejercicio</label>
                <input runat="server" type="text" class="form-control" id="resposta_exercise" />
                <br />
                
                <asp:Button ID="btn_Crear_exercise" runat="server" Text="Crear Ejercicio" class="btn btn-primary" OnClick="btn_Crear_exercise_Click"  />

            </div>

            <div class="col-6 table-responsive">

                <asp:GridView ID="GridViewExercise" runat="server" CssClass="table table-hover" BorderStyle="None" GridLines="None">
                    <FooterStyle BorderStyle="None" />
                </asp:GridView>

            </div>
        </div>

        <div class="row pt-4 pb-4">
            <div class="col-6">

                <label for="id_exercise_delete" class="form-label">Introduzca el <b>ID</b> de ejercicio para eliminarlo: </label>
                <input runat="server" type="number" class="form-control" id="id_exercise_delete" />
                <br />
                <asp:Button ID="btn_eliminar_lesson" runat="server" Text="Eliminar Ejercicio" class="btn btn-primary" OnClick="btn_eliminar_lesson_Click"  />

            </div>
        </div>
    </div>

    <script>
        var tabla = document.querySelector("#MainContent_GridViewExercise");
        var datatable = new DataTable(tabla);
    </script>

</asp:Content>
