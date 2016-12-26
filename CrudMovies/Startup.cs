using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudMovies.Startup))]
namespace CrudMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
