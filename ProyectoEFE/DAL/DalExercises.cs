using ProyectoEFE.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;


namespace ProyectoEFE.DAL
{
    public class DalExercises
    {
        string strconx = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void AddExercises(ExercisesModel exercisesModel)
        {
            SqlConnection con = new SqlConnection(strconx);
            con.Open();

            string cadena = "insert into exercises(name_exercise, description_exercise, solucion_exercise)" +
                " values ('" + exercisesModel.Name_exercise + "'" +
                ",'" + exercisesModel.Description_exercise + "','" + exercisesModel.Image_exercise + "')";

            try
            {
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }
    }
}