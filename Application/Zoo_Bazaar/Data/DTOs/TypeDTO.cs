using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class TypeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int speciesId { get; set; }

        public TypeDTO()
        {

        }
        public TypeDTO(int id, string name, int speciesId)
        {
            Id = id;
            Name = name;
            this.speciesId = speciesId;
        }
    }
}
