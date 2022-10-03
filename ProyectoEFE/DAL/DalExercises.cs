using ProyectoEFE.Conexion;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.DAL
{
    public class DALExercises
    {

        public void InsertExercises(ExercisesModel exercise, int fk_lesson)
        {
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT exercises VALUES
                               (@pName_exercise,
                                @pDescription_exercise,
                                @pEjemplo_exercise,
                                @pSolution_exercise,
                                @pN_exercise,
                                @pFk_topic)";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pFk_lessons = new SqlParameter("@pFk_topic", fk_lesson);
                SqlParameter pName_exercise = new SqlParameter("@pName_exercise", exercise.Name_exercise);
                SqlParameter pDescription_exercise = new SqlParameter("@pDescription_exercise", exercise.Description_exercise);
                SqlParameter pEjemplo_exercise = new SqlParameter("@pEjemplo_exercise", exercise.Ejemplo_exercise);
                SqlParameter pSolution_exercise = new SqlParameter("@pSolution_exercise", exercise.Solution_exercise);
                SqlParameter pN_exercise = new SqlParameter("@pN_exercise", exercise.Number_exercise);

                //Añadir los parametros
                comand.Parameters.Add(pFk_lessons);
                comand.Parameters.Add(pName_exercise);
                comand.Parameters.Add(pDescription_exercise);
                comand.Parameters.Add(pEjemplo_exercise);
                comand.Parameters.Add(pSolution_exercise);
                comand.Parameters.Add(pN_exercise);

                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Exercicio " + exercise.Name_exercise + " creado");

            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR EJERCICIO: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

        public List<ExercisesModel> SelectExercises()
        {
            List<ExercisesModel> lisExercise = new List<ExercisesModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM exercises";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ExercisesModel cursModel = new ExercisesModel();
                    cursModel.Id_exercise = (int)registros["id_exercise"];
                    cursModel.Fk_topic = (int)registros["fk_topic"];
                    cursModel.Name_exercise = (String)registros["name_exercise"];
                    cursModel.Description_exercise = (String)registros["description_exercise"];
                    cursModel.Solution_exercise = (String)registros["solution_exercise"];
                    cursModel.Ejemplo_exercise = (String)registros["ejemplo_exercise"];
                    lisExercise.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT EJERCICIOS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisExercise;
        }

        public List<ExercisesModel> SelectExercisesId(int id_topic)
        {
            List<ExercisesModel> lisExercise = new List<ExercisesModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM exercises where fk_topic=" + id_topic;

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ExercisesModel cursModel = new ExercisesModel();
                    cursModel.Id_exercise = (int)registros["id_exercise"];
                    cursModel.Fk_topic = (int)registros["fk_topic"];
                    cursModel.Name_exercise = (String)registros["name_exercise"];
                    cursModel.Description_exercise = (String)registros["description_exercise"];
                    cursModel.Solution_exercise = (String)registros["solution_exercise"];
                    cursModel.Ejemplo_exercise = (String)registros["ejemplo_exercise"];
                    cursModel.Number_exercise = (int)registros["n_exercise"];
                    lisExercise.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT EJERCICIOS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisExercise;
        }

        public List<ExercisesModel> SelectExercisesIdexercise(int id_topic)
        {
            List<ExercisesModel> lisExercise = new List<ExercisesModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM exercises where id_exercise=" + id_topic;

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ExercisesModel cursModel = new ExercisesModel();
                    cursModel.Id_exercise = (int)registros["id_exercise"];
                    cursModel.Fk_topic = (int)registros["fk_topic"];
                    cursModel.Name_exercise = (String)registros["name_exercise"];
                    cursModel.Description_exercise = (String)registros["description_exercise"];
                    cursModel.Solution_exercise = (String)registros["solution_exercise"];
                    cursModel.Ejemplo_exercise = (String)registros["ejemplo_exercise"];
                    lisExercise.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT EJERCICIOS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisExercise;
        }

        public List<ExercisesModel> SelectExercises(string id_user)
        {
            List<ExercisesModel> lisExercise = new List<ExercisesModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT *
                                FROM exercises
                                LEFT JOIN topics
                                on exercises.fk_topic = topics.id_topic
                                LEFT JOIN curs
                                on topics.fk_curs = curs.id_curs
                                WHERE autor_idUser='" + id_user + "'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ExercisesModel cursModel = new ExercisesModel();
                    cursModel.Id_exercise = (int)registros["id_exercise"];
                    cursModel.Fk_topic = (int)registros["fk_topic"];
                    cursModel.Name_exercise = (String)registros["name_exercise"];
                    cursModel.Description_exercise = (String)registros["description_exercise"];
                    cursModel.Solution_exercise = (String)registros["solution_exercise"];
                    cursModel.Number_exercise = (int)registros["n_exercise"];
                    cursModel.Ejemplo_exercise = (String)registros["ejemplo_exercise"];
                    lisExercise.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT EJERCICIOS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisExercise;
        }

        public void EliminareExercise(int id_exercise)
        {
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"DELETE FROM exercises
                               WHERE id_exercise = @pId_exercises";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pId_exercises = new SqlParameter("@pId_exercises", id_exercise);
                comand.Parameters.Add(pId_exercises);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();
                Debug.WriteLine("Ejercicio " + id_exercise + " eliminado");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR ELIMINAR EJERCICIO: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }
    }
}