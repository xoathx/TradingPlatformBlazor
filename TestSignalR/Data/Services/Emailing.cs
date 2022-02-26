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
        private readonly string Url;
        public Emailing(IConfiguration config)
        {
            _config = config;
            Url = config["Url"];
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
            string message = 
            "<html><head><meta charset='utf-8'><style>" +
            ".welc{margin-left: 50px;}.email{width:200px;height:35px;border: 1px solid #f4f4f4;border-radius:5px;background:#f4f4f4;text-align: center;margin-left: 70px;}" +
            ".link{ margin-top:7px; }"+
            "a{color:#7898f6;text-decoration: none;}" +
            ".main{height: 150px;width: 500px;}" +
            "</style></head>" +
            "<body>" +
            "<div class='main'>" +
            "<p class='welc'>Добро пожаловать в <a href='" + Url +
            "'>Trading Platform</a>!</p>" +
            "<p>Для использования аккаунта его необходимо активировать:</p" +
            "><a class='activate' href='" + Token +
            "'><div class='email'><div class='link'>Активировать аккаунт</div></div></a></div>" +
            "</body>"
            +"</html>";
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
