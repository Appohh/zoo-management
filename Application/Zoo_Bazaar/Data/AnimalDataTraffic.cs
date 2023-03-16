using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DataTable table = base.RetrieveAnimalData();

            //itterate trough all rows of given database -> datatable
            foreach (DataRow dr in table.Rows)
            {
                Animals.Add(new AnimalDTO(Convert.ToInt32(dr["id"]), $"{dr["name"]}", $"{dr["birthdate"]}", $"{dr["birthplace"]}", Convert.ToInt32(dr["fatherId"]), Convert.ToInt32(dr["motherId"]), Convert.ToInt32(dr["locationId"]), Convert.ToInt32(dr["dietId"]), Convert.ToInt32(dr["speciesId"]), $"{dr["type"]}", Convert.ToInt32(dr["sick"]), $"{dr["notes"]}", $"{dr["deathdate"]}", $"{dr["imageUrl"]}"));
            }
            return Animals;
        }
    }
}
