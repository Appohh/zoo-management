using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class DietDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "SELECT * From Diet;";
            }
        }

        public List<DietDTO> retrieveTypes()
        {

            List<DietDTO> types = new List<DietDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                types.Add(DataConvertingMethods.ConvertDataRowToObject<DietDTO>(dr));
            }

            //return collection of DTOs
            return types;
        }
    }
}
