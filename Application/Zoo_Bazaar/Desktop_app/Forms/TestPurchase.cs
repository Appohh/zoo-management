using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCL.DTOs;
using LogicCL;
using LogicCL.Repository;

namespace Desktop_app.Forms
{
    public partial class TestPurchase : Form
    {
        private Order order;
        private PaymentRepository paymentRepository;
        private int paymentId;
        public TestPurchase()
        {
            InitializeComponent();
            this.paymentRepository = new PaymentRepository();
        }

		private void btn_buy_Click(object sender, EventArgs e)
		{
			string name = "John Doe";
			string email = "john.doe@example.com";
			string phoneNumber = "1234567890";
			decimal totalPrice = 0.0M;

			OrderDTO order = new OrderDTO();
			order.Tickets = new List<Tuple<int, int>>();

			order.Tickets.Add(new Tuple<int, int>(8, Convert.ToInt32(TB_BabyTicket.Value)));
			order.Tickets.Add(new Tuple<int, int>(9, Convert.ToInt32(TB_KidTicket.Value)));
			order.Tickets.Add(new Tuple<int, int>(10, Convert.ToInt32(TB_AdultTicket.Value)));

			// Calculate the total price of all tickets
			foreach (Tuple<int, int> ticket in order.Tickets)
			{
				int ticketId = ticket.Item1;
				int count = ticket.Item2;

				// Get the ticket price for the current ticket ID
				decimal ticketPrice = GetTicketPrice(ticketId); 

				// Calculate the subtotal price for the current ticket type
				decimal subtotalPrice = ticketPrice * count;

				// Add the subtotal price to the total price
				totalPrice += subtotalPrice;
			}

			order.Name = name;
			order.Email = email;
			order.PhoneNumber = phoneNumber;
			order.TotalPrice = totalPrice;

			paymentRepository.ApplyDiscount(order, "test");
			if (paymentRepository.addPayment(order)) 
			{
				// The payment was added successfully, you can handle it here
				// For example, show a confirmation message to the user
			}
			else
			{
				// The payment was not added, you can handle the error here
				// For example, show an error message to the user
			}
		}
		private decimal GetTicketPrice(int ticketId)
        {
            switch (ticketId)
            {
                case 8: // Ticket for babies
                    return 0M;
                case 9: // Ticket for kids
                    return 24;
                case 10: // Ticket for adults
                    return 26.50M;
                default:
                    return 0.0M; // Invalid ticket ID, return 0 price or handle the error accordingly
            }
        }
    }
}
