using DataCL.DataTraffic;
using DataCL.DTOs;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Repository
{
    public class AnimalRepository
    {
        private AnimalDataTraffic animalDataTraffic = new AnimalDataTraffic();
        private List<Animal> animals = new List<Animal>();

        public List<Animal> Animals { get { return animals; } }

        public AnimalRepository()
        {
            refreshAnimalData();
        }

        private void refreshAnimalData()
        {
            List<AnimalDTO> animalDTOs = new List<AnimalDTO>();
            animalDTOs.AddRange(animalDataTraffic.retrieveAnimals());

            List<Animal> newAnimals = new List<Animal>();
            //list<diets> diets; 


            animals.Clear();
            //!!!!!!
            //still needs converting from DTO to userfriendly Animal class with selected fields
            foreach (AnimalDTO animalDto in animalDTOs)
            {

                //Diet dietOfThisAnimal = animals.where(diet => animal.dietid = dietId)
                Animal animal = new Animal(animalDto.Id, animalDto.Name, animalDto.Birthdate, animalDto.BirthPlace, animalDto.FatherId, animalDto.MotherId, animalDto.Location, animalDto.Diet, animalDto.Species, animalDto.Type, animalDto.Sick, animalDto.Notes, animalDto.Deathdate, animalDto.ImageUrl);
                newAnimals.Add(animal);
            }
            animals.AddRange(newAnimals);

        }

        public List<Animal> GetAnimalList([Optional] Type type, [Optional] List<Type> types)
        {
            //Returns list of animals based on type, able to be provided with one type, a list of types or nothing
            List<Animal> filteredAnimals = new List<Animal>();
            if (types != null)
            {

                filteredAnimals.AddRange(Animals.Where(animal => types.Contains(animal.GetType())));
                return filteredAnimals;
            }

            if (type != null)
            {

                filteredAnimals.AddRange(Animals.Where(animal => type == animal.GetType()));
                return filteredAnimals;
            }

            return Animals;
        }

        public bool ChangeAnimalSickAndNote(int id, int sick, [Optional] string note)
        {
            if (animalDataTraffic.UpdateAnimalSickAndNote(id, sick, note)) { refreshAnimalData(); return true; } else { return false; }
        }

        public bool AddNewAnimal(AnimalDTO animalDTO)
        {
            if (animalDataTraffic.addAnimal(animalDTO))
            {
                refreshAnimalData();
                return true;
            };
            return false;
        }

        public bool updateAnimalDetails(int id, string name, string dob, string birthPlace, int fatherId, int motherId, string location, string diet, string species, string type, int sick, string deathdate)
        {
            if (animalDataTraffic.UpdateAnimal(id, name, dob, birthPlace, fatherId, motherId, location, diet, species, type, sick, deathdate)) { refreshAnimalData(); return true; } else { return false; }
        }


      
    }
}
