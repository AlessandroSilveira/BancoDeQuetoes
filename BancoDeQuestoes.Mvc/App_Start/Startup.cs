using Owin;

namespace BancoDeQuestoes.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}