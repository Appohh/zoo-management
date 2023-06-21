using LogicCL;
using LogicCL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Beamer_shop.Pages
{
    public class PayCCModel : PageModel
    {
        PaymentRepository paymentRepository { get; set; }
        Order Order { get; set; }

        public PayCCModel()
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


        public IActionResult OnPostPay()
        {
            var prep = Setup();
            if (prep != null)
            {
                return prep;
            }

            //PUT EVERYTHING FROM ORDER IN DB HERE

            if (true) //succes
            {
                //Mail tickets

                return Redirect("/index"); //can make a page with succes text
            }
            else//not succes
            {
                return Redirect("/tickets");
            }

        }


        public IActionResult Setup()
        {
            var order = TempData["Order"];
            if (order != null)
            {
                Order = JsonConvert.DeserializeObject<Order>(order.ToString());
            }
            else { return Redirect("/Tickets"); }




            return null;
        }


    }
}
