using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;

namespace DataCL.DataTraffic
{
    public class AbsenceDataTraffic: DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "SELECT * from Absence;";
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

        public bool AddAbsence(int employeeId, string startdate, string enddate, int type)
        {
            string query = $"Insert INTO Absence (employeeId, startDate, endDate, type)" +
            $"VALUES({employeeId},'{startdate}','{enddate}',{type})"; 

            return executeQuery(query) == 0 ? false : true;
        }

        public bool addAnimal(AnimalDTO animal)
        {
            string query = $"INSERT INTO Animals (name, birthdate, birthplace, fatherId, motherId, locationId, dietId, sick, notes, deathdate, typeId, imageUrl, genderId) " +
            $"VALUES('{animal.Name}', '{animal.Birthdate}', '{animal.BirthPlace}', '{animal.FatherId}', '{animal.MotherId}', {animal.Location}, {animal.Diet}, {animal.Sick}, 'NULL', '{animal.Deathdate}', {animal.Type}, 'NULL', {animal.Gender})";
            return executeQuery(query) == 0 ? false : true;
        }
    }
}
