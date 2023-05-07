using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;

namespace DataCL.DataTraffic
{
    public class MotherDataTraffic:DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select a.name ,a.genderId from Animals a where a.genderId = 2;";
            }
        }

        public List<AnimalDTO> retrieveMales()
        {
            List<AnimalDTO> Females = new List<AnimalDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            if (table == null) { return null; }

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                Females.Add(DataConvertingMethods.ConvertDataRowToObject<AnimalDTO>(dr));
            }

            //return collection of DTOs
            return Females;
        }
    }
}
