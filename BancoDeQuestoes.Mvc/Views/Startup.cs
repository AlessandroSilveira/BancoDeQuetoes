using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BancoDeQuestoes.Startup))]
namespace BancoDeQuestoes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
