using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;
using TradingPlatformBlazor.Data.Repository;
using TradingPlatformBlazor.Data.Services;
using System.Net.Mail;

namespace TradingPlatformBlazor.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("/registration")]
    [ApiController]
    public class Registration : ControllerBase
    {
        private readonly string Pattern = @"\p{IsCyrillic}";
        private readonly IUser _userContext;
        private readonly IAccessToken _accessContext;
        private readonly IEmailingService _emailing;

        public Registration(IEmailingService emailing, IUser userContext, IAccessToken accessContext)
        {
            _userContext = userContext;
            _accessContext = accessContext;
            _emailing = emailing;
        }
        public async Task<ActionResult> RegistrationMethod([FromForm] string UserName, [FromForm] string PwdCrypt, [FromForm] string rPwdCrypt, [FromForm] string Email)
        {
           
            if(string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(PwdCrypt) || string.IsNullOrWhiteSpace(rPwdCrypt) || string.IsNullOrWhiteSpace(Email))
            {
                return Redirect("/signup?e=emptyfields");
            }
            if (Regex.IsMatch(UserName, Pattern) || Regex.IsMatch(PwdCrypt, Pattern))
            {
                return Redirect("/signup?e=iscyrillic");
            }
            if (PwdCrypt != rPwdCrypt)
            {
                return Redirect("/signup?e=differentpwd");
            }
            User findUser = _userContext.GetUserByNickname(UserName);
            if(findUser != null)
            {
                return Redirect("/signup?e=reserved");
            }
            findUser = _userContext.GetUserBuEmail(Email);
            if(findUser != null)
            {
                return Redirect("/signup?e=reservedemail");
            }
            string host = Request.Host.Value;
            string protocol = Request.Scheme;
            string Token = CryptPwd(UserName);
            string tokenUrl = protocol +"://" + host + "/access/" + Token;
            _accessContext.AddToken(Token, UserName, CryptPwd(PwdCrypt), Email);
            await _emailing.SendToken(new MailAddress(Email), tokenUrl);
            return Redirect("/signup?e=done"); 
        }
        public static string CryptPwd(string Pwd)
        {
            StringBuilder Sb = new();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(Pwd));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }

    
}
