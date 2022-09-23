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
    public partial class AllCurs : System.Web.UI.Page
    {
        int numeroQe;

        public int NumeroQe { get => numeroQe; set => numeroQe = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //
            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.SelectCurs();
            // Creamos los elementos de la lista de forma dinámica

            for (int i = 0; i < lisModels.Count; i++)
            {
                HtmlGenericControl item = new HtmlGenericControl("div");
                item.Attributes.Add("class", "CursAll");
                item.Attributes.Add("id", "cursoDatos" + i);
                item.InnerText = lisModels[i].Name_curs;

                contenedor.Controls.Add(item);

                HtmlGenericControl item2 = new HtmlGenericControl("p");
                item2.Attributes.Add("id", "descriptionCurs" + i);
                item2.InnerText = lisModels[i].Description_curs;

                HtmlGenericControl item3 = new HtmlGenericControl("img");
                item3.Attributes.Add("id", "imagenCurs" + i);
                item3.Attributes.Add("src", lisModels[i].Image_url_curs);
                item3.Attributes.Add("width","50px");

                item.Controls.Add(item2);
                item.Controls.Add(item3);
            }



        }
    }
}