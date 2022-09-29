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
        public void InsertCursUser(CursUserModel cursUser)
        {
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT INTO relationship_curs_user 
                                VALUES(@pFk_curs,@pFk_users,@pFk_exercise)";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pFk_curs = new SqlParameter("@pFk_curs", cursUser.Fk_curs);
                SqlParameter pFk_users = new SqlParameter("@pFk_users", cursUser.Fk_users);
                SqlParameter pFk_exercise = new SqlParameter("@pFk_exercise", cursUser.Fk_exercise);

                //Añadir los parametros
                comand.Parameters.Add(pFk_curs);
                comand.Parameters.Add(pFk_users);
                comand.Parameters.Add(pFk_users);

                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Curso " + cursUser.Fk_curs + " -- " + cursUser.Fk_users + " creado");

            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR CURS-USER: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }
    }
}