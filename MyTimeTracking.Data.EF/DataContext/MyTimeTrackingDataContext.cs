using MyTimeTracking.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.Data.EF.DataContext
{
    public partial class MyTimeTrackingDataContext : DbContext
    {
        static MyTimeTrackingDataContext()
        {
            Database.SetInitializer<MyTimeTrackingDataContext>(null);
        }

        public MyTimeTrackingDataContext()
            : this("MyTimeTracking")
        {
        }

        public MyTimeTrackingDataContext(string namedConnection)
            : base(namedConnection)
        {
        }

        public virtual IDbSet<User> Users { get; set; }
    }
}
