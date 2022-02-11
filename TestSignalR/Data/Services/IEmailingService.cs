using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Services
{
    interface IEmailingService
    {
        void Send(MailMessage message);
        Task SendHtmlMessage();
    }
}
