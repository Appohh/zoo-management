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
                if (employees.Count > 0)
                {
                    if (job.Name != "Caretaker")
                    {
                        int dayCount = existingShifts.Count(x => x.Type == 0 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")));
                        int afternoonCount = existingShifts.Count(x => x.Type == 1 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")));
                        int nightCount = existingShifts.Count(x => x.Type == 2 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")));

                        for (int j = 0; j < 9; j++)
                        {
                            if (j >= 0 && j < employees.Count)
                            {
                                int hoursWorkedThisDay = existingShifts.Count(x => x.EmpId == employees[j].Id && x.Date.Contains(currentDate.ToString("dd/MM/yyyy"))) * 4;
                                int hoursWorkedThisWeek = existingShifts.Count(x => x.EmpId == employees[j].Id) * 4;

                                if (hoursWorkedThisDay < 8 && hoursWorkedThisWeek <= 36)
                                {
                                    bool exists = true;
                                    ShiftDTO shift = new ShiftDTO();

                                    while (exists)
                                    {
                                        
                                        if (dayCount < 3)
                                        {
                                            shift.Type = 0;
                                            dayCount++;
                                        }
                                        else if (afternoonCount < 3)
                                        {
                                            shift.Type = 1;
                                            afternoonCount++;
                                        }
                                        else if (nightCount < 3)
                                        {
                                            shift.Type = 2;
                                            nightCount++;
                                        }
                                        else
                                        {
                                            break;
                                        }

                                        shift.EmpId = employees[j].Id;
                                        shift.Date = currentDate.ToString("yyyy-MM-dd");
                                        shift.Location = 0;

                                        exists = existingShifts.Any(s => s.EmpId == shift.EmpId && s.Type == shift.Type && s.Date == shift.Date);
                                    }
                                    if (shift.EmpId != 0 && shift.Date != string.Empty)
                                    {
                                        existingShifts.Add(shift);
                                        schedule.Add(shift);
                                    }
                                    
                                }
                            }

                            
                        }

                    }
                    else
                    {
                        int dayCount = existingShifts.Count(x => x.Type == 0 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")));

                        int afternoonCount = existingShifts.Count(x => x.Type == 1 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")));
                        int nightCount = existingShifts.Count(x => x.Type == 2 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")));

                        int aquaticCount = existingShifts.Count(x => x.Type == 1 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")) && x.Location == 1);
                        int desertCount = existingShifts.Count(x => x.Type == 1 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")) && x.Location == 2);
                        int grasslandCount = existingShifts.Count(x => x.Type == 1 && x.Date.Contains(currentDate.ToString("dd/MM/yyyy")) && x.Location == 3);

                        for (int j = 0; j < 9; j++)
                        {
                            if (j >= 0 && j < employees.Count)
                            {
                                int hoursWorkedThisDay = existingShifts.Count(x => x.EmpId == employees[j].Id && x.Date.Contains(currentDate.ToString("dd/MM/yyyy"))) * 4;
                                int hoursWorkedThisWeek = existingShifts.Count(x => x.EmpId == employees[j].Id) * 4;

                                if (hoursWorkedThisDay < 8 && hoursWorkedThisWeek <= 36)
                                {
                                    bool exists = true;
                                    ShiftDTO shift = new ShiftDTO();

                                    while (exists)
                                    {
                                        if (dayCount < 3)
                                        {
                                            shift.Type = 0;
                                            dayCount++;
                                        }
                                        else if (afternoonCount < 3)
                                        {
                                            shift.Type = 1;
                                            afternoonCount++;
                                        }
                                        else if (nightCount < 3)
                                        {
                                            shift.Type = 2;
                                            nightCount++;
                                        }
                                        else
                                        {
                                            break;
                                        }

                                        if (aquaticCount < 1)
                                        {
                                            shift.Location = 1;
                                            aquaticCount++;
                                        }
                                        else if (desertCount < 4)
                                        {
                                            shift.Location = 2;
                                            desertCount++;
                                        }
                                        else if(grasslandCount < 4)
                                        {
                                            shift.Location = 3;
                                            grasslandCount++;
                                        }
                                        else
                                        {
                                            break;
                                        }

                                        shift.EmpId = employees[j].Id;
                                        shift.Date = currentDate.ToString("yyyy-MM-dd");


                                        exists = existingShifts.Any(s => s.EmpId == shift.EmpId && s.Type == shift.Type && s.Date == shift.Date);
                                    }
                                    if (shift.EmpId != 0 && shift.Date != string.Empty)
                                    {
                                        existingShifts.Add(shift);
                                        schedule.Add(shift);
                                    }
                                }
                            }


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
