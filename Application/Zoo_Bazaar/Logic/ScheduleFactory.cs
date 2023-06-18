using DataCL.DataTraffic;
using System;
using System.Collections.Generic;
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


    }
}
