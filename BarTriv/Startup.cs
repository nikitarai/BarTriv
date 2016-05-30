using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarTriv.Startup))]
namespace BarTriv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
