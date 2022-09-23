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

        public void InsertExercises(ExercisesModel exercise)
        {
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT exercises VALUES
                               (@pFk_lessons,
                                @pImage_exercise,
                                @pName_exercise,
                                @pDescription_exercise,
                                @pSolution_exercise)";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pFk_lessons = new SqlParameter("@pFk_lessons", exercise.Fk_lessons);
                SqlParameter pImage_exercise = new SqlParameter("@pImage_exercise", exercise.Image_exercise);
                SqlParameter pName_exercise = new SqlParameter("@pName_exercise", exercise.Name_exercise);
                SqlParameter pDescription_exercise = new SqlParameter("@pDescription_exercise", exercise.Description_exercise);
                SqlParameter pSolution_exercise = new SqlParameter("@pSolution_exercise", exercise.Solution_exercise);

                //Añadir los parametros
                comand.Parameters.Add(pFk_lessons);
                comand.Parameters.Add(pImage_exercise);
                comand.Parameters.Add(pName_exercise);
                comand.Parameters.Add(pDescription_exercise);
                comand.Parameters.Add(pSolution_exercise);

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
                String query = @"SELECT * FROM exercises;";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ExercisesModel cursModel = new ExercisesModel();
                    cursModel.Id_exercise = (int)registros["id_exercise"];
                    cursModel.Fk_lessons = (int)registros["fk_lessons"];
                    cursModel.Image_exercise = (String)registros["imagen_exercise"];
                    cursModel.Name_exercise = (String)registros["name_exercise"];
                    cursModel.Description_exercise = (String)registros["description_exercise"];
                    cursModel.Solution_exercise = (String)registros["description_exercise"];
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