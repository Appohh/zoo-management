using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DataTraffic;
using DataCL.DTOs;

namespace LogicCL.Repository
{
	public class PaymentRepository
	{
		private Discount discount;
		private Ticket tickets;
		decimal ticketPrice;
		decimal totalPrice;
        private PaymentDataTraffic paymentDataTraffic = new PaymentDataTraffic();
		private TicketDataTraffic ticketDataTraffic = new TicketDataTraffic();
		private DiscountDataTraffic DiscountDataTraffic = new DiscountDataTraffic();
		public PaymentDTO ApplyDiscount(PaymentDTO payment, Dictionary<int, int> ticketCounts, string code)
		{
			decimal discountAmount = 0.0M;
			List<Ticket> tickets = GetTickets();
			List<Discount> discountcodes = GetDiscount();
			decimal totalPrice = payment.TotalPrice;
			int totalCount = ticketCounts.Values.Sum();

			if (totalCount > 20)
			{
				foreach (var ticketCount in ticketCounts)
				{
					Ticket currentTicket = tickets.First(t => t.Id == ticketCount.Key);

					decimal discountedPrice = currentTicket.Price;
					if (currentTicket.Name == "TicketKid")
					{
						discountedPrice = 23;
					}
					else if (currentTicket.Name == "TicketAdult")
					{
						discountedPrice = 24.50M;
					}
					discountAmount += (currentTicket.Price - discountedPrice) * ticketCount.Value;
				}
			}

			Discount appliedDiscount = discountcodes.FirstOrDefault(d => d.Code == code);

			if (appliedDiscount != null)
			{
				discountAmount += 5; 
			}

			payment.TotalPrice -= discountAmount;
			return payment;
		}

		public List <Payment> retrievePayments()
		{
            List<PaymentDTO> paymentDTOs = paymentDataTraffic.RetrieveAllPayment();
            List<Payment> payments = new List<Payment>();
            foreach (PaymentDTO paymentDTO in paymentDTOs)
            {
                payments.Add(new Payment(paymentDTO.Id ,paymentDTO.TicketID, paymentDTO.Count, paymentDTO.Name,paymentDTO.Email, paymentDTO.PhoneNumber,paymentDTO.TotalPrice));
            }
            return payments;
        }

		public List <Payment> GetPaymentById(int id)
		{
			List<PaymentDTO> paymentDTOs = paymentDataTraffic.GetPaymentById(id);
			List<Payment> payments = new List<Payment>();
			foreach (PaymentDTO paymentDTO in paymentDTOs)
			{
				payments.Add(new Payment(paymentDTO.Id, paymentDTO.TicketID, paymentDTO.Count, paymentDTO.Name, paymentDTO.Email, paymentDTO.PhoneNumber, paymentDTO.TotalPrice));
			}
			return payments;
		}


		public bool addPayment(PaymentDTO payment, Dictionary<int, int> ticketCounts)
		{
			if (paymentDataTraffic.addPayment(payment, ticketCounts))
			{
				return true;
			};
			return false;
		}

		public List <Ticket> GetTickets()
		{
			List<TicketDTO> ticketDTOs = ticketDataTraffic.retrieveTickets();
			List<Ticket> tickets = new List<Ticket>();
			foreach (TicketDTO ticketDTO in ticketDTOs)
			{
				tickets.Add(new Ticket(ticketDTO.Id, ticketDTO.Name, ticketDTO.Price,ticketDTO.Description));
			}
			return tickets;
		}

		public List<Discount> GetDiscount()
		{
			List<DiscountDTO> discountDTOs = DiscountDataTraffic.retrieveDiscount();
			List<Discount> Discounts = new List<Discount>();
			foreach (DiscountDTO diccountDTO in discountDTOs)
			{
				Discounts.Add(new Discount(diccountDTO.Id, diccountDTO.Code));
			}
			return Discounts;
		}

		//public int CalculateTotalCount(int paymentId)
		//{
		//	List<Payment> payments = GetPaymentById(paymentId);
		//	int totalCount = 0;
		//	foreach (Payment payment in payments)
		//	{
		//		totalCount += payment.Count; 
		//	}
		//	return totalCount;
		//}
	}
}
