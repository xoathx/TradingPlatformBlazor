using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Services
{
    public interface IUserStatus
    {
        Task SetOnline(User user);
        Task SetOffline(User user);
        bool GetStatus(int userId);
        List<User> GetOnlineUsers();
    }
}
