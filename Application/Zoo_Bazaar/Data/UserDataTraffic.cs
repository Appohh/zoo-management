using DataCL.DTOs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
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
                return "SELECT Employees.id ,[firstname] ,[lastname] ,[username] ,[password] ,[phone] ,[address] ,[city] ,[email] ,[spouseName] ,[spousePhone] ,[emergencyName] ,[emergencyPhone] ,[birthdate] ,[bsn] ,[imageUrl] ,[contractStatus] ,[contractType] ,[jobId], Jobs.name as 'jobname' FROM Employees INNER JOIN Jobs on Employees.jobId = Jobs.id";
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

        public bool UpdateEmployee(int employeeid, string firstname, string lastname, string phone, string address, string city, string email, string spouseName, string spousePhone, string emergencyName, string emergencyPhone, string birthdate, string bsn, int contractStatus)
        {
            string query = $"UPDATE Employees SET firstname={firstname}, lastname='{lastname}',phone={phone}, address='{address}',city={city}, email='{email}',spouseName={spouseName}, spousePhone='{spousePhone}',emergencyName={emergencyName}, emergencyPhone='{emergencyPhone}',birthdate={birthdate}, bsn='{bsn}',contractStatus={contractStatus} WHERE Id={employeeid}";
            return executeQuery(query) == 0 ? false : true;
        }

    }
}
