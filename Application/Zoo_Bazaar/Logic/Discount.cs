using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class Discount
    {
        public int Id { get; private set; }
        public string Code { get; private set; }

        public Discount(int id, string code)
        {
            Id = id;
            Code = code;
        }
    }
}
