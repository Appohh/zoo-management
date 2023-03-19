using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Employee : User
    {
        public string? SpouseName { get; set; }
        public string? SpousePhone { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyPhone { get; set;}
        public string BSN { get; set; }
        public int Contractstatus { get; set; } //needs custom set for name with if's

        public Employee(string? SpouseName, int? SpousePhone, string EmergencyName, int EmergencyPhone, int BSN, int Contractstatus, string Image, int id, string firstName, string surName, string userName, string password, string email) :  base(Image, id, firstName, surName, userName, password, email)
        {

        }

        public abstract int Login();

    }
}
