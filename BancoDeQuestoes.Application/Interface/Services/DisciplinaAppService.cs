using System.Collections.Generic;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Domain.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class DisciplinaAppService : AppServiceBase<Disciplina>,IDisciplinaAppService
	{
		private readonly IDisciplinaService _disciplinaService;

		public DisciplinaAppService(IDisciplinaService disciplinaService): base(disciplinaService)
		{
			_disciplinaService = disciplinaService;
		}

		public IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina form)
		{
			return _disciplinaService.ResultadoPesquisaDisciplina(form);

		}
	}
}
