using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCL.DTOs
{
    public class PaymentDTO
    {
        public int Id { get; private set; }
        public List<int> TicketIDs { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public decimal TotalPrice { get; private set; }


        public PaymentDTO()
        {

        }

        public PaymentDTO(int id, List<int> ticketIds, string name, string email, string phonenumber, decimal totalprice)
        {
            Id = id;
            TicketIDs = ticketIds;
            Name = name;
            Email = email;
            PhoneNumber = phonenumber;
            TotalPrice = totalprice;
        }
    }
}
