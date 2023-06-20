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

        public List<Ticket>? tickets { get; set; }


        public Tickets1Model()
        {
            paymentRepository = new PaymentRepository();
            
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
            this.tickets = new List<Ticket>();
            tickets = paymentRepository.GetTickets();

            foreach (Tuple<int, int> ticket in Order.Tickets)
            {
                this.tickets.Add(tickets.Find(t => t.Id == ticket.Item1));
            }

            return null;
        }
    }
}
