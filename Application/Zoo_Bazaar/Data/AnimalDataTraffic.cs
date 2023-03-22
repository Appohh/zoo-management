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

namespace DataCL
{
    public class AnimalDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "SELECT Animals.id, Animals.name, [birthdate], [birthplace], [fatherId], [motherId], [Locations].[name] as 'location', [dietId] as 'diet', [Species].[name] as 'species', [sick], [notes], [deathdate], [type], [imageUrl] FROM [Animals] INNER JOIN Locations ON Animals.locationId = Locations.id INNER JOIN Diet ON Animals.dietId = Diet.id INNER JOIN Species ON Animals.speciesId = Species.id";
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

        public void addAnimal()
        {
            //string query = $"INSERT INTO `Task` (`Name`, `Description`, `StartDate`, `DueDate`, `Cycle`, `PersonId`) VALUES ('{name}', '{description}', '{startdate}', '{duedate}', '{cycle}', '{personid}');";
            //return executeQuery(query);
        }
        public bool UpdateAnimalSickAndNote(int animalId, int sick, string note)
        {
            string query = $"UPDATE Animals SET sick={sick}, notes='{note}' WHERE Id={animalId}";
            return executeQuery(query) == 0 ? false : true;
        }

    }
}
