using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaldivesLhen.Web.Startup))]
namespace MaldivesLhen.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
