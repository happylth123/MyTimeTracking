using Autofac;
using MyTimeTracking.Data.EF.DataContext;
using MyTimeTracking.DMSSite.BLL;
using MyTimeTracking.DMSSite.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTimeTracking.DMSSite.App_Start
{
    public class DIConfig
    {
        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();

            builder.Register<MyTimeTrackingDataContext>(c =>
            {
                return new MyTimeTrackingDataContext();
            });
            builder.RegisterType<DataProvider>().As<IDataProvider>().InstancePerLifetimeScope();

            builder.Register<Func<MyTimeTrackingDataContext>>(c =>
            {
                ////the 'c' parameter is a temporary; you need to resolve IComponentContext if you want to hang onto it like this
                var cc = c.Resolve<IComponentContext>();
                Func<MyTimeTrackingDataContext> func = () => cc.Resolve<MyTimeTrackingDataContext>();
                return func;
            });

            builder.RegisterType<BLL.Services.UserService>().InstancePerLifetimeScope();
        }
    }
}