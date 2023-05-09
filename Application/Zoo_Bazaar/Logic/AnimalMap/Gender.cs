using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.AnimalMap
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Gender()
        {

        }
        public Gender(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
