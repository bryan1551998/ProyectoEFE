using ProyectoEFE.Conexion;
using ProyectoEFE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ProyectoEFE.DAL
{
    public class DALHistorial
    {

        public void InsertCurs(HistorialModel historial)
        {
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"insert into
                                historial_usuarios 
                                values (@pId_user,@pId_exercise,@pResult)";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pId_user = new SqlParameter("@pId_user", historial.Id_user);
                SqlParameter pId_exercise = new SqlParameter("@pId_exercise", historial.Id_exercise);
                SqlParameter pResult = new SqlParameter("@pResult", historial.Resultado);

                //Añadir los parametros
                comand.Parameters.Add(pId_user);
                comand.Parameters.Add(pId_exercise);
                comand.Parameters.Add(pResult);

                //Ejecutar query
                comand.ExecuteNonQuery();
                Debug.WriteLine("Hisorial del usuario insertado " + historial.Id_user + " creado");

            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERTAR Historial: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

        }

        public int SelectHistorail(string id_user, int id_curs)
        {
            int resultadoExercise = 0;
            ConexionBD cnn = new ConexionBD();

            try
            {
                //String query
                String query = @"SELECT resultado FROM historial_usuarios 
                                WHERE id_user='" + id_user + "' and id_exercise=" + id_curs;

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    HistorialModel historial = new HistorialModel();
                    historial.Resultado = (int)registros["resultado"];
                    resultadoExercise = historial.Resultado;
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT HISTORIAL: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return resultadoExercise;
        }


    }
}