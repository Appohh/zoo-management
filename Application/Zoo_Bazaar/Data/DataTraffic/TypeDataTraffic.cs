using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class TypeDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Type;";
            }
        }

        public List<TypeDTO> retrieveTypes()
        {

            List<TypeDTO> types = new List<TypeDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                types.Add(DataConvertingMethods.ConvertDataRowToObject<TypeDTO>(dr));
            }

            //return collection of DTOs
            return types;
        }
    }
}

