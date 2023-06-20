using LogicCL;
using LogicCL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zoo_Bazaar.Pages
{
    public class Tickets1Model : PageModel
    {
        private PaymentRepository? paymentRepository { get; set; }
        public List<Ticket>? tickets { get; set; }


        public Tickets1Model()
        {
            paymentRepository = new PaymentRepository();
            tickets = paymentRepository.GetTickets();
        }

        public void OnGet()
        {

        }
    }
}
