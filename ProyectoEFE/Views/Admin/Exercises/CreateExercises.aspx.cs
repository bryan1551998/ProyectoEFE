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

namespace ProyectoEFE.Views.Exercises
{
    public partial class CreateExercises : System.Web.UI.Page
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
                DALLessons lessons = new DALLessons();
                List<LessonsModel> listLessons = lessons.SelectLessons();
                foreach (var item in listLessons)
                {
                    this.SelectExercises.Items.Add("ID: " + item.Id_lessons.ToString() + " - " + item.Name_lesson.ToString());
                }
            }
            this.CrearTableTopics();
        }

        protected void btn_Crear_exercise_Click(object sender, EventArgs e)
        {
            //Recuperar el indice del select 
            int indiceSelect = this.SelectExercises.SelectedIndex;

            //Recuperar los Lesiones
            DALLessons lessons = new DALLessons();
            List<LessonsModel> lisModels = lessons.SelectLessons();

            //Insertar el tema
            ExercisesModel exercisesModel = new ExercisesModel(lisModels[indiceSelect].Id_lessons, this.image_exercise.Value, this.name_exercise.Value, this.description_exercise.Value, this.resposta_exercise.Value);
            DALExercises exercise = new DALExercises();
            exercise.InsertExercises(exercisesModel);
            Response.Redirect("~/Views/Admin/Exercises/CreateExercises");
        }

        public void CrearTableTopics()
        {
            DALExercises exercise = new DALExercises();
            List<ExercisesModel> lisModels = exercise.SelectExercises();
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