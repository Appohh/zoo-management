using LogicCL;
using LogicCL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zoo_Bazaar.Pages
{
    public class HomeModel : PageModel
    {
        PaymentRepository paymentRepository = new PaymentRepository();
        Payment payment;
        public void OnGet()
        {
            paymentRepository.ApplyDiscount(payment, "test");
        }
    }
}
