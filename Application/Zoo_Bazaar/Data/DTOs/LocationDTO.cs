using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class LocationDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public LocationDTO()
        {

        }
        public LocationDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
