using DataCL.DTOs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataCL.DataTraffic
{
    public class AnimalDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            { 
                return "SELECT Animals.id, Animals.name, [birthdate], [birthplace], [fatherId], [motherId], Locations.name AS location, Locations.id AS locationId, Diet.name AS diet, Diet.id AS dietId, Species.name AS species, Species.id AS speciesId, Type.name AS type, Type.id AS typeId, [sick], [notes], [deathdate], [imageUrl] FROM Animals INNER JOIN Locations ON Animals.locationId = Locations.id INNER JOIN Diet ON Animals.dietId = Diet.id INNER JOIN Type ON Animals.typeId = Type.id INNER JOIN Species ON Species.id = Type.speciesId";
            }
        }

        public List<AnimalDTO> retrieveAnimals()
        {
            List<AnimalDTO> Animals = new List<AnimalDTO>();

            //get datatable of queried data
            DataTable table = base.ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                Animals.Add(DataConvertingMethods.ConvertDataRowToObject<AnimalDTO>(dr));
            }

            //return collection of DTOs
            return Animals;
        }

        public bool addAnimal(AnimalDTO animal)
        {
            string query = $"INSERT INTO Animals (name, birthdate, birthplace, fatherId, motherId, locationId, dietId, sick, notes, deathdate, type, imageUrl) "+
            $"VALUES({animal.Name}, {animal.Birthdate}, {animal.BirthPlace}, {animal.FatherId}, {animal.MotherId}, {animal.Location}, {animal.Diet}, {animal.Sick}, {animal.Notes}, {animal.Deathdate}, {animal.Type}, {animal.ImageUrl})";
            return executeQuery(query) == 0 ? false : true;
        }

        public bool UpdateAnimalSickAndNote(int animalId, int sick, string note)
        {
            string query = $"UPDATE Animals SET sick={sick}, notes='{note}' WHERE Id={animalId}";
            return executeQuery(query) == 0 ? false : true;
        }

        public bool UpdateAnimal(int id, string name, string dob, string birthPlace, int fatherId, int motherId, int location, int diet, int type, int sick, string deathdate)
        {
            string query = $"UPDATE Animals SET name='{name}', birthdate={dob}, birthplace='{birthPlace}', fatherId={fatherId}, motherId={motherId}, locationId={location}, dietId={diet}, sick={sick}, deathdate={deathdate}, typeId={type} WHERE id={id}";
            return executeQuery(query) == 0 ? false : true;

        }
    }
}