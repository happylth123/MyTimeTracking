using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTimeTracking.WebAPI.Startup))]
namespace MyTimeTracking.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
