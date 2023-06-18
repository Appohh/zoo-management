using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;

namespace DataCL.DataTraffic
{
    public class PaymentDataTraffic:DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "SELECT P.*, PT.Count, PT.TicketID FROM Payment P INNER JOIN PaymentTicket PT ON P.Id = PT.PaymentID INNER JOIN Tickets T ON PT.TicketID = T.Id;";
            }
        }

        public List <PaymentDTO> GetPaymentById(int id)
        {
            string query = $@"SELECT P.*, PT.Count, PT.TicketID FROM Payment P INNER JOIN PaymentTicket PT ON P.Id = PT.PaymentID INNER JOIN Tickets T ON PT.TicketID = T.Id WHERE p.Id = {id};";


	        List<PaymentDTO> Payments = new List<PaymentDTO>();
			DataTable dt = base.ReadDataQuery(query);

			if (dt.Rows.Count > 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					PaymentDTO payment = DataConvertingMethods.ConvertDataRowToObject<PaymentDTO>(dr);
                    Payments.Add(payment);
				}
				return Payments;
			}
			else { return null; }
			
           
        }
        public List<PaymentDTO> RetrieveAllPayment()
        {
            List<PaymentDTO> payments = new List<PaymentDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                payments.Add(DataConvertingMethods.ConvertDataRowToObject<PaymentDTO>(dr));
            }

            //return collection of DTOs
            return payments;
        }
        public bool AddPayments(PaymentDTO payment)
        {
			string query = $"INSERT INTO Payment (Name, Email, PhoneNumber, TotalPrice) OUTPUT INSERTED.Id " +
						   $"VALUES ('{payment.Name}','{payment.Email}','{payment.PhoneNumber}', {payment.TotalPrice.ToString(CultureInfo.InvariantCulture)});";

			int paymentID = executeIdScalar(query);

			if (paymentID > 0)
			{
				// Insert TicketID associated with this Payment into the PaymentTickets table
				query = $"INSERT INTO PaymentTickets (PaymentID, TicketID, Count) " +
						$"VALUES ({paymentID}, {payment.TicketID}, {payment.Count});";

				executeQuery(query);
			}

			return paymentID > 0;
		}
    }
}
