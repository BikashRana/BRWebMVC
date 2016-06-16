using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BRwebMVC.Startup))]
namespace BRwebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
