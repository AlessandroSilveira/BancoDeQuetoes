using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class RevisorAppService : AppServiceBase<Revisor>, IRevisorAppService
	{
		private IRevisorService _revisorAppService;

		public RevisorAppService(IRevisorService revisorAppService): base(revisorAppService)
		{
			_revisorAppService = revisorAppService;
		}
	}
}
