using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class GenderDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Gender;";
            }
        }

        public List<GenderDTO> retrieveGender()
        {

            List<GenderDTO> genders = new List<GenderDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                genders.Add(DataConvertingMethods.ConvertDataRowToObject<GenderDTO>(dr));
            }

            //return collection of DTOs
            return genders;
        }
    }
}
