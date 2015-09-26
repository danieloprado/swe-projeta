using Microsoft.Owin;
using Owin;
using PlanSchool.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace PlanSchool.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
