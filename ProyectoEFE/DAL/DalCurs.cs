using ProyectoEFE.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoEFE.DAL
{
    public class DalCurs
    {
      string strconx = ConfigurationManager.ConnectionStrings["con"].ConnectionString ;
        public void AddCurs(CursModel cursm)
        {
            SqlConnection con = new SqlConnection(strconx);
            con.Open();

            string cadena = "insert into curs(name_curs, description_curs, icon)" +
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

        internal void AddCurs()
        {
            throw new NotImplementedException();
        }
    }