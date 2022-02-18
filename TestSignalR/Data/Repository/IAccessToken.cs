using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface IAccessToken
    {
        void AddToken(string Token, string Nick, string PassCrypt, string Email);
        AccessToken FindToken(string Token);
        void UpdateToken(AccessToken accessToken);
    }
}
