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

		public List<OrderDTO> GetOrdersByPaymentId(int id)
		{
			string query = $@"SELECT * FROM Payment WHERE Id = {id};";

			DataTable dt = base.ReadDataQuery(query);
			List<OrderDTO> orders = new List<OrderDTO>();

			if (dt.Rows.Count > 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					OrderDTO order = DataConvertingMethods.ConvertDataRowToObject<OrderDTO>(dr);

					// Fetch tickets for this order
					string ticketQuery = $@"SELECT PT.Count, PT.TicketID FROM PaymentTicket PT WHERE PT.PaymentID = {order.Id};";
					DataTable dtTickets = base.ReadDataQuery(ticketQuery);

					// Process Tickets
					order.Tickets = new List<Tuple<int, int>>();
					foreach (DataRow ticketRow in dtTickets.Rows)
					{
						int ticketId = Convert.ToInt32(ticketRow["TicketID"]);
						int count = Convert.ToInt32(ticketRow["Count"]);
						order.Tickets.Add(new Tuple<int, int>(ticketId, count));
					}

					orders.Add(order);
				}
			}

			return orders.Count > 0 ? orders : null;
		}

		public List<OrderDTO> RetrieveAllOrders()
        {
            List<OrderDTO> payments = new List<OrderDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                payments.Add(DataConvertingMethods.ConvertDataRowToObject<OrderDTO>(dr));
            }

            //return collection of DTOs
            return payments;
        }
        public bool PayPayment(int id, int paid)
        {
            string query = $"UPDATE Payment SET Paid={paid} WHERE Id = {id} ";
            return executeQuery(query) == 0 ? false : true;
        }
		public bool addPayment(OrderDTO order)
		{
			string query = $"INSERT INTO Payment (Name, Email, PhoneNumber, TotalPrice,Paid,Discount) OUTPUT INSERTED.Id " +
						   $"VALUES ('{order.Name}','{order.Email}','{order.PhoneNumber}', {order.TotalPrice?.ToString(CultureInfo.InvariantCulture)}, {1},{order.Discount.ToString(CultureInfo.InvariantCulture)});";

			int paymentID = executeIdScalar(query);

			if (paymentID > 0)
			{
				foreach (Tuple <int, int> items in order.Tickets)
				{
					int ticketId = items.Item1;
					int count = items.Item2;

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
