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

namespace ProyectoEFE.Views.User.Ejercicio
{
    public partial class VerEjercicio : System.Web.UI.Page
    {
        string parametro;

        public string Parametro { get => parametro; set => parametro = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Comprobar Rol
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "student")
            {
                Response.Redirect("~/");
            }

            this.respuestaExercise.Visible = false;

            //Mostar ejercicio
            this.MostrarEjercicio();
        }
        public void MostrarEjercicio()
        {
            //Obtener ejercicio
            this.Parametro = Request.QueryString["ejercicioId"];

            //Obtener ejercicios
            DALExercises dALExercises = new DALExercises();
            List<ExercisesModel> lisExercise = new List<ExercisesModel>();
            lisExercise = dALExercises.SelectExercisesIdexercise(int.Parse(Parametro));

            this.tituloEjercicio.InnerText = lisExercise[0].Name_exercise;
            this.descriptionEjercicio.InnerText = lisExercise[0].Description_exercise;
            this.ejemploEjercicio.InnerText = lisExercise[0].Ejemplo_exercise;

        }

        protected void btn_comprobar_result_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { ' ' };

            //Obtener ejercicios
            DALExercises dALExercises = new DALExercises();
            List<ExercisesModel> lisExercise = new List<ExercisesModel>();
            lisExercise = dALExercises.SelectExercisesIdexercise(int.Parse(Parametro));

            string n1 = lisExercise[0].Solution_exercise.Trim(charsToTrim);
            string n2 = this.respuestaEjercico.Value.Trim(charsToTrim);

            Debug.WriteLine(n1);
            Debug.WriteLine(n2);

            if (n1 == n2)
            {
                this.respuestaExercise.Visible = true;
                Debug.WriteLine("Acertaste!!!!!!!");
                HistorialModel historial = new HistorialModel(Context.User.Identity.GetUserId(), int.Parse(Parametro), 1);
                DALHistorial dALHistorial = new DALHistorial();
                dALHistorial.InsertCurs(historial);
                this.btn_comprobar_result.Enabled = false;
                this.respuestaExercise.InnerText = "Respuesta correcta.";
            }
            else
            {
                this.respuestaExercise.Visible = true;
                Debug.WriteLine("Eres pendejo !");
                this.respuestaExercise.InnerText = "Intentalo otra vez.";
                this.respuestaEjercico.Value = "";
            }
        }
    }
}