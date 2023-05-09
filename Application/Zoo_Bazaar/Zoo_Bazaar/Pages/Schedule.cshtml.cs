using LogicCL;
using LogicCL.Repository;
using LogicCL.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Zoo_Bazaar.Pages
{
    public class ScheduleModel : PageModel
    {
        public User? LoggedEmployee { get; set; }
        private EmployeeRepository? _employeeRepository { get; set; }

        public WeekSchedule currentWeekSchedule;
        public List<Shift> loggedEmployeeShifts { get; set; }
        public string scheduleJson = "";

        public ScheduleModel() {
            _employeeRepository = new EmployeeRepository();
            currentWeekSchedule = new WeekSchedule(DateTime.Now);
        }

        public void OnGet()
        {
            if (_employeeRepository == null)
            {
                return;
            }


            var idClaim = User.FindFirst("id");
            if (idClaim != null)
            {
                int idValue = Convert.ToInt32(idClaim.Value);
                LoggedEmployee = _employeeRepository.getUserById(idValue);
            }

            if (LoggedEmployee == null) { return; }

            loggedEmployeeShifts = _employeeRepository.GetShiftsByEmpId(LoggedEmployee.Id);
            scheduleJson = JsonConvert.SerializeObject(loggedEmployeeShifts);
        }
    }
}
