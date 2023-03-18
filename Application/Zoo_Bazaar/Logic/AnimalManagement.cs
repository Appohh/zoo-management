using DataCL;
using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AnimalManagement
    {
        private AnimalDataTraffic AnimalDataTraffic = new AnimalDataTraffic();
        private List<Animal> animals;

        public AnimalManagement()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public List<AnimalDTO> GetAllAnimal()
        {
            List<AnimalDTO> animalDTOs = this.AnimalDataTraffic.getAnimals();
            return animalDTOs;
        }

        //savechanges()

    }
}