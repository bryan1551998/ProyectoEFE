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

namespace ProyectoEFE.Views.Topics
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Controlar ROL
            DALRole roleuser = new DALRole();
            Session["role"] = roleuser.ReadRol(Context.User.Identity.GetUserId());
            if (Session["role"].ToString().Trim() != "admin")
            {
                Response.Redirect("~/");
            }

            //Controlar tabla para no crar duplicados
            if (!IsPostBack)
            {
                DALCurs curs = new DALCurs();
                List<CursModel> lisModels = curs.SelectCurs();
                foreach (var item in lisModels)
                {
                    this.SelectCurs.Items.Add("ID: " + item.Id_curs.ToString() + " - " + item.Name_curs.ToString());
                }
            }
            this.CrearTableTopics();
        }

        protected void btn_Crear_Topics_Click(object sender, EventArgs e)
        {
            //Recuperar el indice del select 
            int indiceSelect = this.SelectCurs.SelectedIndex;

            //Recuperar los cursos
            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.SelectCurs();

            //Insertar el tema
            TopicsModel topicsModel = new TopicsModel(lisModels[indiceSelect].Id_curs, this.image_topics.Value, this.name_topics.Value, this.description_topics.Value);
            DALTopics topic = new DALTopics();
            topic.InsertTopic(topicsModel);
            Response.Redirect("~/Views/Admin/Topics/CreateTopics");
        }

        public void CrearTableTopics()
        {
            DALTopics topics = new DALTopics();
            List<TopicsModel> lisModels = topics.SelectTopics();
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