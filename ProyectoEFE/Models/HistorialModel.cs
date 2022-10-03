using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEFE.Models
{
    public class HistorialModel
    {
        //Atributos
        int id;
        String id_user;
        int id_exercise;
        int resultado;

        //GET and SET
        public int Id { get => id; set => id = value; }
        public string Id_user { get => id_user; set => id_user = value; }
        public int Id_exercise { get => id_exercise; set => id_exercise = value; }
        public int Resultado { get => resultado; set => resultado = value; }

        //Constructor
        public HistorialModel(int id, string id_user, int id_curs, int resultado)
        {
            Id = id;
            Id_user = id_user;
            Id_exercise = id_curs;
            Resultado = resultado;
        }

        public HistorialModel(string id_user, int id_curs, int resultado)
        {
            Id_user = id_user;
            Id_exercise = id_curs;
            Resultado = resultado;
        }

        public HistorialModel()
        {
        }
    }
}