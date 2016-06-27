using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Checkout.Startup))]
namespace Checkout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
