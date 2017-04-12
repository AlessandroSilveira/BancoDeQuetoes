using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class BancaService : ServiceBase<Banca>, IBancaService
	{
		public BancaService(IRepositoryBase<Banca> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
