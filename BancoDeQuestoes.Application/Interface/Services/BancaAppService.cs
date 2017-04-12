using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{

	public class BancaAppService : AppServiceBase<Banca>, IBancaAppService
	{
		private readonly IBancaService _bancaService;
		public BancaAppService(IBancaService bancaService) : base(bancaService)
		{
			_bancaService = bancaService;
		}
	}
}
