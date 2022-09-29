using ProyectoEFE.Conexion;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.DAL
{
    public class DALTopics
    {
        public void InsertTopic(TopicsModel topics, int fk_curs)
        {

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT topics VALUES
                               (@pName_topic,
                                @pDescription_topic,
                                @pImage_topic,
                                @pFk_curs)";


                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pName_topic = new SqlParameter("@pName_topic", topics.Name_topic);
                SqlParameter pDescription_topic = new SqlParameter("@pDescription_topic", topics.Description_topic);
                SqlParameter pImage_topic = new SqlParameter("@pImage_topic", topics.Image_url_topic);
                SqlParameter pFk_curs = new SqlParameter("@pFk_curs", fk_curs);

                //Añadir los parametros
                comand.Parameters.Add(pFk_curs);
                comand.Parameters.Add(pImage_topic);
                comand.Parameters.Add(pName_topic);
                comand.Parameters.Add(pDescription_topic);

                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Tema " + topics.Name_topic + " creado");

            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR TEMAS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

        public List<TopicsModel> SelectTopics()
        {
            List<TopicsModel> lisTopics = new List<TopicsModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM topics";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    TopicsModel cursModel = new TopicsModel();
                    cursModel.Id_topic = (int)registros["id_topic"];
                    cursModel.Fk_curs = (int)registros["fk_curs"];
                    cursModel.Image_url_topic=(String)registros["image_topic"];
                    cursModel.Name_topic = (String)registros["name_topic"];
                    cursModel.Description_topic = (String)registros["description_topic"];
                    lisTopics.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT TEMAS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisTopics;
        }
        public List<TopicsModel> SelectTopics(string id_user)
        {
            List<TopicsModel> lisTopics = new List<TopicsModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM topics LEFT JOIN curs ON
                                topics.fk_curs = curs.id_curs 
                                WHERE autor_idUser='" + id_user+"'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    TopicsModel cursModel = new TopicsModel();
                    cursModel.Id_topic = (int)registros["id_topic"];
                    cursModel.Fk_curs = (int)registros["fk_curs"];
                    cursModel.Image_url_topic = (String)registros["image_topic"];
                    cursModel.Name_topic = (String)registros["name_topic"];
                    cursModel.Description_topic = (String)registros["description_topic"];
                    lisTopics.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT TEMAS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisTopics;
        }

        public void EliminarTopic(int id_topic)
        {

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"DELETE FROM topics
                               WHERE id_topic = @pId_topic";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pId_topic = new SqlParameter("@pId_topic", id_topic);
                comand.Parameters.Add(pId_topic);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();
                Debug.WriteLine("Tema " + id_topic + " eliminado");
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
    }
}