using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class SpeciesDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SpeciesDTO()
        {

        }
        public SpeciesDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
