using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface IMessageShop
    {
        IEnumerable<MessageShop> GetMessagesByUserIdAndShopId(int userId, int shopId);
        IEnumerable<MessageShop> GetMessagesByUserId(int userId);
        IEnumerable<MessageShop> GetMessagesByShopId(int shopId);
        void AddMessage(MessageShop messageShop);
    }
}
