using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class Job
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Job(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
