using DataCL.DTOs;
using LogicCL.AnimalMap;
using LogicCL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Users
{
    public class AnimalManagement : Employee
    {
        public AnimalRepository Repository { get; private set; }

        public AnimalManagement(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, string image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city, jobname)
        {
            Repository = new AnimalRepository();
        }

        public void MakeActive()
        {
            Repository = new AnimalRepository();
        }

        public bool RegisterNewAnimal(AnimalDTO animalDTO)
        {
            return Repository.AddNewAnimal(animalDTO);
        }

        public List<Location> GetLocationList()
        {
            return Repository.GetLocationList();
        }

        public List <Species> GetSpeciesList()
        {
            return Repository.GetSpeciesList();
        }

        public List <Types> GetTypesList()
        {
            return Repository.GetTypesList();
        }
       
        public List<Types> GetTypesForSpecies(int speciesId)
        {
            // Get all types from the database
            List<Types> allTypes = Repository.GetTypesList();

            // Filter the types to only include those for the specified species ID
            List<Types> typesForSpecies = allTypes.Where(type => type.speciesId == speciesId).ToList();

            return typesForSpecies;
        }

        public List<Diet> GetDietList()
        {
            return Repository.GetDietList();
        }

        public List<Gender> GetGenderList()
        {
            return Repository.GetGenderList();
        }
        public List<Animal> GetMales()
        {
            return Repository.GetMaleAnimals();
        }
        public List<Animal> GetFemales()
        {
            return Repository.GetFemaleAnimals();
        }
    }
}
