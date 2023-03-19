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
        public HR(string SpouseName, int SpousePhone, string EmergencyName, int EmergencyPhone, int BSN, int Contractstatus, string Image, int id, string firstName, string surName, string userName, string password, string email) : base(SpouseName, SpousePhone, EmergencyName, EmergencyPhone, BSN, Contractstatus, Image, id, firstName, surName, userName, password, email)
        {
            userManagement = new UserManagement();
        }

        public override int Login()
        {
            //Oskar
            //Login -> validate -> return 0/1
            throw new NotImplementedException();
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
