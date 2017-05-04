using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFIZZBUZZ.Startup))]
namespace MVCFIZZBUZZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
