using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class Absence
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Absence() { }
        public Absence(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
