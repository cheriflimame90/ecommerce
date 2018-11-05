using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecommerce.Web.Startup))]
namespace ecommerce.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
