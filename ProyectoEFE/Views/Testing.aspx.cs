using ProyectoEFE.Conexion;
using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEFE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DALCurs curs = new DALCurs();
            //CursModel cursModel = new CursModel("nombre 1", "description", "imagen");
            //curs.InsertCurs(cursModel);

            //List<CursModel> lisModels = curs.SelectCurs();

            //foreach (var item in lisModels)
            //{
            //    Debug.WriteLine(item.Id_curs+" - "+ item.Name_curs);
               
            //}
        }
    }
}