using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsuarioWebLogin.Startup))]
namespace UsuarioWebLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
