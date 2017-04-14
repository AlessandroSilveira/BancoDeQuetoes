using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.Interface.Services;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Domain.Services;
using BancoDeQuestoes.Infra.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BancoDeQuestoes.Mvc.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BancoDeQuestoes.Mvc.App_Start.NinjectWebCommon), "Stop")]

namespace BancoDeQuestoes.Mvc.App_Start
{
	using System;
	using System.Web;

	using Microsoft.Web.Infrastructure.DynamicModuleHelper;

	using Ninject;
	using Ninject.Web.Common;
	

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
	        kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
			kernel.Bind<IDisciplinaAppService>().To<DisciplinaAppService>();
			kernel.Bind<IAreaAppService>().To<AreaAppService>();
			kernel.Bind<IProjetoAppService>().To<ProjetoAppService>();
			kernel.Bind<IBancaAppService>().To<BancaAppService>();
			kernel.Bind<IRevisorAppService>().To<RevisorAppService>();
			kernel.Bind<IFormacaoRevisorAppService>().To<FormacaoRevisorAppService>();
			kernel.Bind<IMestreAppService>().To<MestreAppService>();
			kernel.Bind<IMestreAreaAppService>().To<MestreAreaAppService>();
			kernel.Bind<IMestreDependenteAppService>().To<MestreDependenteAppService>();
			kernel.Bind<IMestreFormacaoAppService>().To<MestreFormacaoAppService>();
			kernel.Bind<IQuestaoAppService>().To<QuestaoAppService>();
			kernel.Bind<ITopicoAtribuidoAppService>().To<TopicoAtribuidoAppService>();
			

			kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
			kernel.Bind<IDisciplinaService>().To<DisciplinaService>();
			kernel.Bind<IAreaService>().To<AreaService>();
			kernel.Bind<IProjetoService>().To<ProjetoService>();
			kernel.Bind<IBancaService>().To<BancaService>();
			kernel.Bind<IRevisorService>().To<RevisorService>();
			kernel.Bind<IFormacaoRevisorService>().To<FormacaoRevisorService>();
			kernel.Bind<IMestreService>().To<MestreService>();
			kernel.Bind<IMestreAreaService>().To<MestreAreaService>();
			kernel.Bind<IMestreDependenteService>().To<MestreDependenteService>();
			kernel.Bind<IMestreFormacaoService>().To<MestreFormacaoService>();
			kernel.Bind<IQuestaoService>().To<QuestaoService>();
			kernel.Bind<ITopicoAtribuidoService>().To<TopicoAtribuidoService>();


			kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
			kernel.Bind<IAreaRepository>().To<AreaRepository>();
			kernel.Bind<IRevisorRepository>().To<RevisorRepository>();
			kernel.Bind<IProjetoRepository>().To<ProjetoRepository>();
			kernel.Bind<IBancaRepository>().To<BancaRepository>();
			kernel.Bind<IRevisorRepository>().To<RevisorRepository>();
			kernel.Bind<IFormacaoRevisoresRepository>().To<FormacaoRevisoresRepository>();
			kernel.Bind<IMestreRepository>().To<MestreRepository>();
			kernel.Bind<IMestreAreaRepository>().To<MestreAreaRepository>();
			kernel.Bind<IMestreDependenteRepository>().To<MestreDependenteRepsitory>();
			kernel.Bind<IMestreFormacaoRepository>().To<MestreFormacaoRepository>();
			kernel.Bind<IQuestaoRepository>().To<QuestaoRepository>();
			kernel.Bind<ITopicoAtribuidoRepository>().To<TopicoAtribuidoRepository>();

		}
    }
}
