using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Point_of_sale.Startup))]
namespace Point_of_sale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
