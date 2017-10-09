using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CenterWebMake.Startup))]
namespace CenterWebMake
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
