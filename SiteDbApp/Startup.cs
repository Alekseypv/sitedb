using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteDbApp.Startup))]
namespace SiteDbApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
