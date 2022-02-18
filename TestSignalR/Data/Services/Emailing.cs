using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using System.Net;
using Microsoft.AspNetCore.Components;

namespace TradingPlatformBlazor.Data.Services
{
    public class Emailing : IEmailingService
    {
        private readonly SmtpClient client;
        private readonly IConfiguration _config;
        private readonly MailAddress fromMail;
        public Emailing(IConfiguration config)
        {
            _config = config;
            client = new SmtpClient(_config["Host"], int.Parse(_config["Port"]))
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_config["FromEmail"], _config["Password"])
            };
            fromMail = new MailAddress(_config["FromEmail"], "TradingPlatform");
        }
        public async Task Send(MailMessage message)
        {
            await client.SendMailAsync(message);
            
        }

        public Task SendHtmlMessage()
        {
            throw new NotImplementedException();
        }

        public async Task SendToken(MailAddress toMail, string Token)
        {
            string message = "<b>Перейдите по ссылке для активации аккаунта:</b>" + "<a>" + Token + "</a>";
            MailMessage mailMessage = new(fromMail, toMail)
            {
                Subject = "Активация аккаунта",
                Body = message,
                IsBodyHtml = true
                
            };
            await client.SendMailAsync(mailMessage);
        }
    }
}
