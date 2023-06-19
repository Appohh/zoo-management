using LogicCL;
using LogicCL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zoo_Bazaar.Pages
{
    public class TicketsModel : PageModel
    {
        private PaymentRepository? paymentRepository { get; set; }
        public List<Ticket>? tickets { get; set; }


        public TicketsModel()
        {
            paymentRepository = new PaymentRepository();
            tickets = paymentRepository.GetTickets();
        }

        public void OnGet()
        {

        }
    }
}
