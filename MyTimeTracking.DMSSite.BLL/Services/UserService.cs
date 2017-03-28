using MyTimeTracking.DMSSite.BLL.Extensions;
using MyTimeTracking.DMSSite.BLL.Models;
using MyTimeTracking.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<User> GetAll(
            out int totalCount,
            int pageIndex = 0,
            int pageSize = 10,
            string keyword = "",
             Expression<Func<User, object>> sortExp = null,
            bool ascending = true)
        {
            ValidPager(pageIndex, pageSize);

            if (sortExp == null)
            {
                sortExp = item => item.UserName;
                ascending = true;
            }

            var query = DataProvider.GetAllUsers();

            bool isEmptyKeyword = string.IsNullOrEmpty(keyword);
            query = query.Where(o => isEmptyKeyword || o.UserName.ToLower().Contains(keyword.ToLower()));

            totalCount = query.Count();

            return query
                .Select(ModelMapping.Express.ToBLLUser())
                .OrderBy(sortExp, ascending)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
