using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
            
            var currentUser = _context.FindUserByLogin(userName);
            if (currentUser != null)
            {
                if (currentUser.PassCrypt == passWord)
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

                    if(currentUser.IdShop != 0)
                    { 
                        hubConnection = new HubConnectionBuilder()
                        .WithUrl($"https://localhost:44362/hub").Build();
                        await hubConnection.StartAsync();
                        await hubConnection.SendAsync("CreateGroup", currentUser.Id, _scontext.GetShopById(currentUser.IdShop).ShortNameShop);
                        await hubConnection.StopAsync();
                    }

                    return Redirect("/");
                }
            }
            else
            {
                Console.WriteLine("Log / pass is not corrected");
                Message = "Логин или пароль введены неправильно!";
                
                return Redirect("/signin");
            }
            var user = HttpContext.User;
            if (user.Claims.Any())
            {
                await HttpContext.SignOutAsync();
            }
            return Redirect("/");
        }

        [Microsoft.AspNetCore.Mvc.Route("/logout")]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
