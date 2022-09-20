using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEFE.Views.Curs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn_Crear_Curs_Click(object sender, EventArgs e)
        {
            DALCurs curs = new DALCurs();
            CursModel cursModel = new CursModel(this.name_curs.Value, this.description_curs.Value, this.image_curs.Value);
            curs.InsertCurs(cursModel);
        }
    }
}