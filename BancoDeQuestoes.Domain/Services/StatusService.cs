using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class StatusService : ServiceBase<Status> ,IStatusService
	{
		public StatusService(IRepositoryBase<Status> repositoryBase) : base(repositoryBase)
		{
		}
	}
}