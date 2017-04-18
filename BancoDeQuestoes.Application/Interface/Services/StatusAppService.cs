using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class StatusAppService : AppServiceBase<Status>, IStatusAppService
	{
		private IStatusService _statusService;
		

		public StatusAppService(IStatusService statusService):base(statusService)
		{
			_statusService = statusService;
		}
	}
}