using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Warners.Startup))]
namespace Warners
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
