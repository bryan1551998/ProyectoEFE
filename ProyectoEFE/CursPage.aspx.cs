using ProyectoEFE.DAL;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEFE
{
    public partial class CursPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Curs_Click(object sender, EventArgs e)
        {
            DalCurs addcurs = new DalCurs();
            string namc = txtnamecurs.Text;
            addcurs.AddCurs(new CursModel(namc, namc, namc));
        }
    }
}