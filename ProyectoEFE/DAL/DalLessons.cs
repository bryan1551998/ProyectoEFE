using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.Conexion
{
    public class DALLessons
    {

        public void InsertLesson(LessonsModel lesson)
        {
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT lessons VALUES
                               (@pFk_lessons,
                                @pImage_lessons,
                                @pName_lessons,
                                @pDescription_lessons)";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pFk_lessons = new SqlParameter("@pFk_lessons", lesson.Fk_topic);
                SqlParameter pImage_lessons = new SqlParameter("@pImage_lessons", lesson.Image_url_lesson);
                SqlParameter pName_lessons = new SqlParameter("@pName_lessons", lesson.Name_lesson);
                SqlParameter pDescription_lessons = new SqlParameter("@pDescription_lessons", lesson.Description_lesson);

                //Añadir los parametros
                comand.Parameters.Add(pFk_lessons);
                comand.Parameters.Add(pImage_lessons);
                comand.Parameters.Add(pName_lessons);
                comand.Parameters.Add(pDescription_lessons);

                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Curso " + lesson.Name_lesson + " creado");

            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR LESIONES: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

        public List<LessonsModel> SelectLessons()
        {
            List<LessonsModel> listLessons = new List<LessonsModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM lessons";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    LessonsModel cursModel = new LessonsModel();
                    cursModel.Id_lessons = (int)registros["id_lessons"];
                    cursModel.Fk_topic = (int)registros["fk_topic"];
                    cursModel.Image_url_lesson=(String)registros["image_lesson"];
                    cursModel.Name_lesson = (String)registros["name_lesson"];
                    cursModel.Description_lesson = (String)registros["description_lesson"];
                    listLessons.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT LESIONES: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return listLessons;
        }

        public void EliminarLessons(int id_lessons)
        {

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"DELETE FROM lessons
                               WHERE id_lessons = @pId_lessons";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pId_lessons = new SqlParameter("@pId_lessons", id_lessons);
                comand.Parameters.Add(pId_lessons);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();
                Debug.WriteLine("Lesión " + id_lessons + " eliminada");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR ELIMINAR LESION: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

    }
}