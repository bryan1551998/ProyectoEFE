using ProyectoEFE.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.Conexion
{
    public class DALLessons
    {

        public LessonsModel Insert_Lesson(LessonsModel leson)
        {
            ConexionBD cnn = new ConexionBD();

            try { 
            
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR INSERT LessonsModel: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
            return null;
        }

    }
}