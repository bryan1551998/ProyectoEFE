using ProyectoEFE.Conexion;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.DAL
{
    public class DALCurs
    {
        public int SelectUserCurs(string id_user)
        {
            int userCurs =0;
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT id_curs FROM CURS WHERE  autor_idUser='" + id_user+"'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    CursModel cursModel = new CursModel();
                    cursModel.Id_curs = (int)registros["id_curs"];
                    userCurs = cursModel.Id_curs;
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return userCurs;
        }
        public void ReletionCursUser(int idCurs, string idUser)
        {
            ConexionBD cnn = new ConexionBD();
            
            try
            {
                //String query
                String query = @"INSERT INTO relationship_curs_user VALUES
                               (@pfk_curs,
                                @pfk_user,
                                @pfk_exercise)"; 

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pFk_user = new SqlParameter("@pfk_user", idUser);
                SqlParameter pFk_curs = new SqlParameter("@pfk_curs", idCurs);
                SqlParameter pFk_exercise = new SqlParameter("@pfk_exercise", DBNull.Value);


                //Añadir los parametros
                comand.Parameters.Add(pFk_curs);
                comand.Parameters.Add(pFk_user);
                comand.Parameters.Add(pFk_exercise);


                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Relacion " + idCurs + "CON " + idUser + "Creada");

            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR RELACION " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

        public void InsertCurs(CursModel curs, string idUser)
        {

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT INTO curs VALUES
                               (@pName_curs,
                                @pDescription_curs, 
                                @pImage_curs,
                                @pAutor_name,
                                @pAutor_idUser)";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pName_curs = new SqlParameter("@pName_curs", curs.Name_curs);
                SqlParameter pDescription_curs = new SqlParameter("@pDescription_curs", curs.Description_curs);
                SqlParameter pImage_curs = new SqlParameter("@pImage_curs", curs.Image_url_curs);
                SqlParameter pAutor_name = new SqlParameter("@pAutor_name", curs.Autor_name);
                SqlParameter pAutor_idUser = new SqlParameter("@pAutor_idUser", idUser);

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
                Debug.WriteLine("ERROR INSERTAR CURS: " + exeption.Message +" --- "+ curs.Name_curs);
            }
            finally
            {
                cnn.CerrarConexion();
            }

        }


        public List<CursModel> SelectCurs()
        {
            List<CursModel> lisModels = new List<CursModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM CURS";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    CursModel cursModel = new CursModel();
                    cursModel.Id_curs = (int)registros["id_curs"];
                    cursModel.Name_curs = (String)registros["name_curs"];
                    cursModel.Description_curs = (String)registros["description_curs"];
                    cursModel.Image_url_curs = (String)registros["image_curs"];
                    cursModel.Autor_name = (String)registros["autor_name"];
                    cursModel.Autor_idUser = (String)registros["autor_idUser"];
                    lisModels.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisModels;
        }
        public List<CursModel> SelectCurs(string id_user)
        {
            List<CursModel> lisModels = new List<CursModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM curs WHERE autor_idUser='" + id_user + "'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    CursModel cursModel = new CursModel();
                    cursModel.Id_curs = (int)registros["id_curs"];
                    cursModel.Name_curs = (String)registros["name_curs"];
                    cursModel.Description_curs = (String)registros["description_curs"];
                    cursModel.Image_url_curs = (String)registros["image_curs"];
                    cursModel.Autor_name = (String)registros["autor_name"];
                    cursModel.Autor_idUser = (String)registros["autor_idUser"];
                    lisModels.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisModels;
        }

        public void EliminarCurs(int id_curs)
        {

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"DELETE FROM curs
                               WHERE id_curs = @pId_curs";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pId_curs = new SqlParameter("@pId_curs", id_curs);
                comand.Parameters.Add(pId_curs);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();
                Debug.WriteLine("Curso "+ id_curs + " eliminado");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR ELIMINAR CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }
        public List<CursModel> UserCurs(string id_user)
        {
            List<CursModel> lisModels = new List<CursModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT id_curs, name_curs, description_curs, image_curs, autor_name FROM curs c INNER JOIN relationship_curs_user r ON c.id_curs = r.fk_curs INNER JOIN AspNetUsers u ON u.id = r.fk_user WHERE id='"+ id_user+"'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    CursModel cursModel = new CursModel();
                    cursModel.Id_curs = (int)registros["id_curs"];
                    cursModel.Name_curs = (String)registros["name_curs"];
                    cursModel.Description_curs = (String)registros["description_curs"];
                    cursModel.Image_url_curs = (String)registros["image_curs"];
                    cursModel.Autor_name = (String)registros["autor_name"];
                    lisModels.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisModels;
        }

    }
}