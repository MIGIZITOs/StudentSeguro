using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admStudentAuth.Startup))]
namespace admStudentAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
