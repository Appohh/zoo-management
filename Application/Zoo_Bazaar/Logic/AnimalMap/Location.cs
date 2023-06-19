using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.AnimalMap
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public Location(int id, string name, int count)
        {
            Id = id;
            Name = name;
            Count = count;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
