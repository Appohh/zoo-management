using DataCL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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

        public List<ShiftDTO> GetShiftsByEmpJob(int jobid)
        {
            string query = $"SELECT Shift.id ,Shift.empid, shift.type, shift.date, Shift.location, Jobs.name FROM Shift INNER JOIN Employees ON shift.empid = Employees.id INNER JOIN Jobs ON Employees.jobId = Jobs.id WHERE Employees.jobId = {jobid};";

            List<ShiftDTO> shifts = new List<ShiftDTO>();
            DataTable table = ReadDataQuery(query);
            foreach (DataRow dr in table.Rows)
            {
                shifts.Add(DataConvertingMethods.ConvertDataRowToObject<ShiftDTO>(dr));
            }

            return shifts;
        }

        public List<ShiftDTO> GetShiftsByEmpId(int id)
        {
            string query = $"SELECT Shift.id ,Shift.empid, shift.type, shift.date, Shift.location FROM Shift WHERE Shift.empid = {id};";
			
            List<ShiftDTO> shifts = new List<ShiftDTO>();

			DataTable table = ReadDataQuery(query);

			foreach (DataRow dr in table.Rows)
			{
				shifts.Add(DataConvertingMethods.ConvertDataRowToObject<ShiftDTO>(dr));
			}

			return shifts;
		}

        public List<ShiftDTO> GetDepartmentShiftByDate(DateTime id)
        {
            string query = $"SELECT Shift.id ,Shift.empid, shift.type, shift.date, Shift.location FROM Shift WHERE Shift.empid = {id};";
			
            List<ShiftDTO> shifts = new List<ShiftDTO>();

			DataTable table = ReadDataQuery(query);

			foreach (DataRow dr in table.Rows)
			{
				shifts.Add(DataConvertingMethods.ConvertDataRowToObject<ShiftDTO>(dr));
			}

			return shifts;
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
            string query = "";
            if (shift.Location == 0)
            {
                query = $"INSERT INTO Shift Values ({shift.EmpId}, {shift.Type}, '{shift.Date}' , null)";
            }
            else
            {
                query = $"INSERT INTO Shift Values ({shift.EmpId}, {shift.Type}, '{shift.Date}' , {shift.Location})";
            }
            return executeQuery(query) == 0 ? false : true;
        }

        public bool RemoveShift(int id)
        {
            string query = $"DELETE FROM Shift WHERE id = {id}";
            return executeQuery(query) == 0 ? false : true;
        }
    }
}
