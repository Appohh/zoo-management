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
        public int Count { get; set; }

        public LocationDTO()
        {

        }
        public LocationDTO(int id, string name, int count)
        {
            Id = id;
            Name = name;
            Count = count;
        }
    }
}
