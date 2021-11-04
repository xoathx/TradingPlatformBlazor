﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLUser : IUser
    {
        private readonly DBContext _context;

        public SQLUser(DBContext context)
        {

            _context = context;
        }

        public IEnumerable<User> AllUsers()
        {
            return _context.Users;
        }

        public void CreateUser(User newUser)
        {
            if (newUser != null)
            {
                _context.Add(newUser);
                _context.SaveChanges();
            }

        }

        public void DeleteUser(int id)
        {
            if (_context.Users.Find(id) != null)
            {
                _context.Remove(_context.Users.Find(id));
            }
        }

        public User FindUserByLogin(string login)
        {
            return _context.Users.Where(i => i.Login == login).FirstOrDefault();
        }

        public double GetUserBalanceById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.Id == userId).Balance;
        }

        public User GetUserById(int id)
        {
            return _context.Users.Where(u => u.Id == id).SingleOrDefault();
        }

        public void ManyBack(int userId, double amount)
        {
            User user = _context.Users.FirstOrDefault(u => u.Id == userId);
            user.Balance += amount;
            var u = _context.Users.Attach(user);
            u.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void ReduceBalance(int userId, double amount)
        {
            User user = _context.Users.FirstOrDefault(u => u.Id == userId);
            user.Balance -= amount;
            var u = _context.Users.Attach(user);
            u.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateUser(User updatedUser)
        {
            var u = _context.Attach(updatedUser);
            u.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
