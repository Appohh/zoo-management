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

        [BindProperty]
        public Order Order { get; set; }

        public TicketsModel()
        {
            paymentRepository = new PaymentRepository();
            tickets = paymentRepository.GetTickets();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostCheckout()
        {

            List<Tuple<int, int>> tickets_ = new List<Tuple<int, int>>();

            int count = tickets_.Sum(t => t.Item2);

            foreach (string key in Request.Form.Keys)
            {
                if (key.StartsWith("row"))
                {
                    string id = key.Replace("row", "");
                    tickets_.Add(Tuple.Create(Convert.ToInt32(id.ToString()), Convert.ToInt32(Request.Form[key])));
                }
                else continue;
            }

            Order.Tickets = tickets_;




            return Page();

        }
    }
}
