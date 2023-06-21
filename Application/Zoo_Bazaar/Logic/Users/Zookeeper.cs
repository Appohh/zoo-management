using LogicCL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicCL.AnimalMap;

namespace LogicCL.Users
{
    public class Zookeeper : Employee
    {
        public AnimalRepository Repository { get; private set; }

        public Zookeeper(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, byte[] image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname, int salary, int workingHours) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city, jobname, salary, workingHours)
        {
            Repository = new AnimalRepository();
        }

        public void MakeActive()
        {
            Repository = new AnimalRepository();
        }

        public bool UpdateAnimal(Animal selectedAnimal, int sick, string note)
        {
            if (Repository.ChangeAnimalSickAndNote(selectedAnimal.Id, sick, note)) { return true; } else { return false; }
        }

        //lists
        public List<Species> GetSpeciesList()
        {
            return Repository.GetSpeciesList();
        }

        public List<Types> GetTypesList()
        {
            return Repository.GetTypesList();
        }

        //filter CB
        public List<Types> GetTypesForSpecies(int speciesId)
        {
            List<Types> allTypes = Repository.GetTypesList();

            List<Types> typesForSpecies = allTypes.Where(type => type.speciesId == speciesId).ToList();

            return typesForSpecies;
        }
    }
}