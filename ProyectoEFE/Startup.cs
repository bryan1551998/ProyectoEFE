using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoEFE.Startup))]
namespace ProyectoEFE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
