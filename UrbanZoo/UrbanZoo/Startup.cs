using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UrbanZoo.Startup))]
namespace UrbanZoo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
