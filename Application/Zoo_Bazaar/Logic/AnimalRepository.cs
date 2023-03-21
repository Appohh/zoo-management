using DataCL;
using DataCL.DTOs;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class AnimalRepository
    {
        private AnimalDataTraffic animalDataTraffic = new AnimalDataTraffic();
        private List<Animal> animals = new List<Animal>();

        public List<Animal> Animals { get { return animals; } }

        public AnimalRepository() 
        {
            refreshUserData();
        }
        private void refreshUserData()
        {
            List<AnimalDTO> animalDTOs = new List<AnimalDTO>();
            animalDTOs.AddRange(this.animalDataTraffic.retrieveAnimals());

            List<Animal> newAnimals = new List<Animal>();

            animals.Clear();
            //!!!!!!
            //still needs converting from DTO to userfriendly Animal class with selected fields

            foreach (AnimalDTO animalDto in animalDTOs)
            {
                    
                    Animal animal = new Animal(animalDto.Id, );
                    newUsers.Add(zookeeper);      
            }
            users.AddRange(newUsers);

        }

        public List<User> GetUserList([Optional] Type type, [Optional] List<Type> types)
        {
            //Returns list of users based on type, able to be provided with one type, a list of types or nothing
            List<User> filteredUsers = new List<User>();
            if (types != null)
            {

                filteredUsers.AddRange(Users.Where(user => types.Contains(user.GetType())));
                return filteredUsers;
            }

            if (type != null)
            {

                filteredUsers.AddRange(Users.Where(user => type == user.GetType()));
                return filteredUsers;
            }

            return filteredUsers;
        }


    }
}
