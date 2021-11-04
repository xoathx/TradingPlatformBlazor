using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLCategory : ICategory
    {
        private readonly DBContext _context;

        public SQLCategory(DBContext context)
        {
            _context = context;
        }
        public void AddCategory(string nameCategory, string descCategory)
        {
            Category newCategory = new()
            {
                NameCategory = nameCategory,
                Description = descCategory
            };
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
        }

        public IEnumerable<Category> AllCategories()
        {
            return _context.Categories;
        }

        public void ChangeCategory(Category changedCategory)
        {
            var category = _context.Categories.Attach(changedCategory);
            category.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {

            var deleteCategory = _context.Categories.Find(id);
            if (deleteCategory != null)
            {
                _context.Categories.Remove(deleteCategory);
            }
            _context.SaveChanges();
        }

        public string GetNameCategory(int id)
        {
            return _context.Categories.FirstOrDefault(n => n.Id == id).NameCategory;
        }

        public int ReciveIdCategory(string nameCategory)
        {
            return _context.Categories.FirstOrDefault(n => n.NameCategory == nameCategory).Id;
        }
    }
}
