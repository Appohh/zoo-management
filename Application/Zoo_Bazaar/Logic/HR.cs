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
        private UserManagement userManagement;

        public HR(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus)
        {
            userManagement = new UserManagement();
        }

        public List<User> getAllEmployees()
        {
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
