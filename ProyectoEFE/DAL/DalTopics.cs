using ProyectoEFE.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoEFE.DAL
{
    public class DalTopics
    {
        string strconx = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void AddTopic(TopicsModel topicsModel)
        {
            SqlConnection con = new SqlConnection(strconx);
            con.Open();

            string cadena = "insert into topics(name_topic, description_topic, image_topic)" +
                " values ('" + topicsModel.Name_topic + "'" +
                ",'" + topicsModel.Description_topic + "','" + topicsModel.Image_url_topic + "')";

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