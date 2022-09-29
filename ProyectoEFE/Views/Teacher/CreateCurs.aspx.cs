using Microsoft.AspNet.Identity;
using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEFE.Views.Teacher
{
    public partial class TeacherCurs: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "teacher")
            {
                Response.Redirect("~/");
            }
            this.CrearTableCurs();
        }

        protected void btn_Crear_Curs_Click(object sender, EventArgs e)
        {
            string iduser = Context.User.Identity.GetUserId();
            DALCurs curs = new DALCurs();
            
            CursModel cursModel = new CursModel(this.name_curs.Value, this.description_curs.Value, this.image_curs.Value, Context.User.Identity.GetUserName());
            curs.InsertCurs(cursModel, iduser);
            curs.SelectUserCurs(iduser);
            int fkCurs = curs.SelectUserCurs(iduser);
            curs.ReletionCursUser(fkCurs, iduser);
            this.CrearTableCurs();
            this.LimpiarFormCurs();
            Response.Redirect("~/Views/Teacher/CreateCurs");
        }
        protected void btn_Crear_Topic_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Teacher/CreateTopics");
        }

        public void CrearTableCurs()
        {
            //creart otro insert en la tabla de relaciones
            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.UserCurs(Context.User.Identity.GetUserId());
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