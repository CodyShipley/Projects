using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnSaleProductsMVC.Startup))]
namespace OnSaleProductsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
