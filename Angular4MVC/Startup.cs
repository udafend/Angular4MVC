using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular4MVC.Startup))]
namespace Angular4MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
