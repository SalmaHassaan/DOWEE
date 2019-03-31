using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDowee.Startup))]
namespace ToDowee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
