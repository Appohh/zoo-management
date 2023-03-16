using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string BirthDate { get; set; }
        public string address { get; set; }
        public string City { get; set; }

        public User (int id, string firstName, string surName, string userName, string password, string email)
        {

        }


        public void login()
        {

        }
    }
}
