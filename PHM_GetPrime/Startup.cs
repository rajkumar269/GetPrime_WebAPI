using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PHM_GetPrime.Startup))]
namespace PHM_GetPrime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
