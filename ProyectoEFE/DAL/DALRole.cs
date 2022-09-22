using ProyectoEFE.Conexion;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.DAL
{
    public class DALRole
    {
        public string ReadRol(string email)
        {
            string userRole ="";

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                string role = "SELECT Role FROM AspNetUsers WHERE Email='" + email + "'";
                //Conexion creada
                SqlCommand command = new SqlCommand(role, cnn.Connection);
                //Read Rol
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    userRole += reader["Role"].ToString();
                }

            }
            catch (Exception exeption)
            {

                Debug.WriteLine("ERROR ROL: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
            return userRole;
        }
    }
}
