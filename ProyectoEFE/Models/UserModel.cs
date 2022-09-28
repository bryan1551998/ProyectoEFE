using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEFE.Models
{
    public class UserModel
    {
        //Atributos
        string id_user;
        string nickname;
        string firstname;
        string lastname;
        string profilepicture;
        string role;
        string email;
        DateTime birtday;

        //Get and Set
        public string NickName { get => nickname; set => nickname = value; }
        public string FirstName { get => firstname; set => firstname = value; }
        public string LastName { get => lastname; set => lastname = value; }
        public DateTime BirthDay { get => birtday; set => birtday = value; }
        public string ProfilePicture { get => profilepicture; set => profilepicture = value; }
        public string Id_user { get => id_user; set => id_user = value; }
        public string Role { get => role; set => role = value; }
        public string Email { get => email; set => email = value; }

        //Constructors
        public UserModel(string nickName, string firstName, string lastName, DateTime birthDay, string profilePicture, string id_user, string role, string email)
        {
            this.nickname = nickName;
            this.firstname = firstName;
            this.lastname = lastName;
            this.birtday = birthDay;
            this.profilepicture = profilePicture;
            this.id_user = id_user;
            this.role = role;
            this.email = email;
        }
        public UserModel(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public UserModel()
        {
        }
    }
}