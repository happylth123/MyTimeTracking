using MyTimeTracking.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.DMSSite.BLL
{
    public interface IDataProvider
    {
        void Save();

        // User
        IQueryable<User> GetAllUsers();

        User GetUser(string email);

        void Create(User user);

        void Delete(User user);
    }
}
