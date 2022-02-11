using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TradingPlatformBlazor.Data.Services
{
    public class Emailing : IEmailingService
    {
        private readonly SmtpClient client;
        public Emailing()
        {
            client = new SmtpClient();
        }
        public void Send(MailMessage message)
        {
            
            message.Subject = "Test message";
            message.Body = "This message sent from C# service";

            client.SendMailAsync(message);
            Console.WriteLine("Send Message");
        }

        public Task SendHtmlMessage()
        {
            throw new NotImplementedException();
        }
    }
}
