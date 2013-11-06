using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3_Laboras.Startup))]
namespace _3_Laboras
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
