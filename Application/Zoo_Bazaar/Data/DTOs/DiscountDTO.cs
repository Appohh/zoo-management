using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class DiscountDTO
    {
        public int Id { get; private set; }
        public string Code { get; private set; }

        public DiscountDTO(int id, string code)
        {
            Id = id;
            Code = code;
        }
        public DiscountDTO() { }
    }
}
