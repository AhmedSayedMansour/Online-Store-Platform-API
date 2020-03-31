using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStorePlatform.Startup))]
namespace OnlineStorePlatform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
