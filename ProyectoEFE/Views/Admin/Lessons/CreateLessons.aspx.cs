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
using System.Web.UI.WebControls;

namespace ProyectoEFE.Views.Lessons
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Comprobar ROL
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "admin")
            {
                Response.Redirect("~/");
            }

            //Controlar tabla para no crar duplicados
            if (!IsPostBack)
            {
                DALTopics topics = new DALTopics();
                List<TopicsModel> lisModels = topics.SelectTopics();
                foreach (var item in lisModels)
                {
                    this.SelectLesson.Items.Add("ID: " + item.Id_topic.ToString() + " - " + item.Name_topic.ToString());
                }
            }
            this.CrearTableLessons();
        }

        protected void btn_Crear_Lesson_Click(object sender, EventArgs e)
        {
            //Recuperar los Topics del usuairp
            DALTopics topics = new DALTopics();
            List<TopicsModel> lisModels = topics.SelectTopics(Context.User.Identity.GetUserId());

            //Recuperar el indice seleccionado 
            int indiceSelect = lisModels[SelectLesson.SelectedIndex].Id_topic;

            //Insertar el tema
            LessonsModel topicsModel = new LessonsModel(this.image_lesson.Value, this.name_lesson.Value, this.description_lesson.Value);
            DALLessons lessons = new DALLessons();
            lessons.InsertLesson(topicsModel, indiceSelect);
            Response.Redirect("~/Views/Admin/Lessons/CreateLessons");
        }

        public void CrearTableLessons()
        {
            DALLessons lessons = new DALLessons();
            List<LessonsModel> lisModels = lessons.SelectLessons();
            this.GridViewLesson.DataSource = lisModels;
            this.GridViewLesson.DataBind();
        }

        protected void btn_eliminar_lesson_Click(object sender, EventArgs e)
        {
            DALLessons lessons = new DALLessons();
            lessons.EliminarLessons(int.Parse(this.id_lesson_delete.Value));
            Response.Redirect("~/Views/Lessons/CreateLessons");
        }
    }
}