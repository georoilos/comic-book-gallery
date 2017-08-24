using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComiCBookGallery.Startup))]
namespace ComiCBookGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
