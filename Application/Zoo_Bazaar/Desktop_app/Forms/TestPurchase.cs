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
			decimal totalPrice = 100.00M;

			int quantityBabies = Convert.ToInt32(TB_BabyTicket.Value);
			int quantityKids = Convert.ToInt32(TB_KidTicket.Value);
			int quantityAdults = Convert.ToInt32(TB_AdultTicket.Value);

			Dictionary<int, int> ticketCounts = new Dictionary<int, int>();

			ticketCounts.Add(8, quantityBabies);
			ticketCounts.Add(9, quantityKids); 
			ticketCounts.Add(10, quantityAdults); 

			PaymentDTO paymentDTO = new PaymentDTO(0, 0, 0, name, email, phoneNumber, totalPrice);

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
	}
}
