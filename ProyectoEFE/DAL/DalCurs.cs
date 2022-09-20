using ProyectoEFE.Conexion;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.DAL
{
    public class DALCurs
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

        public List<CursModel> SelectCurs()
        {
            List<CursModel> lisModels = new List<CursModel>();
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT * FROM CURS";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    CursModel cursModel = new CursModel();
                    cursModel.Id_curs = (int)registros["id_curs"];
                    cursModel.Name_curs = (String)registros["name_curs"];
                    cursModel.Description_curs = (String)registros["description_curs"];
                    cursModel.Image_url_curs = (String)registros["image_curs"];
                    lisModels.Add(cursModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisModels;
        }

        public void EliminarCurs(int id_curs)
        {

            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"DELETE FROM curs
                               WHERE id_curs = @pId_curs";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pId_curs = new SqlParameter("@pId_curs", id_curs);
                comand.Parameters.Add(pId_curs);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();
                Debug.WriteLine("Curso "+ id_curs + " eliminado");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR ELIMINAR CURS: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

    }
}