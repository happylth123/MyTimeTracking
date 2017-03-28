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

        protected void ValidPager(int pageIndex, int pageSize)
        {
            if (pageIndex < 0)
            {
                throw new ArgumentException("pageIndex");
            }

            if (pageSize < 1)
            {
                throw new ArgumentException("pageSize");
            }
        }

    }
}
