using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testes_Web_Forms.Startup))]
namespace Testes_Web_Forms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
