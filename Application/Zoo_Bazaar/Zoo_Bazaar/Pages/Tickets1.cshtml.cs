using LogicCL;
using LogicCL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net;

namespace Zoo_Bazaar.Pages
{
    public class Tickets1Model : PageModel
    {
        private PaymentRepository? paymentRepository { get; set; }

        public Order? Order { get; set; }

        public List<Tuple<Ticket, int>>? tickets { get; set; }

        public decimal? Total;


        public Tickets1Model()
        {
            paymentRepository = new PaymentRepository();
            Total = null;
            
        }

        public IActionResult OnGet()
        {

            var prep = Setup();
            if (prep != null)
            {
                return prep;
            }

            return Page();


        }

        public IActionResult Setup()
        {
            var order = TempData["Order"];
            if (order != null)
            {
                Order = JsonConvert.DeserializeObject<Order>(order.ToString());
            }
            else { return Redirect("/Tickets"); }

            List<Ticket>? tickets = new List<Ticket>();
            this.tickets = new List<Tuple<Ticket, int>>();
            tickets = paymentRepository.GetTickets();

            foreach (Tuple<int, int> ticket in Order.Tickets)
            {
                this.tickets.Add(Tuple.Create(tickets.Find(t => t.Id == ticket.Item1), ticket.Item2));
            }

            CalculateTotal();


            return null;
        }

        public void CalculateTotal()
        {
            decimal total = 0;

            foreach(Tuple<Ticket, int> item in tickets)
            {
                total += item.Item2 * item.Item1.Price;
            }

            Total = total;
        }
    }
}
