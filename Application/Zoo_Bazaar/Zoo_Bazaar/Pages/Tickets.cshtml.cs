using LogicCL;
using LogicCL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

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

            if (string.IsNullOrEmpty(Order.Name)) { return Redirect("/Error"); }
            if (string.IsNullOrEmpty(Order.PhoneNumber)) { return Redirect("/Error"); }
            if (string.IsNullOrEmpty(Order.Email)) { return Redirect("/Error"); }

            List<Tuple<int, int>> tickets_ = new List<Tuple<int, int>>();


            foreach (string key in Request.Form.Keys)
            {
                if (key.StartsWith("row"))
                {
                    string id = key.Replace("row", "");
                    tickets_.Add(Tuple.Create(Convert.ToInt32(id.ToString()), Convert.ToInt32(Request.Form[key])));
                }
                else continue;
            }

            if(tickets_.Count < 1)
            {
                return Redirect("/Error");
            }

            Order.Tickets = tickets_;



            //serialize order object
            var json = JsonConvert.SerializeObject(Order);

            TempData["Order"] = json;

            return Redirect("/Tickets1");

        }
    }
}
