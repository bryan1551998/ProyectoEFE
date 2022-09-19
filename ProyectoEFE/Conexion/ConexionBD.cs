using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoEFE.Conexion
{
    public class ConexionBD
    {
        //Atributos
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        SqlConnection connection;

        //GET and SET
        public SqlConnection Connection { get => connection; set => connection = value; }

        //Constructor
        public ConexionBD()
        {
            //Parametros de la BD
            builder.DataSource = "46.183.116.173,54321";
            builder.InitialCatalog = "ProyectoEFE";
            builder.UserID = "GrupoEfe";
            builder.Password = "dhy7ekng08thk23";

            try
            {
                //Crear conexion
                this.Connection = new SqlConnection(builder.ConnectionString);
                this.Connection.Open();
                Debug.WriteLine("Conexion creada");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR: "+exeption.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                //Cerrar sesion
                this.Connection.Close();
                Debug.WriteLine("Conexion cerrada");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine(exeption.Message);
            }
        }
    }
}