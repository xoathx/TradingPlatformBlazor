using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface IComment
    {
        Comment GetCommentByOfferId(int offerId);
        IEnumerable<Comment> GetCommentsByToUserId(int toUserId);
        IEnumerable<Comment> GetCommentsByShopId(int shopId);
        void AddComment(Comment comment);
        void RemoveComment(int commentId);
        void ChangeComment(Comment changedComment);
    }
}
