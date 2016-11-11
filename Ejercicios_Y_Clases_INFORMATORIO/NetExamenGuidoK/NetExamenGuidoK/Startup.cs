using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetExamenGuidoK.Startup))]
namespace NetExamenGuidoK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
