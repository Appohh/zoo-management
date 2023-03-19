using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class Zookeeper : Employee
    {
        private AnimalManagement animalManagement;

        public Zookeeper(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus)
        {
            animalManagement = new AnimalManagement();
        }
    }
}
