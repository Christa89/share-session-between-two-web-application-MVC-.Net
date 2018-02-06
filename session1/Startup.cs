using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(session1.Startup))]
namespace session1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
