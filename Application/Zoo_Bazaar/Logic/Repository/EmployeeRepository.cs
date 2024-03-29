﻿using DataCL.DataTraffic;
using DataCL.DTOs;
using LogicCL.AnimalMap;
using LogicCL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
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
        private AbsenceTypeDataTraffic absenceTypeDataTraffic = new AbsenceTypeDataTraffic();
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
                    User hr = new HR(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, image: userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(hr);
                }
                if (userDto.JobId == 2)
                {
                    User zookeeper = new Zookeeper(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(zookeeper);
                }
                if (userDto.JobId == 3)
                {
                    User VeterinaryTechnician = new VeterinaryTechnician(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(VeterinaryTechnician);
                }
                if (userDto.JobId == 4)
                {
                    User AnimalManagement = new AnimalManagement(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(AnimalManagement);
                }
                if (userDto.JobId == 5)
                {
                    User GroundsKeeper = new GroundsKeeper(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(GroundsKeeper);
                }
                if (userDto.JobId == 6)
                {
                    User Cleaner = new Cleaner(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(Cleaner);
                }
                if (userDto.JobId == 7)
                {
                    User ScheduleMaker = new ScheduleMaker(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(ScheduleMaker);
                }
                if (userDto.JobId == 8)
                {
                    User TicketSales = new TicketSales(userDto.SpouseName, userDto.SpousePhone, userDto.EmergencyName, userDto.EmergencyPhone, userDto.BSN, userDto.ContractStatus, userDto.ImageUrl, userDto.Id, userDto.Firstname, userDto.Lastname, userDto.Username, userDto.Password, userDto.Email, userDto.Phone, userDto.Birthdate, userDto.Address, userDto.City, userDto.Jobname, userDto.Salary, userDto.WorkingHours);
                    newUsers.Add(TicketSales);
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
                locations.Add(new Location(locationDTO.Id, locationDTO.Name, locationDTO.Count));
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

        public bool changeEmployeeDetails(int employeeid, string firstname, string lastname, string phone, string address, string city, string email, string spouseName, string spousePhone, string emergencyName, string emergencyPhone, string birthdate, string bsn, int contractStatus, int job, int salary, int workingHours, byte[] image)
        {
            if (userDataTraffic.UpdateEmployee(employeeid, firstname, lastname, phone, address, city, email, spouseName, spousePhone, emergencyName, emergencyPhone, birthdate, bsn, contractStatus, job, salary, workingHours, image))
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

        public List<Shift> GetShiftByJob(int id)
        {
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetShiftsByEmpJob(id);
            List<Shift> shiftList = new List<Shift>();
            foreach (ShiftDTO shift in shiftDTOs)
            {
               
                shiftList.Add(new Shift(shift.Id, shift.EmpId, shift.Type, shift.Date, shift.Location));
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

        public bool RemoveShift(Shift shift)
        {
            return shiftDataTraffic.RemoveShift(shift.Id);
        }

        //public List<Employee> GetAvailble(DateTime date)
        //{
        //    List<Employee> available = new List<Employee>();

        //    foreach (Employee employee in GetUserList().OfType<Employee>().ToList())
        //    {
        //        if (IsAbsent(employee.Id, date))
        //        {
        //            continue;
        //        }
        //        int hoursWorkedThisDay = HoursWorkedThisDay(employee.Id, date);
        //        if (hoursWorkedThisDay < 8)
        //        {
        //            available.Add(employee);
        //        }

        //    }
        //    return available;
        //}
        public List<Employee> GetAvailableByJob(DateTime date, string jobname)
        {
            List<UserDTO> userDTOs = userDataTraffic.GetAvailableByJobId(date, jobname);
            List<Employee> availableEmployees = new List<Employee>();

            if (userDTOs != null)
            {
                refreshUserData();
                foreach (UserDTO userDTO in userDTOs)
                {
                    Employee correspondingEmployee = users.Find(u => u.Id == userDTO.Id) as Employee;

                    if (correspondingEmployee != null)
                    {
                        availableEmployees.Add(correspondingEmployee);
                    }
                }
            }

            return availableEmployees;
        }

        public List<Shift> GetDepartmentShiftsByDate(WeekSchedule week, Job job)
        {
            List<Shift> result = new List<Shift>();
            List<ShiftDTO> dtos = shiftDataTraffic.GetDepartmentShiftByDate(week.Monday, week.Sunday, job.Id);

            foreach (ShiftDTO dto in dtos)
            {
                result.Add(new Shift(dto.Id, dto.EmpId, dto.Type, dto.Date, dto.Location));
            }
            return result;

        }

        //private bool IsAbsent(int id, DateTime date)
        //      {
        //          List<Absence> absences = GetAllAbsences().FindAll(x => date >= DateTime.Parse(x.startdate) && date <= DateTime.Parse(x.enddate));
        //          foreach (var item in absences)
        //          {
        //              if (item.employeeId == id)
        //              {
        //                  return true;
        //              }
        //          }
        //          return false;
        //      }
        //

        public int HoursWorkedThisWeek(int id, DateTime date)
        {
            //for example part-time: 12, full-time: 24 check contractStatus 0: inactive, 1:part-time, 2:fulltime
            WeekSchedule currentWeek = new WeekSchedule(date);
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetShiftsByEmpId(id);
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

        public int HoursWorkedThisMonth(int id, DateTime date)
        {
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetShiftsByEmpId(id);
            int count = 0;
            foreach (ShiftDTO shift in shiftDTOs)
            {
                DateTime shiftDate = DateTime.Parse(shift.Date);

                if (shift.EmpId == id && shiftDate.Month == date.Month && shiftDate.Year == date.Year)
                {
                    count++;
                }
            }
            return count * 4;
        }

        public int HoursWorkedThisDay(int id, DateTime date)
        {
            List<ShiftDTO> shiftDTOs = shiftDataTraffic.GetShiftsByEmpId(id);
            int count = 0;
            foreach (ShiftDTO shift in shiftDTOs)
            {
                DateTime shiftDate = DateTime.Parse(shift.Date);

                if (shift.EmpId == id && shiftDate.Date == date.Date)
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
                if (shiftDTO.EmpId == id && shiftDTO.Date.Contains(date.ToString("yyyy-MM-dd")) && shiftDTO.Type == type)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Absence> GetAllAbsences()
        {
            List<AbsenceDTO> absenceDTOs = absenceDataTraffic.retrieveAbsence();
            List<Absence> absences = new List<Absence>();
            foreach (AbsenceDTO absenceDTO in absenceDTOs)
            {
                absences.Add(new Absence(absenceDTO.employeeId, absenceDTO.startdate, absenceDTO.enddate, absenceDTO.type));
            }
            return absences;
        }

        public bool AddEmployeeAbsence(int employeeid, string startDate, string endDate, int type)
        {
            if (absenceDataTraffic.AddAbsence(employeeid, startDate, endDate, type))
            {
                refreshUserData(); return true;
            }
            else
            {
                return false;
            }
        }

        public List<AbsenceType> GetAbsenceTypes()
        {
            List<AbsenceTypeDTO> absenceTypeDTOs = absenceTypeDataTraffic.retrieveAbsence();
            List<AbsenceType> absencesTypes = new List<AbsenceType>();
            foreach (AbsenceTypeDTO absenceTyeDTO in absenceTypeDTOs)
            {
                absencesTypes.Add(new AbsenceType(absenceTyeDTO.Id, absenceTyeDTO.Type));
            }
            return absencesTypes;
        }

        public Dictionary<Employee, List<ShiftDTO>> CreateSchedule(DateTime date, string jobName)
        {
            // Dictionary to store the schedule. Key is an employee, value is a list of shifts for the week.
            Dictionary<Employee, List<ShiftDTO>> schedule = new Dictionary<Employee, List<ShiftDTO>>();

            // Get all available employees.
            List<Employee> employees = GetAvailableByJob(date, jobName);

            // Loop over each day of the week.
            for (int i = 0; i < 7; i++)
            {
                // Calculate the current date.
                DateTime currentDate = date.AddDays(i);

                // Order employees based on the total number of hours they've worked this week so far.
                // The one with the least hours gets priority.
                employees = employees.OrderBy(emp => HoursWorkedThisWeek(emp.Id, currentDate)).ToList();

                // Try to assign a shift to each employee.
                foreach (Employee employee in employees)
                {
                    int hoursWorkedThisWeek = HoursWorkedThisWeek(employee.Id, currentDate);
                    int hoursWorkedThisDay = HoursWorkedThisDay(employee.Id, currentDate);

                    // Check if the employee is available to work a shift on the current date.
                    // In this example, it's assumed that a shift is 4 hours long and an employee cannot work more than 8 hours a day or 40 hours a week.
                    if (hoursWorkedThisDay < 8 && hoursWorkedThisWeek < 40)
                    {
                        // If the employee is available, create a new shift and add it to the schedule.
                        ShiftDTO shift = new ShiftDTO
                        {
                            EmpId = employee.Id,
                            Date = currentDate.ToString("yyyy-MM-dd") // Assumes that ShiftDTO.Date is a string in "yyyy-MM-dd" format.
                        };

                        if (!schedule.ContainsKey(employee))
                        {
                            schedule[employee] = new List<ShiftDTO>();
                        }

                        schedule[employee].Add(shift);
                    }
                }
            }

            return schedule;
        }
    }
}