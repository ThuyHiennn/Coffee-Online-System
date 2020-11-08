using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace CoffeeOnlineSystem.Models
{
    public class customers
    {
        int idUser;
        string nameUser;
        string phone;
        string email;
        string username;
        string password;
        string gender;
        string dob;
        string idRole;

        public int IdUser { get => idUser; set => idUser = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }
        public string IdRole { get => idRole; set => idRole = value; }

        public customers(int idUser, string nameUser, string phone, string email, string username, string password, string gender, string dob, string idRole)
        {
            this.IdUser = idUser;
            this.NameUser = nameUser;
            this.Phone = phone;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Gender = gender;
            this.Dob = dob;
            this.IdRole = idRole;
        }

        public customers()
        {
        }


    }
}