using DataCL.DataTraffic;
using DataCL.DTOs;
using LogicCL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Repository
{
    public class EmployeeRepository
    {
        private UserDataTraffic userDataTraffic = new UserDataTraffic();
        private JobDataTraffic jobDataTraffic = new JobDataTraffic();
        private List<User> users = new List<User>();

        public List<User> Users { get { return users; } }

        public EmployeeRepository() 
        {
            refreshUserData();
        }
        private void refreshUserData()
        {
            List<UserDTO> usersDTOs = new List<UserDTO>();
            usersDTOs.AddRange(this.userDataTraffic.retrieveUsers());

            List<User> newUsers = new List<User>();

            users.Clear();
            //!!!!!!
            //still needs converting from DTO to userfriendly User class with selected fields

            foreach (UserDTO userDto in usersDTOs)
            {
                if (userDto.JobId == 1)
                {
                    User hr = new HR(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(hr);
                }
                if (userDto.JobId == 2)
                {
                    User zookeeper = new Zookeeper(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(zookeeper);
                }
                if (userDto.JobId == 3) 
                {
                    //Veterinary_Technician
                }
                if (userDto.JobId == 4)
                {
                    User AnimalManagement = new AnimalManagement(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(AnimalManagement);
                }
                

            }
            users.AddRange(newUsers);

        }

        public List<User> GetUserList([Optional] Type type, [Optional] List<Type> types)
        {
            //Returns list of users based on type, able to be provided with one type, a list of types or nothing
            List<User> filteredUsers = new List<User>();
            if (types != null)
            {

                filteredUsers.AddRange(Users.Where(user => types.Contains(user.GetType())));
                return filteredUsers;
            }

            if (type != null)
            {

                filteredUsers.AddRange(Users.Where(user => type == user.GetType()));
                return filteredUsers;
            }

            return Users;
        }

        public User? getUserById(int id)
        {
            return Users.Find(user => user.Id == id);
        }        
        public List<Job> GetJobList()
        {
            List<JobDTO> jobDTOs = jobDataTraffic.retrieveJobs();
            List<Job> jobs = new List<Job>();
            foreach(JobDTO jobDTO in jobDTOs)
            {
                jobs.Add(new Job(jobDTO.Id, jobDTO.Name));
            }
            return jobs;
        }

        public bool AddNew(UserDTO userDTO)
        {
            if (userDataTraffic.AddUser(userDTO))
            {
                refreshUserData();
                return true;
            };
            return false;
        }

        public bool changeEmployeeDetails(int employeeid, string firstname, string lastname, string phone, string address, string city, string email, string spouseName, string spousePhone, string emergencyName, string emergencyPhone, string birthdate, string bsn, int contractStatus)
        {
           if(userDataTraffic.UpdateEmployee(employeeid, firstname, lastname, phone, address, city, email, spouseName, spousePhone, emergencyName, emergencyPhone, birthdate, bsn, contractStatus)) { refreshUserData(); return true; } else { return false; }
        }

    }
}
