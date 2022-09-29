using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEFE.Models
{
    public class CursUserModel
    {
        //Parametros
        int fk_curs;
        String fk_users;
        int? fk_exercise;

        //GET and SET
        public int Fk_curs { get => fk_curs; set => fk_curs = value; }
        public string Fk_users { get => fk_users; set => fk_users = value; }
        public int? Fk_exercise { get => fk_exercise; set => fk_exercise = value; }

        //Constructor
        public CursUserModel(int fk_curs, string fk_users, int? fk_exercise)
        {
            Fk_curs = fk_curs;
            Fk_users = fk_users;
            Fk_exercise = fk_exercise;
        }

        public CursUserModel(int fk_curs, string fk_users)
        {
            Fk_curs = fk_curs;
            Fk_users = fk_users;
        }

        public CursUserModel()
        {
        }
    }
}