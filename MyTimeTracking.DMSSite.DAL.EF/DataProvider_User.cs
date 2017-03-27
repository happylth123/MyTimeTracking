using MyTimeTracking.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.DMSSite.DAL.EF
{
    public partial class DataProvider
    {
        public IQueryable<User> GetAllUsers()
        {
            return dbcontext.Users.AsQueryable();
        }

        public User GetUser(string email)
        {
            return dbcontext.Users.FirstOrDefault(o => o.Email.ToLower() == email.ToLower());
        }

        public void Create(User user)
        {
            dbcontext.Users.Add(user);
            dbcontext.SaveChanges();
        }

        public void Delete(User user)
        {
            dbcontext.Users.Remove(user);
            dbcontext.SaveChanges();
        }
    }
}
