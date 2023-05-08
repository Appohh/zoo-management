using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using System.Security.Claims;
using Logic.Models;
using LogicCL;
using LogicCL.Users;

namespace Zoo_Bazaar.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login login { get; set; }
        public LoginService loginService = new LoginService();

        public LoginModel()
        {
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if(!ModelState.IsValid) { return Page(); }

            User? loggedInUser = loginService.validateUserCredentials(login.Email, login.Password);

            if (loggedInUser != null)
            {
                //Check if user trying to login to desktop app is employee
                //if (loggedInUser.GetType() == typeof(Employee))
                //{
                    // Make claims
                    if (ModelState.IsValid && loggedInUser != null)
                    {
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                        new Claim[]
                        {
                        new Claim("id", loggedInUser.Id.ToString()),
                        new Claim(ClaimTypes.Name, loggedInUser.FirstName + " " + loggedInUser.LastName),
                        new Claim(ClaimTypes.Role, "Employee"),
                            }, CookieAuthenticationDefaults.AuthenticationScheme);
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToPage("/Index");
                    }
              //  }
            }

            else
            {
                return Page();
            }

            await HttpContext.ForbidAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Page();



        }

    }
}
