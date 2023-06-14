using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Users
{
    public abstract class Employee : User
    {
        public string? SpouseName { get; set; }
        public string? SpousePhone { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyPhone { get; set; }
        public string BSN { get; set; }
        public int Contractstatus { get; set; } //needs custom set for name with if's
        public string Jobname { get; set; }

        public int Salary { get; set; }

        protected Employee(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname, int salary) : base(image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city)
        {
            SpouseName = spouseName;
            SpousePhone = spousePhone;
            EmergencyName = emergencyName;
            EmergencyPhone = emergencyPhone;
            BSN = bSN;
            Contractstatus = contractstatus;
            Jobname = jobname;
            Salary = salary;
        }
    }
}