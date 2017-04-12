using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class MestreFormacaoAppService : AppServiceBase<MestreFormacao>, IMestreFormacaoAppService
	{
		private IMestreFormacaoService _mestreFormacaoService;

		public MestreFormacaoAppService(IMestreFormacaoService mestreFormacaoService) : base(mestreFormacaoService)
		{
			_mestreFormacaoService = mestreFormacaoService;
		}
	}
}