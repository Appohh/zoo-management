using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class SpeciesDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Species;";
            }
        }

        public List<SpeciesDTO> retrieveSpecies()
        {

            List<SpeciesDTO> species = new List<SpeciesDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                species.Add(DataConvertingMethods.ConvertDataRowToObject<SpeciesDTO>(dr));
            }

            //return collection of DTOs
            return species;
        }
    }
}
