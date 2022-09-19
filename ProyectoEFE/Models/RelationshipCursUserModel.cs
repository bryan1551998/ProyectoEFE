using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEFE.Models
{
    public class RelationshipCursUserModel
    {
        //Atributos
        int fk_curs;
        String fk_id;

        //Set and Get
        public int Fk_curs { get => fk_curs; set => fk_curs = value; }
        public string Fk_id { get => fk_id; set => fk_id = value; }

        //Constructor
        public RelationshipCursUserModel(int fk_curs, string fk_id)
        {
            this.Fk_curs = fk_curs;
            this.Fk_id = fk_id;
        }
    }
}