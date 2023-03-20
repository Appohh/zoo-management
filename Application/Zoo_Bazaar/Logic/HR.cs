using DataCL;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class HR : Employee
    {
        private EmployeeRepository repository;
        public EmployeeRepository Repository { get; private set; }
        public HR(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city)
        {
            
        }  

        public void MakeActive()
        {
            repository = new EmployeeRepository();

        }

        public void RegisterNewEmployee()
        {

        }
        public void RemoveEmployee()
        {

        }
        public void ChangeEmployeeData()
        {

        }

        public void TerminateContract()
        {

        }



    }
}
