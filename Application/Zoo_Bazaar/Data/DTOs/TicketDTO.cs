using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class TicketDTO
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public TicketDTO(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public TicketDTO()
        {

        }
     
    }
}
