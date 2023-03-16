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
        public HR(string SpouseName, int SpousePhone, string EmergencyName, int EmergencyPhone, int BSN, int Contractstatus, string Image, int id, string firstName, string surName, string userName, string password, string email) : base(SpouseName, SpousePhone, EmergencyName, EmergencyPhone, BSN, Contractstatus, Image, id, firstName, surName, userName, password, email)
        {
            
        } 
        public void getAllEmployees()
        {
         //   EmployeeManagement.getallusers type of employee
        }
        public void AddEmployee()                             
        {

        }
        public void RemoveEmployee() 
        {
            
        }
        public void UpdateEmployee()
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
