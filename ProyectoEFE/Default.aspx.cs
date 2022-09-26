using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEFE
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butRegisteacher_Click(object sender, EventArgs e)
        {
            //Create a Teacher Register 
            Session["regisTeacher"] = "teacher";
            Response.Redirect("~/Account/Register");
        }
    }
}