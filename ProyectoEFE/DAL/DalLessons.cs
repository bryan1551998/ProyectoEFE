using ProyectoEFE.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;


namespace ProyectoEFE.DAL
{
    public class DalLessons
    {
        string strconx = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void AddLesson(LessonsModel lessonsModel)
        {
            SqlConnection con = new SqlConnection(strconx);
            con.Open();

            string cadena = "insert into lessons(name_lesson, description_lesson, image_lesson)" +
                " values ('" + lessonsModel.Name_lesson + "'" +
                ",'" + lessonsModel.Description_lesson + "','" + lessonsModel.Image_url_lesson + "')";

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