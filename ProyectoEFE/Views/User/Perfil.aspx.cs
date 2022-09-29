using Microsoft.AspNet.Identity;
using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
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
            DALUser user = new DALUser();
            string cualquiera= user.NameUser(Context.User.Identity.GetUserId());
            this.nombreUser.InnerText = cualquiera;
            DALRole rol = new DALRole();
            string roles = rol.ReadRol(Context.User.Identity.GetUserId());
            this.rolUser.InnerText = roles;

            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.SelectCurs();
            // Creamos los elementos de la lista de forma dinámica

            for (int i = 0; i < lisModels.Count; i++)
            {
                HtmlGenericControl item = new HtmlGenericControl("div");
                item.Attributes.Add("class", "CursAll carousel-item ");
                if (i == 2)
                {
                    item.Attributes.Add("class", "active");
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
       
    }
}