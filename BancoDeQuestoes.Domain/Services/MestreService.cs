using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class MestreService : ServiceBase<Mestre>, IMestreService
	{
		public MestreService(IRepositoryBase<Mestre> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
