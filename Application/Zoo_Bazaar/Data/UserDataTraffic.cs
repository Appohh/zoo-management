using DataCL.DTOs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataCL
{
    public class UserDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Employees";
            }
        }
        public List<UserDTO> retrieveUsers()
        {
            List<UserDTO> Users = new List<UserDTO>();

            //get datatable of queried data
            DataTable table = base.ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                Users.Add(DataConvertingMethods.ConvertDataRowToObject<UserDTO>(dr));
            }

            //return collection of DTOs
            return Users;
        }

        public void RetrieveJobs()
        {
            
        }

        public bool AddUser(UserDTO user)
        {
            string query = $"INSERT INTO Employees (firstname, lastname, username, password, phone, address, city, email, emergencyName, emergencyPhone, birthdate, bsn, imageUrl, contractStatus, jobId) " +
                $"VALUES ('{user.Firstname}', '{user.Lastname}', '{user.Username}', '{user.Password}', '{user.Phone}', '{user.Address}', '{user.City}', '{user.Email}', '{user.EmergencyName}', '{user.EmergencyPhone}', '{user.Birthdate}', '{user.BSN}', '{user.ImageUrl}', '{user.ContractStatus}', '{user.JobId}' );";
            return executeQuery(query) == 0 ? false : true;
        }

        public void Update(UserDTO user, int sick)
        {
            //string query = $"UPDATE Animal SET Sick={sick} WHERE Id={}";
            //return executeQuery(query);
        }

    }
}
