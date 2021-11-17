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
        User FindUserByLogin(string login);
        User GetUserById(int id);
        double GetUserBalanceById(int userId);
        void CreateUser(User newUser);
        void DeleteUser(int id);
        void ReduceBalance(int userId, double amount);
        void ManyBack(int userId, double amount);
        void UpdateUser(User updatedUser);

    }
}
