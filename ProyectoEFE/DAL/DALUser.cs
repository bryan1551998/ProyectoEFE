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
        public string NameUser(string id_user)
        {
            ConexionBD cnn = new ConexionBD();
            string completename ="";
            try
            {
                //String query
                String query = @"SELECT firstname, lastname FROM AspNetUsers WHERE id='" + id_user + "'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    UserModel userModel = new UserModel();
                    userModel.FirstName = (String)registros["firstname"];
                    userModel.LastName = (String)registros["lastname"];
                    completename = userModel.FirstName + " " + userModel.LastName;
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

            return completename;
        }

        public List<UserModel> SelectUser(string id_user)
        {
            ConexionBD cnn = new ConexionBD();
            List<UserModel> lisModels = new List<UserModel>();

            try
            {
                //String query
                String query = @"SELECT FirstName, LastName, BirthDay, NickName, ProfilePicture, Role FROM AspNetUsers WHERE Id='" + id_user + "'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    UserModel userModel = new UserModel();
                    userModel.FirstName = (String)registros["FirstName"];
                    userModel.LastName = (String)registros["LastName"];
                    userModel.BirthDay = (DateTime)registros["BirthDay"];
                    userModel.NickName = (String)registros["NickName"];
                    userModel.ProfilePicture = (String)registros["ProfilePicture"];
                    userModel.Role = (String)registros["Role"];
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