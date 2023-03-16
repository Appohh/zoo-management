using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class HR : Employees
    {
        public HR(string SpouseName, int SpousePhone, string EmergencyName, int EmergencyPhone, int BSN, int Contractstatus, int id, string firstName, string surName, string userName, string password, string email) : base(SpouseName, SpousePhone, EmergencyName, EmergencyPhone, BSN, Contractstatus, id, firstName, surName, userName, password, email)
        {
            
        }

        
    }
}
