using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DataTraffic
{
    public class ShiftDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Shift";
            }
        }

        public List<ShiftDTO> GetAllShifts()
        {

            List<ShiftDTO> shifts = new List<ShiftDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                shifts.Add(DataConvertingMethods.ConvertDataRowToObject<ShiftDTO>(dr));
            }

            //return collection of DTOs
            return shifts;
        }

        public bool AddShift(ShiftDTO shift)
        {
            string query = $"INSERT INTO Shift Values ({shift.EmpId}, {shift.Type}, '{shift.Date}' , {shift.Location})";
            return executeQuery(query) == 0 ? false : true;
        }

        public void RemoveShift()
        {

        }
    }
}
