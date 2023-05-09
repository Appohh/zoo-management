using DataCL.DataTraffic;
using DataCL.DTOs;
using LogicCL.AnimalMap;
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
        private ShiftDataTraffic shiftDataTraffic = new ShiftDataTraffic();
        private LocationDataTraffic locationDataTraffic = new LocationDataTraffic();
        private AbsenceDataTraffic absenceDataTraffic = new AbsenceDataTraffic();
        private List<User> users = new List<User>();

        public List<User> Users
        { get { return users; } }

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
                    User VeterinaryTechnician = new VeterinaryTechnician(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(VeterinaryTechnician);
                }
                if (userDto.JobId == 4)
                {
                    User AnimalManagement = new AnimalManagement(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(AnimalManagement);
                }
                if (userDto.JobId == 5)
                {
                    User GroundsKeeper = new GroundsKeeper(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(GroundsKeeper);
                }
                if (userDto.JobId == 6)
                {
                    User Cleaner = new Cleaner(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(Cleaner);
                }
                if (userDto.JobId == 7)
                {
                    User ScheduleMaker = new ScheduleMaker(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname);
                    newUsers.Add(ScheduleMaker);
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

        public List<Location> GetLocations()
        {
            List<LocationDTO> locationDTOs = locationDataTraffic.retrieveLocation();
            List<Location> locations = new List<Location>();
            foreach (LocationDTO locationDTO in locationDTOs)
            {
                locations.Add(new Location(locationDTO.Id, locationDTO.Name));
            }
            return locations;
        }

        public List<Job> GetJobList()
        {
            List<JobDTO> jobDTOs = jobDataTraffic.retrieveJobs();
            List<Job> jobs = new List<Job>();
            foreach (JobDTO jobDTO in jobDTOs)
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

        public bool changeEmployeeDetails(int employeeid, string firstname, string lastname, string phone, string address, string city, string email, string spouseName, string spousePhone, string emergencyName, string emergencyPhone, string birthdate, string bsn, int contractStatus, int job)
        {
            if (userDataTraffic.UpdateEmployee(employeeid, firstname, lastname, phone, address, city, email, spouseName, spousePhone, emergencyName, emergencyPhone, birthdate, bsn, contractStatus, job))
            {
                refreshUserData(); return true;
            }
            else
            {
                return false;
            }
        }

        public List<Shift> GetShiftsByEmpId(int id)
        {
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetAllShifts();
            List<Shift> shiftList = new List<Shift>();
            foreach (ShiftDTO shift in shiftDTOs)
            {
                if (shift.EmpId == id)
                {
                    shiftList.Add(new Shift(shift.Id, shift.EmpId, shift.Type, shift.Date, shift.Location));
                }
            }

            return shiftList;
        }

        public List<Shift> GetAllShifts()
        {
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetAllShifts();
            List<Shift> shiftList = new List<Shift>();
            foreach (ShiftDTO shift in shiftDTOs)
            {             
                shiftList.Add(new Shift(shift.Id, shift.EmpId, shift.Type, shift.Date, shift.Location));               
            }

            return shiftList;
        }

        public bool AddShift(ShiftDTO shift)
        {
            //constraints to be add later
            return shiftDataTraffic.AddShift(shift);
        }

        public List<Employee> GetAvailble(DateTime date)
        {
            List<Employee> available = new List<Employee>();
            foreach (Employee employee in GetUserList().OfType<Employee>().ToList())
            {
                int hoursWorkedThisDay = HoursWorkedThisDay(employee.Id, date);
                if (hoursWorkedThisDay < 8)
                {
                    available.Add(employee);
                }
                
            }
            return available;
        }

        private void IsAbsent()
        {
        }


        public int HoursWorkedThisWeek(int id, DateTime date)
        {
            //for example part-time: 12, full-time: 24 check contractStatus 0: inactive, 1:part-time, 2:fulltime
            WeekSchedule currentWeek = new WeekSchedule(date);
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetAllShifts();
            int count = 0;
            foreach (ShiftDTO shift in shiftDTOs)
            {
                if (shift.EmpId == id && currentWeek.Monday <= date && date <= currentWeek.Sunday)
                {
                    count++;
                }
            }
            return count * 4;
        }

        public int HoursWorkedThisDay(int id, DateTime date)
        {
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetAllShifts();
            int count = 0;
            foreach (ShiftDTO shift in shiftDTOs)
            {
                if (shift.EmpId == id && shift.Date.Contains(date.ToString("dd/MM/yyyy")))
                {
                    count++;
                }
            }
            return count * 4;
        }

        public bool ShiftExisted(int id, DateTime date, int type)
        {
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetAllShifts();
            foreach (ShiftDTO shiftDTO in shiftDTOs)
            {
                if (shiftDTO.EmpId == id && shiftDTO.Date.Contains(date.ToString("dd/MM/yyyy")) && shiftDTO.Type == type)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Absence> GetAllAbsences()
        {
            List<AbsenceDTO> absenceDTOs = absenceDataTraffic.retrieveAbsence();
            List<Absence> absences= new List<Absence>();
            foreach (AbsenceDTO absenceDTO in absenceDTOs) 
            {
                absences.Add(new Absence(absenceDTO.employeeId, absenceDTO.startdate, absenceDTO.enddate, absenceDTO.type));
            }
            return absences;
        }

        public bool changeEmployeeAbsence(int employeeid, string startDate, string endDate, int type)
        {
            if (absenceDataTraffic.UpdateAbsence(employeeid, startDate, endDate, type))
            {
                refreshUserData(); return true;
            }
            else
            {
                return false;
            }
        }
    }
}