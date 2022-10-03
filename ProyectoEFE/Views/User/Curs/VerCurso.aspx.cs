using Microsoft.AspNet.Identity;
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

namespace ProyectoEFE.Views.User.Curs
{
    public partial class VerCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Comprobar Rol
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "student")
            {
                Response.Redirect("~/");
            }

            //Mostrar curso
            this.MostrarCurso();
        }

        public void MostrarCurso()
        {
            //Obtenr id enviado por URL del Curso
            string parametro = Request.QueryString["cusoId"];

            //Coger todos los cursos 
            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.SelectCursId(parametro);
            this.nameCursMyCurs.InnerText = lisModels[0].Name_curs;
            this.parrafoMyCurs.InnerText = lisModels[0].Description_curs;
            this.imagenfoMyCurs.Src = lisModels[0].Image_url_curs;

            //Obtenr temas
            DALTopics dALTopics = new DALTopics();
            List<TopicsModel> lisTopics = new List<TopicsModel>();
            lisTopics = dALTopics.SelectTopicsIdCurs(lisModels[0].Id_curs);

            for (int i = 0; i < lisTopics.Count; i++)
            {
                //Obtener ejercicios
                DALExercises dALExercises = new DALExercises();
                List<ExercisesModel> lisExercise = new List<ExercisesModel>();
                lisExercise = dALExercises.SelectExercisesId(lisTopics[i].Id_topic);

                //Crear el DIV padre
                HtmlGenericControl accordionItem = new HtmlGenericControl("div");
                accordionItem.Attributes.Add("class", "accordion-item");

                //Crear titulo
                HtmlGenericControl item = new HtmlGenericControl("h2");
                item.Attributes.Add("class", "accordion-header");
                item.Attributes.Add("id", "flush-headingOne" + i);

                //Crea boton
                HtmlGenericControl btn = new HtmlGenericControl("button");
                btn.Attributes.Add("class", "accordion-button collapsed temaTitle");
                btn.Attributes.Add("type", "button");
                btn.Attributes.Add("data-bs-toggle", "collapse");
                btn.Attributes.Add("data-bs-target", "#flush-collapseOne" + i);
                btn.Attributes.Add("aria-expanded", "false");
                btn.Attributes.Add("aria-controls", "flush-collapseOne" + i);
                btn.InnerText = lisTopics[i].Name_topic;

                //Crear div contenido
                HtmlGenericControl conteindo = new HtmlGenericControl("div");
                conteindo.Attributes.Add("id", "flush-collapseOne" + i);
                conteindo.Attributes.Add("class", "accordion-collapse collapse");
                conteindo.Attributes.Add("aria-labelledby", "flush-headingOne" + i);
                conteindo.Attributes.Add("data-bs-parent", "#MainContent_accordionExample");

                //Crear div description
                HtmlGenericControl description = new HtmlGenericControl("div");
                description.Attributes.Add("class", "accordion-body bodyAcordeonPadre");
                description.InnerText = lisTopics[i].Description_topic;

                HtmlGenericControl accordionPadre = new HtmlGenericControl("div");
                for (int j = 0; j < lisExercise.Count; j++)
                {

                    //Crear el DIV padre
                    accordionPadre.Attributes.Add("class", "accordion accordion-flush");
                    accordionPadre.Attributes.Add("id", "accordionExample2");
                    accordionPadre.Attributes.Add("runat", "server");

                    //Crear el DIV hijo
                    HtmlGenericControl accordionItem2 = new HtmlGenericControl("div");
                    accordionItem2.Attributes.Add("class", "accordion-item");

                    //Crear titulo
                    HtmlGenericControl item2 = new HtmlGenericControl("h2");
                    item2.Attributes.Add("class", "accordion-header");
                    item2.Attributes.Add("id", "flush-headingOne2" + j);

                    //Crea boton
                    HtmlGenericControl btn2 = new HtmlGenericControl("button");
                    btn2.Attributes.Add("class", "accordion-button collapsed descriptionBtnAcordeon");
                    btn2.Attributes.Add("type", "button");
                    btn2.Attributes.Add("data-bs-toggle", "collapse");
                    btn2.Attributes.Add("data-bs-target", "#flush-collapseOne2" + j);
                    btn2.Attributes.Add("aria-expanded", "false");
                    btn2.Attributes.Add("aria-controls", "flush-collapseOne2" + j);
                    btn2.InnerText = lisExercise[j].Name_exercise;

                    //Crear div contenido
                    HtmlGenericControl conteindo2 = new HtmlGenericControl("div");
                    conteindo2.Attributes.Add("id", "flush-collapseOne2" + j);
                    conteindo2.Attributes.Add("class", "accordion-collapse collapse");
                    conteindo2.Attributes.Add("aria-labelledby", "flush-headingOne2" + j);
                    conteindo2.Attributes.Add("data-bs-parent", "#MainContent_accordionExample2");

                    //Crea boton
                    Button btnEjercicio = new Button();
                    btnEjercicio.Attributes.Add("runat", "server");
                    btnEjercicio.Click += new EventHandler(btn_Subscribirse_Click);
                    btnEjercicio.Attributes.Add("class", "btn btn-primary btnEjercicioCurso");
                    btnEjercicio.Attributes.Add("name", "prueba");
                    btnEjercicio.CommandName = lisExercise[j].Id_exercise.ToString();

                    DALHistorial dALHistoria2 = new DALHistorial();
                    int resultadoExercise = dALHistoria2.SelectHistorail(Context.User.Identity.GetUserId(), lisExercise[j].Id_exercise);

                    //Comprobar Historial
                    if (resultadoExercise == 1)
                    {
                        btnEjercicio.Text = "Ejercicio completado";
                        btnEjercicio.Enabled = false;
                    }
                    else
                    {
                        btnEjercicio.Text = "Ir al ejercicio";
                    }

                    //Crear div description
                    HtmlGenericControl description2 = new HtmlGenericControl("div");
                    description2.Attributes.Add("class", "accordion-body");
                    description2.InnerText = lisExercise[j].Description_exercise;

                    //Añadir todas al etiqeutas al padre
                    accordionPadre.Controls.Add(accordionItem2);
                    accordionItem2.Controls.Add(item2);
                    accordionItem2.Controls.Add(conteindo2);
                    item2.Controls.Add(btn2);
                    conteindo2.Controls.Add(description2);
                    conteindo2.Controls.Add(btnEjercicio);
                }

                //Añadir todas al etiqeutas al padre
                this.accordionExample.Controls.Add(accordionItem);
                accordionItem.Controls.Add(item);
                accordionItem.Controls.Add(conteindo);
                item.Controls.Add(btn);
                conteindo.Controls.Add(description);
                description.Controls.Add(accordionPadre);
            }
        }

        protected void btn_Subscribirse_Click(object sender, EventArgs e)
        {
            //Obtener los datos del boton seleccionado
            Button btn = (Button)sender;

            //Obtener ejercicios
            DALExercises dALExercises = new DALExercises();
            List<ExercisesModel> lisExercise = new List<ExercisesModel>();
            lisExercise = dALExercises.SelectExercisesIdexercise(int.Parse(btn.CommandName));

            Debug.WriteLine("hola seleccionaste el ejercicio " + lisExercise[0].Name_exercise);

            //Enviar ejercicio por URL
            Response.Redirect("/Views/User/Ejercicio/VerEjercicio?ejercicioId=" + lisExercise[0].Id_exercise);

        }
    }
}