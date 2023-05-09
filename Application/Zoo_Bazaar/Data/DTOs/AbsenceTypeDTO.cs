using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class AbsenceTypeDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public AbsenceTypeDTO() { }

        public AbsenceTypeDTO(int id, string type)
        {
            this.Id = id;
            this.Type = type;
        }
    }
}
