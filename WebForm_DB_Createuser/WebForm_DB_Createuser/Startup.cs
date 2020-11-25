using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_DB_Createuser.Startup))]
namespace WebForm_DB_Createuser
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
