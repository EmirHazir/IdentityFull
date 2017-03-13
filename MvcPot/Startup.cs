using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPot.Startup))]
namespace MvcPot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
