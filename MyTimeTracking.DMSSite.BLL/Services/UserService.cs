using MyTimeTracking.DMSSite.BLL.Extensions;
using MyTimeTracking.DMSSite.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.DMSSite.BLL.Services
{
    public class UserService : ServiceBase
    {
        public UserService(IDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public List<User> GetAll()
        {
            var query = DataProvider.GetAllUsers();

            return query.Select(ModelMapping.Express.ToBLLUser())
                .ToList();
        }
    }
}
