using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplicationApi.Startup))]

namespace WebApplicationApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
