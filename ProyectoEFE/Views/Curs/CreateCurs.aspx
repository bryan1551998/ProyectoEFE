<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCurs.aspx.cs" Inherits="ProyectoEFE.Views.Curs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-4">
                <form runat="server">

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
                </form>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
