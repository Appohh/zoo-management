using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class AbsenceTypeDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "SELECT * from AbsenceType;";
            }
        }

        public List<AbsenceTypeDTO> retrieveAbsence()
        {
            List<AbsenceTypeDTO> absences = new List<AbsenceTypeDTO>();

            //get datatable of queried data
            DataTable table = base.ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                absences.Add(DataConvertingMethods.ConvertDataRowToObject<AbsenceTypeDTO>(dr));
            }

            //return collection of DTOs
            return absences;
        }
    }
}
