using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Users
{
    public class Absence
    {
        public int employeeId { get; private set; }
        public string? startdate { get; private set; }
        public string? enddate { get; private set;}
        public int? Type { get; private set; }

        public Absence(int employeeId, string? startdate, string? enddate, int? type)
        {
            this.employeeId = employeeId;
            this.startdate = startdate;
            this.enddate = enddate;
            this.Type = type;
        }
    }
}
