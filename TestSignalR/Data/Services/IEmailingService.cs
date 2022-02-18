using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Services
{
    public interface IEmailingService
    {
        Task Send(MailMessage message);
        Task SendHtmlMessage();
        Task SendToken(MailAddress toMail, string Token);
    }
}
