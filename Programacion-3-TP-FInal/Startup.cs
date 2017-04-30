using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Programacion_3_TP_FInal.Startup))]
namespace Programacion_3_TP_FInal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
