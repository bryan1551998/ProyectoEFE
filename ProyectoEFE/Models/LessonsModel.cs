using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEFE.Models
{
    public class LessonsModel
    {
        string name_curs;
        string description_curs;
        string image_url_curs;
        public LessonsModel(string nc, string dc, string iuc)
        {
            name_curs = nc;
            description_curs = dc;
            image_url_curs = iuc;
        }

    }
}