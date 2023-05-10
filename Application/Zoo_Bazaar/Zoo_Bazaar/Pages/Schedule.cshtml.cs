using LogicCL;
using LogicCL.Repository;
using LogicCL.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Zoo_Bazaar.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        public User? LoggedEmployee { get; set; }
        private EmployeeRepository? _employeeRepository { get; set; }

        public WeekSchedule currentWeekSchedule;
        public List<Shift> loggedEmployeeShifts { get; set; }
        public dynamic scheduleJson = "";

        private JsonSerializerSettings settings = new JsonSerializerSettings
        {
            //Type hinting
            TypeNameHandling = TypeNameHandling.Auto
        };

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

            foreach(Shift shift in loggedEmployeeShifts)
            {
                DateTime date;
                date = DateTime.Parse(shift.Date);
                shift.Date = date.ToString("dd-MM-yyyy");
            }

            string json = JsonConvert.SerializeObject(loggedEmployeeShifts, settings);
            scheduleJson = new HtmlString(json);
        }
    }
}
