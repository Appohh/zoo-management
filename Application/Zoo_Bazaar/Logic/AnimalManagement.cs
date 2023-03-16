using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AnimalManagement
    {
        private List<Animal> animals;

        private List<Animal> deadAnimals;

        private List<Animal> movedAnimals;

        public AnimalManagement()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public Animal[] GetAllAnimalList()
        {
            return animals.ToArray();
        }

        public void RemoveAnimal(int index)
        {
            animals.RemoveAt(index);
        }

        public void DeadAnimal(Animal animal)
        {
        }
    }
}