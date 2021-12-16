using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVsite16.Startup))]
namespace CVsite16
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
