using DataCL.DataTraffic;
using DataCL.DTOs;
using LogicCL.Users;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class ScheduleFactory
    {
        private UserDataTraffic userDataTraffic = new UserDataTraffic();
        private JobDataTraffic jobDataTraffic = new JobDataTraffic();
        private ShiftDataTraffic shiftDataTraffic = new ShiftDataTraffic();
        private LocationDataTraffic locationDataTraffic = new LocationDataTraffic();
        private AbsenceDataTraffic absenceDataTraffic = new AbsenceDataTraffic();
        private AbsenceTypeDataTraffic absenceTypeDataTraffic = new AbsenceTypeDataTraffic();

        public void Schedule(WeekSchedule week, Job job)
        {
            
           
        }

        public bool GenerateSchedule(WeekSchedule week, Job job)
        {
            List<ShiftDTO> schedule = new List<ShiftDTO>();

            List<ShiftDTO> existingShifts = shiftDataTraffic.GetDepartmentShiftByDate(week.Monday, week.Sunday, job.Id);

            Random rand = new Random();
            
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDate = week.Monday.AddDays(i);
                List<UserDTO> employees = userDataTraffic.GetAvailableByJobId(currentDate, job.Name);

                employees = employees.OrderBy(emp => HoursWorkedThisMonth(emp.Id, currentDate)).ToList();

                if (job.Name != "Caretaker")
                {
                    foreach (var employee in employees)
                    {
                        int hoursWorkedThisWeek = HoursWorkedThisWeek(employee.Id, currentDate);
                        int hoursWorkedThisDay = HoursWorkedThisDay(employee.Id, currentDate);
                        if (hoursWorkedThisDay < 8 && hoursWorkedThisWeek <= 36)
                        {
                            bool exists = true;
                            ShiftDTO shift = new ShiftDTO();

                            while (exists)
                            {
                                shift.EmpId = employee.Id;
                                shift.Date = currentDate.ToString("yyyy-MM-dd");
                                shift.Type = rand.Next(0, 3);


                                exists = existingShifts.Any(s => s.EmpId == shift.EmpId && s.Type == shift.Type && s.Date == shift.Date);
                            }

                            schedule.Add(shift);
                        }
                    }
                }
                else
                {
                    foreach (var employee in employees)
                    {
                        int hoursWorkedThisWeek = HoursWorkedThisWeek(employee.Id, currentDate);
                        int hoursWorkedThisDay = HoursWorkedThisDay(employee.Id, currentDate);
                        if (hoursWorkedThisDay < 8 && hoursWorkedThisWeek <= 36)
                        {
                            bool exists = true;
                            ShiftDTO shift = new ShiftDTO();

                            while (exists)
                            {
                                shift.EmpId = employee.Id;
                                shift.Date = currentDate.ToString("yyyy-MM-dd");
                                shift.Type = rand.Next(0, 3);
                                shift.Location = rand.Next(1, 12);

                                exists = existingShifts.Any(s => s.EmpId == shift.EmpId && s.Type == shift.Type && s.Date == shift.Date && s.Location == shift.Location);
                            }

                            schedule.Add(shift);
                        }
                    }

                }
                
            }

            



            return shiftDataTraffic.AddMultipleShift(schedule);
        }

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
    }
}
