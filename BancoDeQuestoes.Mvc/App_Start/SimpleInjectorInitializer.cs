

[assembly: WebActivator.PostApplicationStartMethod(typeof(BancoDeQuestoes.Mvc.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace BancoDeQuestoes.Mvc.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Domain.Interfaces.Services;
    using Domain.Services;
    using Application.Interface.Repositories;
    using Infra.Data.Repository;
    using Domain.Interfaces.Repository;
    using Infra.Data.UoW;
    using Infra.Data.Context;
    using Application.Interface;
    using global::Microsoft.AspNet.Identity;
    using global::Microsoft.AspNet.Identity.EntityFramework;
    using global::Microsoft.Owin.Security;
    using Models;

    using System.Web;
    using BancoDeQuestoes.Models;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
     
        private static void InitializeContainer(Container container)
        {
            container.Register<IAreaAppService, AreaAppService>(Lifestyle.Scoped);
            container.Register<IBancaAppService, BancaAppService>(Lifestyle.Scoped);
            container.Register<IDisciplinaAppService, DisciplinaAppService>(Lifestyle.Scoped);
            container.Register<IFormacaoRevisorAppService, FormacaoRevisorAppService>(Lifestyle.Scoped);
            container.Register<IMestreAppService, MestreAppService>(Lifestyle.Scoped);
            container.Register<IMestreAreaAppService, MestreAreaAppService>(Lifestyle.Scoped);
            container.Register<IMestreDependenteAppService, MestreDependenteAppService>(Lifestyle.Scoped);
            container.Register<IMestreFormacaoAppService, MestreFormacaoAppService>(Lifestyle.Scoped);
            container.Register<IProjetoAppService, ProjetoAppService>(Lifestyle.Scoped);
            container.Register<IQuestaoAppService, QuestaoAppService>(Lifestyle.Scoped);
            container.Register<IRevisorAppService, RevisorAppService>(Lifestyle.Scoped);
            container.Register<IStatusAppService, StatusAppService>(Lifestyle.Scoped);
            container.Register<ITopicoAtribuidoAppService, TopicoAtribuidoAppService>(Lifestyle.Scoped);

            //Domain
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IAreaService, AreaService>(Lifestyle.Scoped);
            container.Register<IBancaService, BancaService>(Lifestyle.Scoped);
            container.Register<IDisciplinaService, DisciplinaService>(Lifestyle.Scoped);
            container.Register<IFormacaoRevisorService, FormacaoRevisorService>(Lifestyle.Scoped);
            container.Register<IMestreService, MestreService>(Lifestyle.Scoped);
            container.Register<IMestreAreaService, MestreAreaService>(Lifestyle.Scoped);
            container.Register<IMestreDependenteService, MestreDependenteService>(Lifestyle.Scoped);
            container.Register<IMestreFormacaoService, MestreFormacaoService>(Lifestyle.Scoped);
            container.Register<IProjetoService, ProjetoService>(Lifestyle.Scoped);
            container.Register<IQuestaoService, QuestaoService>(Lifestyle.Scoped);
            container.Register<IRevisorService, RevisorService>(Lifestyle.Scoped);
            container.Register<IStatusService, StatusService>(Lifestyle.Scoped);
            container.Register<ITopicoAtribuidoService, TopicoAtribuidoService>(Lifestyle.Scoped);

            //Infra Dados
            container.Register(typeof(IRepository<>), typeof(RepositoryBase<>));
            container.Register<IAreaRepository, AreaRepositoryBase>(Lifestyle.Scoped);
            container.Register<IBancaRepository, BancaRepositoryBase>(Lifestyle.Scoped);
            container.Register<IDisciplinaRepository, DisciplinaRepositoryBase>(Lifestyle.Scoped);
            container.Register<IFormacaoRevisoresRepository, FormacaoRevisoresRepositoryBase>(Lifestyle.Scoped);
            container.Register<IMestreRepository, MestreRepositoryBase>(Lifestyle.Scoped);
            container.Register<IMestreAreaRepository, MestreAreaRepositoryBase>(Lifestyle.Scoped);
            container.Register<IMestreDependenteRepository, MestreDependenteRepsitory>(Lifestyle.Scoped);
            container.Register<IMestreFormacaoRepository, MestreFormacaoRepositoryBase>(Lifestyle.Scoped);
            container.Register<IProjetoRepository, ProjetoRepositoryBase>(Lifestyle.Scoped);
            container.Register<IQuestaoRepository, QuestaoRepositoryBase>(Lifestyle.Scoped);
            container.Register<IRevisorRepository, RevisorRepositoryBase>(Lifestyle.Scoped);
            container.Register<IStatusRepository, StatusRepositoryBase>(Lifestyle.Scoped);
            container.Register<ITopicoAtribuidoRepository, TopicoAtribuidoRepositoryBase>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<Db>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>());
           //container.Register<IAuthenticationManager>(() => HttpContext.Current.GetOwinContext().Authentication);
          
            container.Register<RoleStore<IdentityRole>>(() => new RoleStore<IdentityRole>());
            //container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(container.GetInstance<Db>()));
            //container.Register<IAuthenticationManager>(Lifestyle.Scoped);
            container.Register<IAuthenticationManager>(() => HttpContext.Current.GetOwinContext().Authentication);

        }
    }
}