using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testing_Branding.Startup))]
namespace Testing_Branding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
