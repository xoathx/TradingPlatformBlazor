using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLMessage : IMessage
    {
        private readonly DBContext _context;

        public SQLMessage(DBContext context)
        {
            _context = context;
        }
        public void AddMessage(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
        }

        public IEnumerable<Message> GetMessagesByIdFromAndIdTo(int fromId, int toId)
        {
            // return _context.Messages.Where(m => m.FromUserId == fromId).Where(t => t.ToUserId == toId);
            return _context.Messages.Where(m => m.FromUserId == fromId && m.ToUserId == toId);
        }

        public IEnumerable<Message> GetMessagesByToId(int toId)
        {
            return _context.Messages.Where(m => m.ToUserId == toId);
            
        }
    }
}
