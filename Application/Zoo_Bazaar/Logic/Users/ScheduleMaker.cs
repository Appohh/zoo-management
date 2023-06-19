using LogicCL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Users
{
    public class ScheduleMaker : Employee
    {
        public EmployeeRepository Repository { get; private set; }

        public ScheduleMaker(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname, int salary, int workingHours) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city, jobname, salary, workingHours)
        {
        }

        public void MakeActive()
        {
            Repository = new EmployeeRepository();
        }
    }
}