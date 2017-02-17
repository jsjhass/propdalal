using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Propdalal.Startup))]
namespace Propdalal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
