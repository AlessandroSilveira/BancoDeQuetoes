using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IRevisorAppService : IDisposable
	{
		RevisorViewModel Add(RevisorViewModel obj);
		RevisorViewModel GetById(Guid id);
		IEnumerable<RevisorViewModel> GetAll();
		RevisorViewModel Update(RevisorViewModel obj);
		void Remove(Guid id);
		IEnumerable<RevisorViewModel> Search(Expression<Func<RevisorViewModel, bool>> predicate);
	}
}
