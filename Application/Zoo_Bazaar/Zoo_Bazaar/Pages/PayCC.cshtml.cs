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
            SaveOrder();
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

            if (paymentRepository.addPayment(Order)) //succes
            {
                //Mail tickets

                SendMail();
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
        private void SaveOrder()
        {
            //serialize order object
            var json = JsonConvert.SerializeObject(Order);

            TempData["Order"] = json;
        }

        private void SendMail()
        {
            Random random = new Random();
            int rndm = random.Next(1, 999);

            getTickets();
            string description = "Hello, " + Order.Name + "\r\n\r\n" + "Here are your tickets: \r\n\r\n";

            foreach(Tuple<Ticket, int> ticket in Tickets)
            {

                Random random1 = new Random();
                int rndm1 = random1.Next(10000, 30000);

                string a = "QR: " + rndm1.ToString() + " " + ticket.Item1.Name + " " + ticket.Item2.ToString() + "\r\n\r\n";
                description += a;
            }

            description += "\r\n\r\n\r\n\r\n Thank you for ordering, \r\n\r\nZooBazaar";


            var fromAddress = "zoobazaar_service@outlook.com";
            var toAddress = Order.Email; 
            var subject = "Zoobazaar tickets for order: # " + rndm.ToString();
            var body = description;

            var smtpHost = "smtp-relay.sendinblue.com";
            var smtpPort = 587;
            var smtpUsername = "zoobazaar_service@outlook.com";
            var smtpPassword = "LjtQUhO6skyrgAW2";

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
