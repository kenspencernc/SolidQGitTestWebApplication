using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolidQGitTestWebApplication.Startup))]
namespace SolidQGitTestWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
