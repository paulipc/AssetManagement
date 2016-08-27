using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssetManagment.Startup))]
namespace AssetManagment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
