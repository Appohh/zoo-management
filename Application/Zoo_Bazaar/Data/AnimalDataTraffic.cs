using DataCL.DTOs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataCL
{
    public class AnimalDataTraffic : AnimalDataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Animals";
            }
        }
        public List<AnimalDTO> getAnimals()
        {
            List<AnimalDTO> Animals = new List<AnimalDTO>();
            //get table from database
            DataTable table = base.ReadData();
        
            //itterate trough all rows of given database -> datatable
            foreach (DataRow dr in table.Rows)
            {
                //!! CHECK NULLS
                Animals.Add(new AnimalDTO(Convert.ToInt32(dr["id"]), $"{dr["name"]}", $"{dr["birthdate"]}", $"{dr["birthplace"]}", Convert.ToInt32(dr["fatherId"]), Convert.ToInt32(dr["motherId"]), Convert.ToInt32(dr["locationId"]), Convert.ToInt32(dr["dietId"]), Convert.ToInt32(dr["speciesId"]), $"{dr["type"]}", Convert.ToInt32(dr["sick"]), $"{dr["notes"]}", $"{dr["deathdate"]}", $"{dr["imageUrl"]}"));
            }
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
