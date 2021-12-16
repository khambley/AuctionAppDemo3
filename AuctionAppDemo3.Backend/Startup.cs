using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AuctionAppDemo3.Backend.Startup))]

namespace AuctionAppDemo3.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}