using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(labauthentication.Startup))]
namespace labauthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
