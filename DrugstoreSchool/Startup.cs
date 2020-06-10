using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrugstoreSchool.Startup))]
namespace DrugstoreSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
