using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final4125_Morrison.Startup))]
namespace Final4125_Morrison
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
