using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToyApp.Startup))]
namespace ToyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
