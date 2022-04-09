using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
   public interface ICategory
    {
        IEnumerable<Category> AllCategories();
        Category GetCategoryById(int categoryId);
        void AddCategory(string nameCategory, string descCategory);
        void DeleteCategory(int id);
        void ChangeCategory(Category changedCategory);

        int ReciveIdCategory(string nameCategory);
        string GetNameCategory(int id);
    }
}
