using ProyectoEFE.Conexion;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ProyectoEFE.DAL
{
    public class DALCursoUser
    {
        public void InsertCursUser(String id_user, int curs) {


            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT INTO relationship_curs_user 
                                VALUES(@pFk_curs,@pFk_users,@pFk_exercise);
";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pFk_curs = new SqlParameter("@pFk_curs", );
                SqlParameter pFk_users = new SqlParameter("@pFk_users", curs.Description_curs);
                SqlParameter pFk_exercise = new SqlParameter("@pFk_exercise", curs.Image_url_curs);

                //Añadir los parametros
                comand.Parameters.Add(pName_curs);
                comand.Parameters.Add(pDescription_curs);
                comand.Parameters.Add(pImage_curs);
                comand.Parameters.Add(pAutor_name);
                comand.Parameters.Add(pAutor_idUser);

                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Curso " + curs.Name_curs + " creado");

            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR CURS: " + exeption.Message + " --- " + curs.Name_curs);
            }
            finally
            {
                cnn.CerrarConexion();
            }




        }

    }
}