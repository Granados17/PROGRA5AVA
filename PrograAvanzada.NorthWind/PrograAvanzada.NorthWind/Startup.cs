using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrograAvanzada.NorthWind.Startup))]
namespace PrograAvanzada.NorthWind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
