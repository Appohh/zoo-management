using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;

namespace DataCL.DataTraffic
{
    public class PaymentDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "SELECT P.*, PT.Count, PT.TicketID FROM Payment P INNER JOIN PaymentTicket PT ON P.Id = PT.PaymentID INNER JOIN Tickets T ON PT.TicketID = T.Id;";
            }
        }

        public List<PaymentDTO> GetPaymentById(int id)
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
        public bool PayPayment(int id, int paid)
        {
            string query = $"UPDATE Payment SET Paid={paid} WHERE Id = {id} ";
            return executeQuery(query) == 0 ? false : true;
        }
		public bool addPayment(PaymentDTO payment, Dictionary<int, int> ticketCounts)
		{
			string query = $"INSERT INTO Payment (Name, Email, PhoneNumber, TotalPrice,Paid) OUTPUT INSERTED.Id " +
						   $"VALUES ('{payment.Name}','{payment.Email}','{payment.PhoneNumber}', {payment.TotalPrice.ToString(CultureInfo.InvariantCulture)}, {0});";

			int paymentID = executeIdScalar(query);

			if (paymentID > 0)
			{
				foreach (KeyValuePair<int, int> ticketCount in ticketCounts)
				{
					int ticketId = ticketCount.Key;
					int count = ticketCount.Value;

					query = $"INSERT INTO PaymentTicket (PaymentID, TicketID, Count) " +
							$"VALUES ({paymentID}, {ticketId}, {count});";

					executeQuery(query);
				}
				return true;
			}
			else { return false; }
		}
	}
}
