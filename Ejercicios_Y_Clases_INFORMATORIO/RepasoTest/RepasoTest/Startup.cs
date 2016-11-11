using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepasoTest.Startup))]
namespace RepasoTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
