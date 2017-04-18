using System.Collections.Generic;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class QuestaoAppService : AppServiceBase<Questao>, IQuestaoAppService
	{
		private IQuestaoService _questaoService;

		public QuestaoAppService(IQuestaoService questaoService) : base(questaoService)
		{
			_questaoService = questaoService;
		}

	    public List<GerenciamentoDeQuestoesViewModel> ObterListaGerenciamentoQuestoes<GerenciamentoDeQuestoesViewModel>()
	    {
	        throw new System.NotImplementedException();
	    }
	}
}
