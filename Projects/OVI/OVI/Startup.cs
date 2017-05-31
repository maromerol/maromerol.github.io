using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OVI.Startup))]
namespace OVI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
