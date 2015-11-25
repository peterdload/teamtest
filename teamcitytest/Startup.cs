using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teamcitytest.Startup))]
namespace teamcitytest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
