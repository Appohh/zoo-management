using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Employees : User
    {
        public string SpouseName { get; set; }
        public int SpousePhone { get; set; }
        public string EmergencyName { get; set; }
        public int EmergencyPhone { get; set;}
        public int BSN { get; set; }
        public int Contractstatus { get; set; }

        public Employees(string SpouseName, int SpousePhone, string EmergencyName, int EmergencyPhone, int BSN, int Contractstatus, string Image, int id, string firstName, string surName, string userName, string password, string email) :  base(Image, id, firstName, surName, userName, password, email)
        {

        }
    }
}
