using ProyectoEFE.Conexion;
using ProyectoEFE.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.DAL
{
    public class DALTopics
    {
        public void InsertCurs(CursModel curs)
        {

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"INSERT INTO curs VALUES
                               (@pName_curs,
                                @pDescription_curs, 
                                @pImage_curs)";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pName_curs = new SqlParameter("@pName_curs", curs.Name_curs);
                SqlParameter pDescription_curs = new SqlParameter("@pDescription_curs", curs.Description_curs);
                SqlParameter pImage_curs = new SqlParameter("@pImage_curs", curs.Image_url_curs);

                //Añadir los parametros
                comand.Parameters.Add(pName_curs);
                comand.Parameters.Add(pDescription_curs);
                comand.Parameters.Add(pImage_curs);

                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Curso " + curs.Name_curs + " creado");

            }
            catch (Exception exeption)
            {

                Debug.WriteLine("ERROR INSERTAR CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

        }
    }
}