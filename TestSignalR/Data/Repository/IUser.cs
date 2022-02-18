using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
   public interface IUser
    {
        IEnumerable<User> AllUsers();
        IEnumerable<User> GetShopMembersByShopId(int shopId);
        User GetUserById(int id);
        User GetUserByNickname(string nickname);
        User GetUserBuEmail(string email);
        double GetUserBalanceById(int userId);
        bool IsAvatarReserved(string name);
        void CreateUser(User newUser);
        void DeleteUser(int id);
        void ReduceBalance(int userId, double amount);
        void ManyBack(int userId, double amount);
        void UpdateUser(User updatedUser);

    }
}
