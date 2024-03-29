﻿using DataCL.DTOs;
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

        public AnimalManagement(string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string bSN, int contractstatus, byte[] image, int id, string firstName, string lastname, string userName, string password, string email, string phone, string birthDate, string address, string city, string jobname, int salary, int workingHours) : base(spouseName, spousePhone, emergencyName, emergencyPhone, bSN, contractstatus, image, id, firstName, lastname, userName, password, email, phone, birthDate, address, city, jobname, salary, workingHours)
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

        public List<Species> GetSpeciesList()
        {
            return Repository.GetSpeciesList();
        }

        public List<Types> GetTypesList()
        {
            return Repository.GetTypesList();
        }

        public List<Types> GetTypesForSpecies(int speciesId)
        {
            List<Types> allTypes = Repository.GetTypesList();

            List<Types> typesForSpecies = allTypes.Where(type => type.speciesId == speciesId).ToList();

            return typesForSpecies;
        }

        public List<Animal> GetMaleAnimalsByType(string type, string selectedAnimalName)
        {
            List<Animal> allAnimals = Repository.GetAnimalList();

            List<Animal> maleAnimalsByType = allAnimals
            .Where(animal => animal.Type == type && animal.gender == "Male" && animal.Name != selectedAnimalName)
            .ToList();

            return maleAnimalsByType;
        }

        public List<Animal> GetFemaleAnimalsByType(string type, string selectedAnimalName)
        {
            List<Animal> allAnimals = Repository.GetAnimalList();

            List<Animal> femaleAnimalsByType = allAnimals
            .Where(animal => animal.Type == type && animal.gender == "Female" && animal.Name != selectedAnimalName)
            .ToList();

            return femaleAnimalsByType;
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