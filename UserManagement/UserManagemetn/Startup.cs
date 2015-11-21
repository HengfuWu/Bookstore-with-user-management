using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserManagemetn.Startup))]
namespace UserManagemetn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
