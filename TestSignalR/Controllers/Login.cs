using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Repository;

namespace TradingPlatformBlazor.Data
{
    [Route("/login")]
    [ApiController]
    public class Login : ControllerBase
    {
        public string Message;
        private readonly IUser _context;
        
        public Login(IUser context)
        {
            _context = context;

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

        [Route("/logout")]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
