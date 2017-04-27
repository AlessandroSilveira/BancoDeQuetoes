using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IMestreFormacaoAppService : IDisposable
	{
		MestreFormacaoViewModel Add(MestreFormacaoViewModel obj);
		MestreFormacaoViewModel GetById(Guid id);
		IEnumerable<MestreFormacaoViewModel> GetAll();
		MestreFormacaoViewModel Update(MestreFormacaoViewModel obj);
		void Remove(Guid id);
		IEnumerable<MestreFormacaoViewModel> Search(Expression<Func<MestreFormacaoViewModel, bool>> predicate);
	}
}