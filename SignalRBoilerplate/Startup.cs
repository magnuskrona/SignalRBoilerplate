using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRBoilerplate.Startup))]
namespace SignalRBoilerplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
