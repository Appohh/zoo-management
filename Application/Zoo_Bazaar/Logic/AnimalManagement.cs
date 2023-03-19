using DataCL;
using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AnimalManagement
    {
        private AnimalDataTraffic animalDataTraffic = new AnimalDataTraffic();
        private List<Animal> animals = new List<Animal>();

        public AnimalManagement()
        {
            refreshAnimalData();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void refreshAnimalData()
        {
            animals.Clear();
            //!!!!!!
            //still needs converting from DTO to userfriendly Animal class with selected fields


            this.animalDataTraffic.retrieveAnimals();
        }

        public List<Animal> getAnimalList([Optional] Type type, [Optional] List<Type> types)
        {
            //Returns list of animals based on type, able to be provided with one type, a list of types or nothing

            if (types != null)
            {
                List<Animal> filteredAnimals = new List<Animal>();
                filteredAnimals.AddRange(animals.Where(animal => types.Contains(animal.GetType())));
                return filteredAnimals;
            }

            if (type != null)
            {
                List<Animal> filteredAnimals = new List<Animal>();
                filteredAnimals.AddRange(animals.Where(animal => type == animal.GetType()));
                return filteredAnimals;
            }

            return animals;
        }


    }
}