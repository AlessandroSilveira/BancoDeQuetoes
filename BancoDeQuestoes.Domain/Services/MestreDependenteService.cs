using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class MestreDependenteService : ServiceBase<MestreDependente>, IMestreDependenteService
	{
		public MestreDependenteService(IRepositoryBase<MestreDependente> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
