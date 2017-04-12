using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class MestreDependenteAppService : AppServiceBase<MestreDependente>, IMestreDependenteAppService
	{
		private IMestreDependenteService _mestreDependenteService;

		public MestreDependenteAppService(IMestreDependenteService mestreDependenteService):base(mestreDependenteService)
		{
			_mestreDependenteService = mestreDependenteService;
		}
	}
}