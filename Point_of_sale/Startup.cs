using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Point_of_sale.Models;

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
