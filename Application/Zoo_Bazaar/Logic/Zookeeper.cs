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
        public AnimalRepository Repository { get; private set; }

        public Zookeeper(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city, jobname)
        {
            Repository = new AnimalRepository();
        }

        public void MakeActive()
        {
            Repository = new AnimalRepository();
        }

        public bool WriteAnimalNote(Animal selectedAnimal, string note)
        {
           if(Repository.ChangeAnimalNote(selectedAnimal.Id, note)) { return true; } else { return false; }
        }

        public bool ReportAnimalSick(Animal selectedAnimal, int sick)
        {
            if (Repository.ChangeAnimalSick(selectedAnimal.Id, sick)) { return true; } else { return false; }
        }
    }
}
