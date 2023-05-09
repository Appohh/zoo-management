using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;

namespace DataCL.DataTraffic
{
    public class AbsenceDataTraffic:DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "SELECT * from Abscence;";
            }
        }

        public List<AbsenceDTO> retrieveAbsence()
        {
            List<AbsenceDTO> absences = new List<AbsenceDTO>();

            //get datatable of queried data
            DataTable table = base.ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                absences.Add(DataConvertingMethods.ConvertDataRowToObject<AbsenceDTO>(dr));
            }

            //return collection of DTOs
            return absences;
        }

        
        public bool UpdateAbsence(int employeeId, string type)
        {
            string query = $"";
            return executeQuery(query) == 0 ? false : true;
        }
    }
}
