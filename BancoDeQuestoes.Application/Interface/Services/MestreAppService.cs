using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class MestreAppService : AppServiceBase<Mestre>, IMestreAppService
	{
		private IMestreService _mestreService;

		public MestreAppService(IMestreService mestreService):base(mestreService)
		{
			_mestreService = mestreService;
		}
	}
}