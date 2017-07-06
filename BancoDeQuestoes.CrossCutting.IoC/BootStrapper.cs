using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Domain.Services;
using BancoDeQuestoes.Infra.CrossCutting.Identity.Configuration;
using BancoDeQuestoes.Infra.CrossCutting.Identity.Context;
using BancoDeQuestoes.Infra.CrossCutting.Identity.Model;
using BancoDeQuestoes.Infra.Data.Context;
using BancoDeQuestoes.Infra.Data.Repository;
using BancoDeQuestoes.Infra.Data.UoW;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace BancoDeQuestoes.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //App
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
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            container.Register<IConviteMestreAppService,ConviteMestreAppService>(Lifestyle.Scoped);
	        container.Register<IRespostaAppService, RespostaAppService>(Lifestyle.Scoped);

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
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            container.Register<IConviteMestreService, ConviteMestreService>(Lifestyle.Scoped);
	        container.Register<IRespostaService, RespostaService>(Lifestyle.Scoped);

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
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<IConviteMestreRepository, ConviteMestreRepository>(Lifestyle.Scoped);
	        container.Register<IRespostaRepository, RespostaRespository>(Lifestyle.Scoped);

			//Context
			container.Register<Db>(Lifestyle.Scoped);
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);

           //Identity
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()),Lifestyle.Scoped);
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(),Lifestyle.Scoped);
            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);
        }
    }
}