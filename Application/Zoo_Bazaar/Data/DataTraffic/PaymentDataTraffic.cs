using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                return "select * from Payment";
            }
        }

        public PaymentDTO GetPaymentById(int id)
        {
            DataTable table = base.ReadData();
            foreach (DataRow dr in table.Rows)
            {
                PaymentDTO payment = DataConvertingMethods.ConvertDataRowToObject<PaymentDTO>(dr);
                if (payment.Id == id)
                {
                    return payment;
                }
            }
            return null; // or throw an exception indicating the ticket was not found
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
            string ticketIds = string.Join(",", payment.TicketIDs.Select(id => id.ToString()));
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("Price", payment.TotalPrice));
            string query = $"INSERT INTO Payment (Id, TicketID, Name, Email,PhoneNumbwe,TotalPrice) " +
                $"VALUES ({payment.Id}, @ticketIds, '{payment.Email}', '{payment.Name}','{payment.PhoneNumber}', @Price);";
            return executeQuery(query,parameters.ToArray()) == 0 ? false : true;
        }
    }
}
