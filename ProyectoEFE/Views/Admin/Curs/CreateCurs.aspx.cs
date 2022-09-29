using Microsoft.AspNet.Identity;
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
            //Contolar ROL
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "admin")
            {
                Response.Redirect("~/");
            }
            this.CrearTableCurs();
        }

        protected void btn_Crear_Curs_Click(object sender, EventArgs e)
        {
            DALCurs curs = new DALCurs();
            DALUser user = new DALUser();
            
            CursModel cursModel = new CursModel(this.name_curs.Value, this.description_curs.Value, this.image_curs.Value, user.NameUser(Context.User.Identity.GetUserId()).ToString());
            curs.InsertCurs(cursModel);
            this.CrearTableCurs();
            this.LimpiarFormCurs();
            Response.Redirect("~/Views/Admin/Curs/CreateCurs");
        }

        public void CrearTableCurs()
        {
            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.SelectCurs();
            this.GridViewCurs.DataSource = lisModels;
            this.GridViewCurs.DataBind();
        }

        public void LimpiarFormCurs()
        {
            this.name_curs.Value = "";
            this.description_curs.Value = "";
            this.image_curs.Value = "";
        }

        protected void btn_eliminar_curs_Click(object sender, EventArgs e)
        {
            DALCurs curs = new DALCurs();
            curs.EliminarCurs(int.Parse(this.id_curs_delete.Value));
            this.id_curs_delete.Value = "";
            this.CrearTableCurs();
        }
    }
}