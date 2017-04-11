using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class AreaService : ServiceBase<Area>, IAreaService
	{
		public AreaService(IRepositoryBase<Area> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
