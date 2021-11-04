using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLComment : IComment
    {
        private readonly DBContext _context;
        public SQLComment(DBContext context)
        {
            _context = context;
        }

        public void AddComment(Comment comment)
        {
            _context.Add(comment);
            _context.SaveChanges();
        }

        public void ChangeComment(Comment changedComment)
        {
            var comment = _context.Attach(changedComment);
            comment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public Comment GetCommentByOfferId(int offerId)
        {
            return _context.Comments.FirstOrDefault(com => com.OfferId == offerId);
        }

        public IEnumerable<Comment> GetCommentsByToUserId(int toUserId)
        {
            return _context.Comments.Where(com => com.ToUserId == toUserId);
        }

        public void RemoveComment(int commentId)
        {
            _context.Remove(_context.Comments.FirstOrDefault(com => com.Id == commentId));
            _context.SaveChanges();
        }
    }
}
