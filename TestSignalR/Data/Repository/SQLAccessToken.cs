using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLAccessToken : IAccessToken
    {
        private readonly DBContext _context;
        public SQLAccessToken(DBContext context)
        {
            _context = context;
        }
        public void AddToken(string Token, string Nick, string PassCrypt, string Email)
        {
            AccessToken newAccessToken = new AccessToken()
            {
                Token = Token,
                Nick = Nick,
                Passcrypt = PassCrypt,
                Email = Email
            };
            _context.AccessTokens.Add(newAccessToken);
            _context.SaveChanges();
        }

        public AccessToken FindToken(string Token)
        {
            return _context.AccessTokens.Where(s => s.Token == Token).FirstOrDefault();
        }

        public void UpdateToken(AccessToken accessToken)
        {
            var token = _context.AccessTokens.Attach(accessToken);
            token.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
