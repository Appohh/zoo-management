using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class DietDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DietDTO() { }

        public DietDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
