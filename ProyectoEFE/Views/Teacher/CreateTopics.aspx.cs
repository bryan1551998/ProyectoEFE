using Microsoft.AspNet.Identity;
using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEFE.Views.Teacher
{
    public partial class CreateTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Controlar ROL
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "teacher")
            {
                Response.Redirect("~/");
            }

            //Controlar tabla para no crar duplicados
            if (!IsPostBack)
            {
                DALCurs curs = new DALCurs();
                List<CursModel> lisModels = curs.SelectCurs(Context.User.Identity.GetUserId());
                foreach (var item in lisModels)
                {
                    this.SelectCurs.Items.Add("ID: " + item.Id_curs.ToString() + " - Name: " + item.Name_curs.ToString());
                }
            }
            this.CrearTableTopics();
        }

        protected void btn_Crear_Topics_Click(object sender, EventArgs e)
        {
            //Recuperar los cursos del usuario
            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.SelectCurs(Context.User.Identity.GetUserId());

            //Recuperar el indice seleccionado 
            int indiceSelect = lisModels[SelectCurs.SelectedIndex].Id_curs;

            //Insertar el tema
            TopicsModel topicsModel = new TopicsModel(this.name_topics.Value, this.description_topics.Value, this.image_topics.Value);
            DALTopics topic = new DALTopics();
            topic.InsertTopic(topicsModel, indiceSelect);
            Response.Redirect("~/Views/Teacher/CreateTopics");
        }
        protected void btn_Crear_Lessons_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Teacher/CreateLessons");
        }


        public void CrearTableTopics()
        {
            DALTopics topics = new DALTopics();
            List<TopicsModel> lisModels = topics.SelectTopics(Context.User.Identity.GetUserId());
            this.GridViewTopics.DataSource = lisModels;
            this.GridViewTopics.DataBind();
        }

        protected void btn_eliminar_curs_Click(object sender, EventArgs e)
        {
            DALTopics topics = new DALTopics();
            topics.EliminarTopic(int.Parse(this.id_tema_delete.Value));
            Response.Redirect("~/Views/Topics/CreateTopics");
        }
    }
}