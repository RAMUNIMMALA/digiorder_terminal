using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(digiorder_terminal.Startup))]
namespace digiorder_terminal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
