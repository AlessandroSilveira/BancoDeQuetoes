using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class MestreAreaAppService : AppServiceBase<MestreArea>, IMestreAreaAppService
	{
		private IMestreAreaService _mestreAreaService;

		public MestreAreaAppService(IMestreAreaService mestreAreaService):base(mestreAreaService)
		{
			_mestreAreaService = mestreAreaService;
		}
	}
}