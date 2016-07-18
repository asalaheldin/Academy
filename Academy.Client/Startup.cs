using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Academy.Client.Startup))]
namespace Academy.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
