using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class ProjetoService : ServiceBase<Projeto> , IProjetoService
	{
		private IProjetoService _projetoService;
		public ProjetoService(IRepositoryBase<Projeto> repositoryBase, IProjetoService projetoService) : base(repositoryBase)
		{
			_projetoService = projetoService;
		}
	}
}
