using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sealtech.Weixin.Web.Startup))]
namespace Sealtech.Weixin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
