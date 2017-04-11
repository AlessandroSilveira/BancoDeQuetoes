using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class ProjetoService : ServiceBase<Projeto>, IProjetoService
	{
		public ProjetoService(IRepositoryBase<Projeto> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
