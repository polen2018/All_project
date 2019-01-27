using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JHH_Project.Startup))]
namespace JHH_Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
