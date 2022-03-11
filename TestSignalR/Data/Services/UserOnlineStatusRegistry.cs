using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;
using TradingPlatformBlazor.Data.Repository;

namespace TradingPlatformBlazor.Data.Services
{
    public class UserOnlineStatusRegistry : IUserStatus
    {
        private readonly List<User> UserStatus;
        
        public UserOnlineStatusRegistry()
        {
            UserStatus = new List<User>();
        }
        public async Task SetOnline(User user)
        {
            if (UserStatus.FirstOrDefault(u => u.Id == user.Id) == null)
            {
                UserStatus.Add(user);
            }
        }
        public async Task SetOffline(User user)
        {

            UserStatus.Remove(UserStatus.FirstOrDefault(u => u.Id == user.Id));
            
        }
        public bool GetStatus(int userId)
        {
            return UserStatus.Contains(UserStatus.FirstOrDefault(u => u.Id == userId));
        }

        public List<User> GetOnlineUsers()
        {
            return UserStatus;
        }
    }
}
