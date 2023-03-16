using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Species(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
