using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IQuestaoAppService : IDisposable
	{
		QuestaoViewModel Add(QuestaoViewModel obj);
		QuestaoViewModel GetById(Guid id);
		IEnumerable<QuestaoViewModel> GetAll();
		QuestaoViewModel Update(QuestaoViewModel obj);
		void Remove(Guid id);
        IEnumerable<QuestaoViewModel> Search(Expression<Func<Questao, bool>> func);
    }
}