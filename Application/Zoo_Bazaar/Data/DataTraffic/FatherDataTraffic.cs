using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;

namespace DataCL.DataTraffic
{
    public class FatherDataTraffic : DataHandler
    {

        protected override string cmd
        {
            get
            {
                return "select a.name ,a.genderId from Animals a where a.genderId = 1;";
            }
        }

        public List<AnimalDTO> retrieveMales()
        {
            List<AnimalDTO> Males = new List<AnimalDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            if (table == null) { return null; }

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                Males.Add(DataConvertingMethods.ConvertDataRowToObject<AnimalDTO>(dr));
            }

            //return collection of DTOs
            return Males;
        }

    }
}
