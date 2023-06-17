using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL.Repository
{
	public class PaymentRepository
	{
		private Discount discount;
		private Ticket tickets;
		decimal ticketPrice;
		decimal totalPrice;

		public Payment ApplyDiscount(Payment payment, string code)
		{

            ticketPrice = tickets.Price;
			totalPrice = payment.TotalPrice;
            if (payment.TicketIDs.Count <= 20)
			{
				if (tickets.Name == "TicketBabys")
				{
					//Change ticketprice 
				}
				else if (tickets.Name == "TicketKids")
				{

                    ticketPrice = 23;
				}
				else if (tickets.Name == "TicketsAdults")
				{
                    ticketPrice = 24.50M;
				}
				//calculate new totalprice
			}
		
			if (discount.Code == code)
			{
				totalPrice = totalPrice-5M;
			}

			return payment;

		}
	}
}
