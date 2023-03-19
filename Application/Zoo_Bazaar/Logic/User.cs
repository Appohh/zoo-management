using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class User
    {
        //needs to be redone and must match database names and order
        public string Image { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BirthDate { get; set; }
        public string address { get; set; }
        public string City { get; set; }

        protected User(string image, int id, string firstName, string lastName, string userName, string password, string email, string phone, string birthDate, string address, string city)
        {
            Image = image;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
            this.address = address;
            City = city;
        }
    }
}
