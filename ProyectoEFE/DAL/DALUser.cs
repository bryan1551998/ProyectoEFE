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
    public class DALUser
    {
        public List<UserModel> SelectUser(string email)
        {
            ConexionBD cnn = new ConexionBD();
            List<UserModel> lisModels = new List<UserModel>();

            try
            {
                //String query
                String query = @"SELECT FirstName, LastName, BirthDay, NickName FROM AspNetUsers WHERE Email='" + email + "'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    UserModel userModel = new UserModel();
                    userModel.FirstName1 = (String)registros["FirstName"];
                    userModel.LastName1 = (String)registros["LastName"];
                    userModel.BirthDay1 = (DateTime)registros["BirthDay"];
                    userModel.NickName1 = (String)registros["NickName"];
                   // userModel.ProfilePicture1 = (String)registros["ProfilePicture"];
                    lisModels.Add(userModel);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT USER: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }

            return lisModels;
            }
    }
}