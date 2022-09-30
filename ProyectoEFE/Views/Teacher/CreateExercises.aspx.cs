using Microsoft.AspNet.Identity;
using ProyectoEFE.Conexion;
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
    public partial class CreateExercises : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Comprobar ROL
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "teacher")
            {
                Response.Redirect("~/");
            }

            //Controlar tabla para no crar duplicados
            if (!IsPostBack)
            {
                DALTopics topics = new DALTopics();
                List<TopicsModel> listTopics = topics.SelectTopics(Context.User.Identity.GetUserId());
                foreach (var item in listTopics)
                {
                    this.SelectExercises.Items.Add("ID: " + item.Id_topic.ToString() + " - " + item.Name_topic.ToString());
                }
            }
            this.CrearTableTopics();
        }

        protected void btn_Crear_exercise_Click(object sender, EventArgs e)
        {
            //Recuperar los Topics del usuairp
            DALTopics topics = new DALTopics();
            List<TopicsModel> listTopics = topics.SelectTopics(Context.User.Identity.GetUserId());

            //Recuperar el indice seleccionado 
            int indiceSelect = listTopics[SelectExercises.SelectedIndex].Id_topic;

            //Insertar el tema
            ExercisesModel exercisesModel = new ExercisesModel(this.name_exercise.Value, this.description_exercise.Value, this.resposta_exercise.Value, this.number_of_exercise.Value);
            DALExercises exercise = new DALExercises();
            exercise.InsertExercises(exercisesModel, indiceSelect);
            Response.Redirect("~/Views/Teacher/CreateExercises");
        }

        public void CrearTableTopics()
        {
            DALExercises exercise = new DALExercises();
            List<ExercisesModel> lisModels = exercise.SelectExercises(Context.User.Identity.GetUserId());
            this.GridViewExercise.DataSource = lisModels;
            this.GridViewExercise.DataBind();
        }

        protected void btn_eliminar_lesson_Click(object sender, EventArgs e)
        {
            DALExercises exercise = new DALExercises();
            exercise.EliminareExercise(int.Parse(this.id_exercise_delete.Value));
            Response.Redirect("~/Views/Exercises/CreateExercises");
        }
    }
}