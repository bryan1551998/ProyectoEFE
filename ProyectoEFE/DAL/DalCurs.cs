using ProyectoEFE.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;


namespace ProyectoEFE.DAL
{
    public class DalCurs
    {
        string strconx = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public void AddCurs(CursModel cursm)
        {
            SqlConnection con = new SqlConnection(strconx);
            con.Open();

            string cadena = "insert into curs(name_curs, description_curs, image_curs)" +
                " values ('" + cursm.Name_curs + "'" +
                ",'" + cursm.Description_curs + "','" + cursm.Image_url_curs + "')";

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