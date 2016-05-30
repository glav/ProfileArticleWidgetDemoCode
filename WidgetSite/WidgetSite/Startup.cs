using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WidgetSite.Startup))]
namespace WidgetSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
