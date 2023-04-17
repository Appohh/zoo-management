using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class LocationDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Jobs";
            }
        }

        public List<LocationDTO> retrieveLocation()
        {

            List<LocationDTO> location = new List<LocationDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                location.Add(DataConvertingMethods.ConvertDataRowToObject<LocationDTO>(dr));
            }

            //return collection of DTOs
            return location;
        }
    }
}
