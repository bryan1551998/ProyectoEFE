using Microsoft.AspNet.Identity;
using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProyectoEFE.Views.User
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "student")
            {
                Response.Redirect("~/");
            }

            //Coger todos los cursos 
            DALCurs curs = new DALCurs();

            List<CursModel> lisModels = curs.UserCurs(Context.User.Identity.GetUserId());


            for (int i = 0; i < lisModels.Count; i++)
            {
                //Crear el DIV padre
                HtmlGenericControl item = new HtmlGenericControl("div");
                item.Attributes.Add("class", "CursAll pb-4");
                item.Attributes.Add("id", "cursoDatos" + i);

                //Crear titulo
                HtmlGenericControl titulo = new HtmlGenericControl("div");
                titulo.Attributes.Add("id", "tituloCurs" + i);
                titulo.Attributes.Add("class", "tituloCursClass");
                titulo.InnerText = lisModels[i].Name_curs;

                //Crear imagen
                HtmlGenericControl imagen = new HtmlGenericControl("img");
                imagen.Attributes.Add("id", "imagenCurs" + i);
                imagen.Attributes.Add("src", lisModels[i].Image_url_curs);
                imagen.Attributes.Add("width", "95px");
                imagen.Attributes.Add("class", "imgCursClass");

                //Crear description
                HtmlGenericControl description = new HtmlGenericControl("div");
                description.Attributes.Add("id", "descriptionCurs" + i);
                description.Attributes.Add("class", "descriptionCursClass");
                description.InnerText = lisModels[i].Description_curs;

                //Crea boton
                Button btn = new Button();
                btn.Attributes.Add("runat", "server");
                btn.Click += new EventHandler(btn_Subscribirse_Click);
                btn.Text = "Clic" + i;
                btn.Attributes.Add("class", "btn btn-primary btn-curs-user");
                btn.Attributes.Add("name", "prueba");
                btn.CommandName = lisModels[i].Id_curs.ToString();

                //Añadir los hijos al padre
                contenedor.Controls.Add(item);
                item.Controls.Add(titulo);
                item.Controls.Add(imagen);
                item.Controls.Add(description);
                item.Controls.Add(btn);

            }

        }

        protected void btn_Subscribirse_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            CursUserModel cursUser = new CursUserModel(int.Parse(btn.CommandName), Context.User.Identity.GetUserId());
            DALCursoUser dALCursoUser = new DALCursoUser();



            Debug.WriteLine("hola seleccionaste el curso " + cursUser.Fk_users + " - " + cursUser.Fk_curs + " - " + cursUser.Fk_exercise + " ?");

            Response.Redirect("/Views/User/Curs/VerCurso?hola=" + cursUser.Fk_curs);


        }
    }
}