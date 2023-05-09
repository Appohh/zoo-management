using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class AbsenceDTO
    {
        public int employeeId { get; private set; }
        public string? startdate { get; private set; }
        public string? enddate { get; private set; }
        public int type { get; private set; }

        public AbsenceDTO() { }

        public AbsenceDTO(int employeeId, string? startdate, string? enddate, int type)
        {
            this.employeeId = employeeId;
            this.startdate = startdate;
            this.enddate = enddate;
            this.type = type;
        }
    }
}
