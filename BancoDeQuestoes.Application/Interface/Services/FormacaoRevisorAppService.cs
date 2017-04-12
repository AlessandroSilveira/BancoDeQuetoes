using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class FormacaoRevisorAppService : AppServiceBase<RevisorFormacao> , IFormacaoRevisorAppService
	{
		private IFormacaoRevisorService _formacaoRevisorService;
		public FormacaoRevisorAppService(IFormacaoRevisorService formacaoRevisorService) : base(formacaoRevisorService)
		{
			_formacaoRevisorService = formacaoRevisorService;
		}
	}
}
