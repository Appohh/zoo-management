using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class HR : Employee
    {
        private UserManagement userManagement = new UserManagement();

        public HR(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city)
        {
            
        }

        public List<User> getAllEmployees()
        {
            //type of employee doesnt work ^A
            return userManagement.getUserList(typeof(Employee));
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
        public void ExtendContract()
        {

        }
        public void TerminateContract()
        {

        }


    }
}
