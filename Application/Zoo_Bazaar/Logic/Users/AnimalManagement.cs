using DataCL.DTOs;
using LogicCL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Users
{
    public class AnimalManagement
    {
        public AnimalRepository Repository { get; private set; }


        public void MakeActive()
        {
            Repository = new AnimalRepository();
        }

        public bool RegisterNewAnimal(AnimalDTO animalDTO)
        {
            return Repository.AddNewAnimal(animalDTO);
        }
    }
}
