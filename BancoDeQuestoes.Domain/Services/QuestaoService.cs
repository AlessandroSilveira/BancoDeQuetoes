using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class QuestaoService : IQuestaoService
	{
		private readonly IQuestaoRepository _questaoRepository;

		public QuestaoService(IQuestaoRepository questaoRepository)
		{
			_questaoRepository = questaoRepository;
		}

		public Questao Add(Questao obj)
		{
			return _questaoRepository.Add(obj);
		}

		public Questao GetById(Guid id)
		{
			return _questaoRepository.GetById(id);
		}

		public IEnumerable<Questao> GetAll()
		{
			return _questaoRepository.GetAll();
		}

		public Questao Update(Questao obj)
		{
			return _questaoRepository.Update(obj);
		}

		public void Remove(Guid obj)
		{
			_questaoRepository.Remove(obj);
		}

		public void Dispose()
		{
			_questaoRepository.Dispose();
			GC.SuppressFinalize(this);
		}

	    public IEnumerable<Questao> Search(Expression<Func<Questao, bool>> func)
	    {
	        return _questaoRepository.Search(func);
	    }
	}
}