using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateWebApplication.Startup))]
namespace TemplateWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
