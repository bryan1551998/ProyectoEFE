using Microsoft.AspNet.Identity;
using ProyectoEFE.Conexion;
using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProyectoEFE.Views.User
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DALUser imagen = new DALUser();
            string imagenGender = imagen.ImagenGender(Context.User.Identity.GetUserId());
            this.imagenGenero.Src= imagenGender;
            DALUser user = new DALUser();
            string cualquiera= user.NameUser(Context.User.Identity.GetUserId());
            this.nombreUser.InnerText = cualquiera;
            DALRole rol = new DALRole();
            string roles = rol.ReadRol(Context.User.Identity.GetUserId());
            this.rolUser.InnerText = roles;

            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.UserCurs(Context.User.Identity.GetUserId());
            // Creamos los elementos de la lista de forma dinámica

            for (int i = 0; i < lisModels.Count; i++)
            {
                HtmlGenericControl item = new HtmlGenericControl("div");
                item.Attributes.Add("class", " bg_contenido carousel-item ");
                if (i == 0)
                {
                    item.Attributes.Add("class", " bg_contenido carousel-item active ");
                }
                item.Attributes.Add("id", "cursoDatos" + i);
                item.InnerText = lisModels[i].Name_curs;

                contenedor.Controls.Add(item);

                HtmlGenericControl item2 = new HtmlGenericControl("p");
                item2.Attributes.Add("id", "descriptionCurs" + i);
                item2.InnerText = lisModels[i].Description_curs;

                HtmlImage item3 = new HtmlImage();
                item3.Attributes.Add("id", "imagenCurs" + i);
                item3.Attributes.Add("src", lisModels[i].Image_url_curs);
                item3.Attributes.Add("width", "50px");

                item.Controls.Add(item2);
                item.Controls.Add(item3);
            }
        }
        protected void ModifyUser_Click(object sender, EventArgs e)
        {
            DALUser usuario = new DALUser();
            string sfirstName = firstName.Text;
            string slastName = lastName.Text;
            string snickName = (string)nickName.Text;
            string srole = this.selectRol.Value.ToString();
            string sgender = this.selectgender.Value.ToString();
            UserModel usuarioCambiodatos = new UserModel(sfirstName,slastName,snickName,srole,sgender);        
            usuario.Modificar_Usuario(usuarioCambiodatos, Context.User.Identity.GetUserId());
        }

    }
}