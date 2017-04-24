using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IMestreDependenteAppService : IDisposable
	{
		MestreDependenteViewModel Add(MestreDependenteViewModel obj);

		MestreDependenteViewModel GetById(Guid id);

		IEnumerable<MestreDependenteViewModel> GetAll();

		MestreDependenteViewModel Update(MestreDependenteViewModel obj);

		void Remove(Guid id);

		IEnumerable<MestreDependenteViewModel> Search(Expression<Func<MestreDependenteViewModel, bool>> predicate);

	}
}