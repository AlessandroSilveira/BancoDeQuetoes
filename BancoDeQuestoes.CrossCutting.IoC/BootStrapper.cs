using System;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.Interface.Repositories;
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
			container.Register(typeof(IRepository<>),typeof(Repository<>));
			container.Register<IAreaRepository, AreaRepository>(Lifestyle.Scoped);
			container.Register<IBancaRepository, BancaRepository>(Lifestyle.Scoped);
			container.Register<IDisciplinaRepository, DisciplinaRepository>(Lifestyle.Scoped);
			container.Register<IFormacaoRevisoresRepository, FormacaoRevisoresRepository>(Lifestyle.Scoped);
			container.Register<IMestreRepository, MestreRepository>(Lifestyle.Scoped);
			container.Register<IMestreAreaRepository, MestreAreaRepository>(Lifestyle.Scoped);
			container.Register<IMestreDependenteRepository, MestreDependenteRepsitory>(Lifestyle.Scoped);
			container.Register<IMestreFormacaoRepository, MestreFormacaoRepository>(Lifestyle.Scoped);
			container.Register<IProjetoRepository, ProjetoRepository>(Lifestyle.Scoped);
			container.Register<IQuestaoRepository, QuestaoRepository>(Lifestyle.Scoped);
			container.Register<IRevisorRepository, RevisorRepository>(Lifestyle.Scoped);
			container.Register<IStatusRepository, StatusRepository>(Lifestyle.Scoped);
			container.Register<ITopicoAtribuidoRepository, TopicoAtribuidoRepository>(Lifestyle.Scoped);

		}
	}
}
