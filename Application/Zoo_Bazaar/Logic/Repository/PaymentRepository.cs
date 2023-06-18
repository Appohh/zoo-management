﻿using System;
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
		public PaymentDTO ApplyDiscount(PaymentDTO payment, int totalcount ,string code)
		{

			ticketPrice = tickets.Price;
			totalPrice = payment.TotalPrice;
			if (totalcount <= 20)
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
				totalPrice = totalPrice - 5M;
			}

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
