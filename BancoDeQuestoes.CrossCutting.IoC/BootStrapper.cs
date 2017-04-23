using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Domain.Services;
using BancoDeQuestoes.Infra.Data.Repository;
using SimpleInjector;


namespace BancoDeQuestoes.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            //App
            container.Register<IAreaAppService, AreaAppService>(Lifestyle.Scoped);

            //Domain
            container.Register<IAreaService, AreaService>(Lifestyle.Scoped);

            //Infra Dados
            container.Register<IAreaRepository, AreaRepository>(Lifestyle.Scoped);
        }
    }
}
