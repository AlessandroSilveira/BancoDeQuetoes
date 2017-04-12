using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class ProjetoAppService : AppServiceBase<Projeto>, IProjetoAppService
	{
		private IProjetoService _projetoService;

		public ProjetoAppService(IProjetoService projetoService) : base(projetoService)
		{
			_projetoService = projetoService;
		}
	}
}
