using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.DMSSite.BLL
{
    public abstract class ServiceBase
    {
        public ServiceBase()
        {
        }

        public ServiceBase(IDataProvider dataProvider)
        {
            DataProvider = dataProvider;
        }

        protected virtual IDataProvider DataProvider
        {
            get;
            set;
        }

    }
}
