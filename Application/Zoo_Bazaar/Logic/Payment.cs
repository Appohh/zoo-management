using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class Payment
    {
        public int Id { get; private set; }
        public int TicketID { get; private set; }
        public int Count { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public decimal TotalPrice { get; private set; }


        public Payment()
        {

        }

        public Payment (int id, int ticketId, int count, string name, string email, string phonenumber, decimal totalprice)
        {
            Id = id;
            TicketID = ticketId;
            Count = count;
            Name = name;
            Email = email;
            PhoneNumber = phonenumber;
            TotalPrice = totalprice;
        }
    }
}
