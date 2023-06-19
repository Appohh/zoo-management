using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCL.DTOs;
using static System.Collections.Specialized.BitVector32;

namespace DataCL.DataTraffic
{
    public class TicketDataTraffic : DataHandler
    {
        protected override string cmd
        {
            get
            {
                return "select * from Tickets;";
            }
        }

        public List<TicketDTO> retrieveTickets()
        {

            List<TicketDTO> tickets = new List<TicketDTO>();

            //get datatable of queried data
            DataTable table = ReadData();

            //itterate trough all datarows, validate and convert to DTOs
            foreach (DataRow dr in table.Rows)
            {
                tickets.Add(DataConvertingMethods.ConvertDataRowToObject<TicketDTO>(dr));
            }

            //return collection of DTOs
            return tickets;
        }
        public TicketDTO GetTicketById(int id)
        {
            DataTable table = base.ReadData();
            foreach (DataRow dr in table.Rows)
            {
                TicketDTO ticket = DataConvertingMethods.ConvertDataRowToObject<TicketDTO>(dr);
                if (ticket.Id == id)
                {
                    return ticket;
                }
            }
            return null; // or throw an exception indicating the ticket was not found
        }
    }
}
