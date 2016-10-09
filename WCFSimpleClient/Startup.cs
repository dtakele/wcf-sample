using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCFSimpleClient.Startup))]
namespace WCFSimpleClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
