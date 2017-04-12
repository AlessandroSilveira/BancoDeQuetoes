using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class MestreAreaService : ServiceBase<MestreArea>,IMestreAreaService
	{
		public MestreAreaService(IRepositoryBase<MestreArea> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
