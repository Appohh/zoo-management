using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class AbsenceDTO
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public AbsenceDTO() { }
        public AbsenceDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
