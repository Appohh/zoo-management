using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LogicCL.Repository;
using static System.Net.Mime.MediaTypeNames;

namespace LogicCL.Users
{
    public class GroundsKeeper :Employee
    {
        public AnimalRepository Repository { get; private set; }
        public GroundsKeeper(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city, jobname)
        {
            Repository = new AnimalRepository();
        }

        public void MakeActive()
        {
            Repository = new AnimalRepository();
        }

    }
}
