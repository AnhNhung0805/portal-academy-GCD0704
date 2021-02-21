using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalAcademy.Startup))]
namespace PortalAcademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
