using MyTimeTracking.Data.EF.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.DMSSite.DAL.EF
{
    public class DataProvider
    {
        private readonly MyTimeTrackingDataContext dbcontext;

        public DataProvider(MyTimeTrackingDataContext context)
        {
            dbcontext = context;
        }

        public void Save()
        {
            dbcontext.SaveChanges();
        }
    }
}
