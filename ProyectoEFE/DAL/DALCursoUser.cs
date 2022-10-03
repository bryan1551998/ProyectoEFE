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
        public string InsertCursUser(CursUserModel cursUser)
        {
            //Result mensaje
            string result = "Gracias por suscribirte";

            //Conexiones BD
            ConexionBD cnnselect = new ConexionBD();
            ConexionBD cnn = new ConexionBD();
            try
            {

                //String query
                String querySelect = @"select * from relationship_curs_user 
                                       where fk_curs=@pFk_cursSelect and fk_user=@pFk_usersSelect";

                //Conexion creada
                SqlCommand comandSelect = new SqlCommand(querySelect, cnnselect.Connection);

                //Parametros de la query
                SqlParameter pFk_cursSelect = new SqlParameter("@pFk_cursSelect", cursUser.Fk_curs);
                SqlParameter pFk_usersSelect = new SqlParameter("@pFk_usersSelect", cursUser.Fk_users);

                //Añadir parametros
                comandSelect.Parameters.Add(pFk_cursSelect);
                comandSelect.Parameters.Add(pFk_usersSelect);

                //Ejecutar query
                SqlDataReader registros = comandSelect.ExecuteReader();

                //Obtener lo datos

                if (registros.Read() == false)
                {

                    //String query
                    String query = @"INSERT  INTO  relationship_curs_user (fk_curs,fk_user)
                                    VALUES(@pFk_curs,@pFk_users)";

                    //Conexion creada
                    SqlCommand comand = new SqlCommand(query, cnn.Connection);

                    //Parametros de la query
                    SqlParameter pFk_curs = new SqlParameter("@pFk_curs", cursUser.Fk_curs);
                    SqlParameter pFk_users = new SqlParameter("@pFk_users", cursUser.Fk_users);

                    //Añadir los parametros
                    comand.Parameters.Add(pFk_users);
                    comand.Parameters.Add(pFk_curs);

                    //Ejecutar query
                    comand.ExecuteNonQuery();
                    Debug.WriteLine("Curso " + cursUser.Fk_curs + " -- " + cursUser.Fk_users + " creado");
                }
                else
                {
                    result = "Ya estas suscrito a este curso";
                    Debug.WriteLine("Ya estas suscrito");
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR CURS-USER: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
                cnnselect.CerrarConexion();
            }
            return result;
        }

        public object GestionarNulos(object valOriginal)
        {
            if (valOriginal == System.DBNull.Value)
                return null;
            else
                return valOriginal;
        }
    }
}