using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string? SpouseName { get; set; }
        public string? SpousePhone { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyPhone { get; set; }
        public string Birthdate { get; set; }
        public string BSN { get; set; }
        public int ContractStatus { get; set; }
        public int? ContactType { get; set; }
        public string ImageUrl { get; set; }
        public int JobId { get; set; }
        public string Jobname { get; set; }

        //additional things
        public int Salary { get; set; }

        public int WorkingHours { get; set; }

        public UserDTO()
        {
        }

        public UserDTO(int id, string firstname, string lastname, string username, string password, string phone, string address, string city, string email, string? spouseName, string? spousePhone, string emergencyName, string emergencyPhone, string birthdate, string bSN, int contractStatus, int? contactType, string imageUrl, int role, string jobname, int salary, int workingHours)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            Phone = phone;
            Address = address;
            City = city;
            Email = email;
            SpouseName = spouseName;
            SpousePhone = spousePhone;
            EmergencyName = emergencyName;
            EmergencyPhone = emergencyPhone;
            Birthdate = birthdate;
            BSN = bSN;
            ContractStatus = contractStatus;
            ContactType = contactType;
            ImageUrl = imageUrl;
            JobId = role;
            Jobname = jobname;
            Salary = salary;
            WorkingHours = workingHours;
        }
    }
}