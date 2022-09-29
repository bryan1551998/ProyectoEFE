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

namespace ProyectoEFE.Views.User
{
    public partial class AllCurs : System.Web.UI.Page
    {
        int numeroQe;

        public int NumeroQe { get => numeroQe; set => numeroQe = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Coger todos los cursos 
            DALCurs curs = new DALCurs();
            List<CursModel> lisModels = curs.SelectCurs();

            // Creamos los elementos de la lista de forma dinámica
            for (int i = 0; i < lisModels.Count; i++)
            {
                //Crear el DIV padre
                HtmlGenericControl item = new HtmlGenericControl("div");
                item.Attributes.Add("class", "CursAll pb-4");
                item.Attributes.Add("id", "cursoDatos" + i);

                //Crear titulo
                HtmlGenericControl titulo = new HtmlGenericControl("div");
                titulo.Attributes.Add("id", "tituloCurs" + i);
                titulo.Attributes.Add("class", "tituloCursClass");
                titulo.InnerText = lisModels[i].Name_curs;

                //Crear imagen
                HtmlGenericControl imagen = new HtmlGenericControl("img");
                imagen.Attributes.Add("id", "imagenCurs" + i);
                imagen.Attributes.Add("src", lisModels[i].Image_url_curs);
                imagen.Attributes.Add("width", "95px");
                imagen.Attributes.Add("class", "imgCursClass");

                //Crear description
                HtmlGenericControl description = new HtmlGenericControl("div");
                description.Attributes.Add("id", "descriptionCurs" + i);
                description.Attributes.Add("class", "descriptionCursClass");
                description.InnerText = lisModels[i].Description_curs;

                //Crea boton
                Button btn = new Button();
                btn.Attributes.Add("runat", "server");
                btn.Click += new EventHandler(btn_Subscribirse_Click);
                btn.Text = "Clic"+i;
                btn.Attributes.Add("class", "btn btn-primary");
                btn.Attributes.Add("name", "prueba");
                btn.CommandName = lisModels[i].Id_curs.ToString();

                //Añadir los hijos al padre
                contenedor.Controls.Add(item);
                item.Controls.Add(titulo);
                item.Controls.Add(imagen);
                item.Controls.Add(description);
                item.Controls.Add(btn);
            }
        }

        protected void btn_Subscribirse_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            Debug.WriteLine("hola" + btn.CommandName);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("MAm----ong");
        }
    }
}