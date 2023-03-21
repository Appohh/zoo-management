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
                return "select * from Animals";
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
        public void AnimalSickStatus(AnimalDTO animal, int sick)
        {
            string query = $"UPDATE Animal SET Sick={sick} WHERE Id={animal.Id}";
            //return executeQuery(query);
        }

        public void SetAnimalNote(AnimalDTO animal, string note)
        {
            string query = $"UPDATE Animal SET Notes={note} WHERE Id={animal.Id}";
            //return executeQuery(query);
        }

    }
}
