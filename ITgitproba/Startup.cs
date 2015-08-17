using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITgitproba.Startup))]
namespace ITgitproba
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
