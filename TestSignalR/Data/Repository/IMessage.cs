using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface IMessage
    {
        IEnumerable<Message> GetMessagesByIdFromAndIdTo(int fromId, int toId);
        IEnumerable<Message> GetMessagesByToId(int toId);
        void AddMessage(Message message);
        
    }
}
