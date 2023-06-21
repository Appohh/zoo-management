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
		public Order ApplyDiscount(Order order, string? code)
		{
			decimal discountAmount = 0.0M;
			List<Ticket> tickets = GetTickets();
			List<Discount> discountcodes = GetDiscount();
			decimal? totalPrice = order.TotalPrice;
			int Ticketcounts = 0;
			foreach (Tuple <int,int> ticket in order.Tickets) 
			{
				Ticketcounts += ticket.Item2;
			}

			if (Ticketcounts > 20)
			{
				foreach (var ticketCount in order.Tickets)
				{
					Ticket currentTicket = tickets.First(t => t.Id == ticketCount.Item1);

					decimal discountedPrice = currentTicket.Price;
					if (currentTicket.Name == "TicketKid")
					{
						discountedPrice = 23;
					}
					else if (currentTicket.Name == "TicketAdult")
					{
						discountedPrice = 24.50M;
					}
					discountAmount += (currentTicket.Price - discountedPrice) * ticketCount.Item2;
				}
			}

			Discount appliedDiscount = discountcodes.FirstOrDefault(d => d.Code == code);

			if (appliedDiscount != null)
			{
				discountAmount += 5; 
			}

			order.TotalPrice -= discountAmount;
			order.Discount = discountAmount;
			return order;
		}


        public List <Order> retrieveOrders()
		{
            List<OrderDTO> orderDTOs = paymentDataTraffic.RetrieveAllOrders();
            List<Order> payments = new List<Order>();
            foreach (OrderDTO orderDTO in orderDTOs)
            {
                payments.Add(new Order(orderDTO.Id , orderDTO.Tickets, orderDTO.Name, orderDTO.Email, orderDTO.PhoneNumber, orderDTO.TotalPrice, orderDTO.Paid,orderDTO.Discount));
            }
            return payments;
        }

		public List <Order> GetPaymentById(int id)
		{
			List<OrderDTO> orderDTOs = paymentDataTraffic.GetOrdersByPaymentId(id);
			List<Order> orders = new List<Order>();
			foreach (OrderDTO orderDTO in orderDTOs)
			{
				orders.Add(new Order(orderDTO.Id, orderDTO.Tickets, orderDTO.Name, orderDTO.Email, orderDTO.PhoneNumber, orderDTO.TotalPrice, orderDTO.Paid,orderDTO.Discount));
			}
			return orders;
		}


		public bool addPayment(Order order)
		{
			OrderDTO orderDTO = new OrderDTO(order.Id, order.Tickets, order.Name, order.Email, order.PhoneNumber, order.TotalPrice, order.Paid, order.Discount);
			if (paymentDataTraffic.addPayment(orderDTO))
			{
				return true;
			};
			return false;
		}
		public bool PayPayment(int id, int paid)
		{
			return paymentDataTraffic.PayPayment(id, paid);
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
