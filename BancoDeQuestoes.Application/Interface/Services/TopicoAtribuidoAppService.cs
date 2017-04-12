using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class TopicoAtribuidoAppService : AppServiceBase<TopicoAtribuido> , ITopicoAtribuidoAppService
	{
		private ITopicoAtribuidoService _topicoAtribuidoService;

		public TopicoAtribuidoAppService(ITopicoAtribuidoService topicoAtribuidoService) : base(topicoAtribuidoService)
		{
			_topicoAtribuidoService = topicoAtribuidoService;
		}
	}
}