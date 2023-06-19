using DataCL.DataTraffic;
using DataCL.DTOs;
using LogicCL.AnimalMap;
using LogicCL.Users;
using Microsoft.VisualBasic.FileIO;
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
        private LocationDataTraffic locationDataTraffic = new LocationDataTraffic();
        private SpeciesDataTraffic speciesDataTraffic = new SpeciesDataTraffic();
        private TypeDataTraffic typeDataTraffic = new TypeDataTraffic();
        private DietDataTraffic dietDataTraffic = new DietDataTraffic();
        private GenderDataTraffic genderDataTraffic = new GenderDataTraffic();
        private FatherDataTraffic fatherDataTraffic = new FatherDataTraffic();
        private MotherDataTraffic motherDataTraffic = new MotherDataTraffic();
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
                Animal animal = new Animal(animalDto.Id, animalDto.Name, animalDto.Birthdate, animalDto.BirthPlace, animalDto.FatherId, animalDto.MotherId, animalDto.Location, animalDto.Diet, animalDto.Species, animalDto.Type, animalDto.Sick, animalDto.Notes, animalDto.Deathdate, animalDto.ImageUrl, animalDto.Gender);
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

        public bool updateAnimalDetails(int id, string name, string dob, string birthPlace, string fatherId, string motherId, int location, int diet, int type, int sick, string deathdate)
        {
            if (animalDataTraffic.UpdateAnimal(id, name, dob, birthPlace, fatherId, motherId, location, diet, type, sick, deathdate)) { refreshAnimalData(); return true; } else { return false; }
        }

        public List<Location> GetLocationList()
        {
            List<LocationDTO> locationDTOs = locationDataTraffic.retrieveLocation();
            List<Location> locations = new List<Location>();
            foreach (LocationDTO locationdto in locationDTOs)
            {
                locations.Add(new Location(locationdto.Id, locationdto.Name, locationdto.Count));
            }
            return locations;
        }

        public List<Species> GetSpeciesList()
        {
            List<SpeciesDTO> speciesDTOs = speciesDataTraffic.retrieveSpecies();
            List<Species> species = new List<Species>();
            foreach (SpeciesDTO speciesdto in speciesDTOs)
            {
                species.Add(new Species(speciesdto.Id, speciesdto.Name));
            }
            return species;
        }

        public List <Types> GetTypesList()
        {
            List<TypeDTO> typeDTOs = typeDataTraffic.retrieveTypes();
            List<Types> types = new List<Types>();
            foreach (TypeDTO typedto in typeDTOs)
            {
                types.Add(new Types(typedto.Id, typedto.Name, typedto.speciesId));
            }
            return types;
        }

        public List <Diet> GetDietList()
        {
            List<DietDTO> dietDTOs = dietDataTraffic.retrieveTypes();
            List<Diet> diet = new List<Diet>();
            foreach (DietDTO dietdto in dietDTOs)
            {
                diet.Add(new Diet(dietdto.Id, dietdto.Name));
            }
            return diet;
        }

        public List<Gender> GetGenderList()
        {
            List<GenderDTO> genderDTOs = genderDataTraffic.retrieveGender();
            List<Gender> gender = new List<Gender>();
            foreach (GenderDTO genderDTO in genderDTOs)
            {
                gender.Add(new Gender(genderDTO.Id, genderDTO.Name));
            }
            return gender;
        }
        public List<Animal> GetMaleAnimals()
        {
            return Animals.FindAll(animal => animal.gender == "Male");
        }
        public List<Animal> GetFemaleAnimals()
        {
            return Animals.FindAll(animal => animal.gender == "Female");
        }


    }
}
