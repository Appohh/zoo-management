using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.AnimalMap
{
    public class Types
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int speciesId { get; set; }

        public Types()
        {

        }
        public Types(int id, string name, int speciesId)
        {
            Id = id;
            Name = name;
            this.speciesId = speciesId;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
