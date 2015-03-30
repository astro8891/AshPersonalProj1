using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoachingPlayaround.Startup))]
namespace CoachingPlayaround
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
