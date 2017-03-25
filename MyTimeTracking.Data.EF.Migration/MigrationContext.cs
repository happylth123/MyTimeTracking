using MyTimeTracking.Data.EF.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.Data.EF.Migration
{
    public class MigrationContext : MyTimeTrackingDataContext
    {
        public MigrationContext()
            : this("MyTimeTracking")
        {
        }

        public MigrationContext(string namedConnection) : base(namedConnection) { }
    }
}
