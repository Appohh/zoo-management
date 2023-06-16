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
        public int CustomerId { get; private set; }
        public List<int> TicketId { get; private set; }

        public Payment(int id, int customerId, List<int> ticketId)
        {
            Id = id;
            CustomerId = customerId;
            TicketId = ticketId;
        }
    }
}
