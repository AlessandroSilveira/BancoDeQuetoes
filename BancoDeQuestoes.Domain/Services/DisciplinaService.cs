using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class DisciplinaService : ServiceBase<Disciplina>,IDisciplinaService
	{
		private readonly IDisciplinaService _disciplinaService;
		public DisciplinaService(IRepositoryBase<Disciplina> repositoryBase, IDisciplinaService disciplinaService) : base(repositoryBase)
		{
			_disciplinaService = disciplinaService;
		}

		public IEnumerable<Disciplina> Search(IEnumerable<Disciplina> disciplinas)
		{
			return _disciplinaService.Search(disciplinas);
		}
	}
}
