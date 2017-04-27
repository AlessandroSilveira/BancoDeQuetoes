using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IFormacaoRevisorAppService : IDisposable
	{
		RevisorFormacaoViewModel Add(RevisorFormacaoViewModel obj);
		RevisorFormacaoViewModel GetById(Guid id);
		IEnumerable<RevisorFormacaoViewModel> GetAll();
		RevisorFormacaoViewModel Update(RevisorFormacaoViewModel obj);
		void Remove(Guid id);
		IEnumerable<RevisorFormacaoViewModel> Search(Expression<Func<RevisorFormacaoViewModel, bool>> predicate);
	}
}
