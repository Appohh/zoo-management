using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.AnimalMap
{
    public class Diet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Diet (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
