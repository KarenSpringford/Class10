using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Class10.Startup))]
namespace Class10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
