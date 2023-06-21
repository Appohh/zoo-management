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
        public List<Tuple<Ticket, int>>? Tickets { get; set; }

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

        public void getTickets()
        {
            List<Ticket>? tickets = new List<Ticket>();
            Tickets = new List<Tuple<Ticket, int>>();
            tickets = paymentRepository.GetTickets();

            foreach (Tuple<int, int> ticket in Order.Tickets)
            {
                Tickets.Add(Tuple.Create(tickets.Find(t => t.Id == ticket.Item1), ticket.Item2));
            }
        }


        private void SendMail()
        {

            getTickets();
            string description = "Hello, " + Order.Name + "\r\n\r\n" + "Here are your tickets: \r\n\r\n";

            foreach(Tuple<Ticket, int> ticket in Tickets)
            {
                string a = ticket.Item1.Id.ToString() + " " + ticket.Item1.Name + ticket.Item2.ToString() + "\r\n\r\n";
                description += a;
            }

            description += "\r\n\r\n\r\n\r\n Thank you for ordering, \r\n\r\nZooBazaar";


            var fromAddress = "mr.pushkinini@gmail.com";
            var toAddress = "alpay2001@live.nl";
            var subject = "Zoobazaar tickets for order: #" + Order.Id.ToString();
            var body = description;

            var smtpHost = "smtp-relay.sendinblue.com";
            var smtpPort = 587;
            var smtpUsername = "mr.pushkinini@gmail.com";
            var smtpPassword = "tpcwFx28Uv3LhzCS";

            using (var message = new System.Net.Mail.MailMessage(fromAddress, toAddress))
            {
                message.Subject = subject;
                message.Body = body;

                using (var smtpClient = new System.Net.Mail.SmtpClient(smtpHost, smtpPort))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
                    smtpClient.EnableSsl = true;

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }


    }
}
