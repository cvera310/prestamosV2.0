using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuCredito.Startup))]
namespace TuCredito
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
