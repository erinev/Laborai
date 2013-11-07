using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4_Laboras.Startup))]
namespace _4_Laboras
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
