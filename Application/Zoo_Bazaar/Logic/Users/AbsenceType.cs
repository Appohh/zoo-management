using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Users
{
    public class AbsenceType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public AbsenceType() { }

        public AbsenceType(int id, string type)
        {
            this.Id = id;
            this.Type = type;
        }
    }
}
