using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranNguyenThaouyen_2011068936.Startup))]
namespace TranNguyenThaouyen_2011068936
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
