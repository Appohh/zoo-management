using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class Shift
    {
        public int Id { get; set; }

        public int EmpId { get; set; }

        public int Type { get; set; }

        public string Date { get; set; }

        public int Location { get; set; }

        public Shift(int id, int empId, int type, string date, int location)
        {
            Id = id;
            EmpId = empId;
            Type = type;
            Date = date;
            Location = location;

        }

        public Shift() { }
    }
}
