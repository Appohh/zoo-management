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
		public int TicketID { get; private set; }
		public int Count { get; private set; }
		public string Name { get; private set; }
		public string Email { get; private set; }
		public string PhoneNumber { get; private set; }
		public decimal TotalPrice { get; set; }

		public int Paid { get; set; }
		public PaymentDTO()
		{

		}

		public PaymentDTO(int id, int ticketId, int count, string name, string email, string phonenumber, decimal totalprice, int paid)
		{
			Id = id;
			TicketID = ticketId;
			Count = count;
			Name = name;
			Email = email;
			PhoneNumber = phonenumber;
			TotalPrice = totalprice;
			Paid = paid;
		}
	}
}
