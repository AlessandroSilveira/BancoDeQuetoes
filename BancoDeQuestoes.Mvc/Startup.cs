using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BancoDeQuestoes.Mvc.Startup))]
namespace BancoDeQuestoes.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
