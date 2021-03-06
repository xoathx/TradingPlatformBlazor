using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Repository;

namespace TradingPlatformBlazor.Data
{
    [Microsoft.AspNetCore.Mvc.Route("/login")]
    [ApiController]
    public class Login : ControllerBase
    {
        public string Message;
        private readonly IUser _context;
        private readonly IShop _scontext;
        private HubConnection hubConnection;

        public Login(IUser context, IShop scontext)
        {
            _context = context;
            _scontext = scontext;
           

        }
        public async Task<ActionResult> LoginMethod([FromForm] string userName, [FromForm] string passWord)
        {
           
            if(string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(passWord))
            {
                return Redirect("/signin?message=error");
            }
            var currentUser = _context.GetUserByNickname(userName);
            if (currentUser != null)
            {
                if (currentUser.PassCrypt == CryptPwd(passWord))
                {
                    IEnumerable<Claim> claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.NameIdentifier, currentUser.Id.ToString()),
                    new Claim(ClaimTypes.Name, currentUser.NickName),
                    new Claim(ClaimTypes.UserData, currentUser.DateRegistration.ToString()),
                    new Claim(ClaimTypes.Role, currentUser.Role.ToString()),
                    new Claim(ClaimTypes.Role, currentUser.NickName),
                    new Claim("PathAvatar", currentUser.PathAvatar),
                    new Claim("UserLevel", currentUser.LevelUser.ToString())
                    };

                    ClaimsIdentity identity = new(claims, "auth");
                    ClaimsPrincipal cp = new(identity);
                    await HttpContext.SignInAsync(cp);

                    if (currentUser.IdShop != 0)
                    {
                        string hub = Request.Scheme + "://" + Request.Host + "/hub";
                        hubConnection = new HubConnectionBuilder()
                        .WithUrl(hub).Build();
                        await hubConnection.StartAsync();
                        await hubConnection.SendAsync("CreateGroup", currentUser.Id, _scontext.GetShopById(currentUser.IdShop).ShortNameShop);
                        await hubConnection.StopAsync();
                    }

                    return Redirect("/");
                }
                else
                {
                    
                    return Redirect("/signin?message=error");
                }
            }
            else
            {
                return Redirect("/signin?message=error");

            }
        }

        [Microsoft.AspNetCore.Mvc.Route("/logout")]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
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
