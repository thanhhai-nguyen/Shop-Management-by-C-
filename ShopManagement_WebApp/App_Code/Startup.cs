using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopManagementWebApp.Startup))]
namespace ShopManagementWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
