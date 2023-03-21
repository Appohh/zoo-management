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

        public Zookeeper(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city)
        {
            Repository = new AnimalRepository();
        }

        public void MakeActive()
        {
            Repository = new AnimalRepository();
        }

        public bool WriteAnimalNote(Animal selectedAnimal)
        {
           // Animal animal = Repository.GetAnimalList().Find(animal => selectedAnimal == animal);
           throw new NotImplementedException();
        }

        public void ReportAnimalSick()
        {
            Repository = new AnimalRepository();
        }
    }
}
