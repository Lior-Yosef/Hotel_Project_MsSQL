using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Project_MsSQL.Models
{
    public class CEO
    {
        public int Id;
        public string FullName;
        public int Age;
        public string Email;
        public int Salry;

        public CEO(int id, string fullName, int age, string email, int salry)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Age = age;
            this.Email = email;
            this.Salry = salry;
        }
    }
}