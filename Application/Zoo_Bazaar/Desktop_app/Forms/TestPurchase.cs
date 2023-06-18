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
        private Payment payment;
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
            decimal totalPrice = 0.0M; // Initialize total price to 0

            int quantityBabies = Convert.ToInt32(TB_BabyTicket.Value);
            int quantityKids = Convert.ToInt32(TB_KidTicket.Value);
            int quantityAdults = Convert.ToInt32(TB_AdultTicket.Value);

            Dictionary<int, int> ticketCounts = new Dictionary<int, int>();

            ticketCounts.Add(8, quantityBabies);
            ticketCounts.Add(9, quantityKids);
            ticketCounts.Add(10, quantityAdults);

            // Calculate the total price of all tickets
            foreach (KeyValuePair<int, int> ticketCount in ticketCounts)
            {
                int ticketId = ticketCount.Key;
                int count = ticketCount.Value;

                // Get the ticket price for the current ticket ID
                decimal ticketPrice = GetTicketPrice(ticketId);

                // Calculate the subtotal price for the current ticket type
                decimal subtotalPrice = ticketPrice * count;

                // Add the subtotal price to the total price
                totalPrice += subtotalPrice;
            }

            PaymentDTO paymentDTO = new PaymentDTO(paymentId, 0, 0, name, email, phoneNumber, totalPrice);

            paymentRepository.ApplyDiscount(paymentDTO, ticketCounts, "test");

            // Check if the payment was added successfully
            if (paymentRepository.addPayment(paymentDTO, ticketCounts))
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
            // Retrieve the ticket price from the database or any other source
            // You can implement the logic to fetch the ticket price based on the provided ticketId
            // For now, this method returns a fixed price based on the ticket ID for demonstration purposes
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
