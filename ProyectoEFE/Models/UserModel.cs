using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEFE.Models
{
    public class UserModel
    {
        //Atributos
        string NickName;
        string FirstName;
        string LastName;
        string ProfilePicture;
        DateTime BirthDay;

        //Get and Set
        public string NickName1 { get => NickName; set => NickName = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public DateTime BirthDay1 { get => BirthDay; set => BirthDay = value; }
        public string ProfilePicture1 { get => ProfilePicture; set => ProfilePicture = value; }

        //Constructors
        public UserModel(string nickName, string firstName, string lastName, DateTime birthDay, string profilePicture)
        {
            this.NickName = nickName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
            this.ProfilePicture = profilePicture;
        }
        public UserModel()
        {

        }
    }
}